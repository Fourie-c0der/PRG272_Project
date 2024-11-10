using PRG272_Project.DataAccess_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Activities;

namespace PRG272_Project.BusinessLogic_Layer
{
    internal class Manager
    {
        private readonly IStudentData _dataAccess;

        public Manager(IStudentData dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public void AddStudent(Students student)
        {
            ValidateStudent(student, false);
            _dataAccess.AddStudent(student);
        }

        public void UpdateStudent(Students student)
        {
            ValidateStudent(student, true);
            _dataAccess.UpdateStudent(student);
        }

        public void DeleteStudent(string studentId)
        {
            _dataAccess.DeleteStudent(studentId);
        }

        public List<Students> GetAllStudents()
        {
            return _dataAccess.GetAllStudents();
        }

        public void SaveSummary(int totalStudents, double averageAge)
        {
            _dataAccess.SaveSummary(totalStudents, averageAge);
        }

        private void ValidateStudent(Students student, bool isUpdate)
        {
            var errors = new List<string>();

            if (string.IsNullOrWhiteSpace(student.StudentID))
                errors.Add("Student ID is required.");

            if (string.IsNullOrWhiteSpace(student.FirstName))
                errors.Add("First Name is required.");

            if (string.IsNullOrWhiteSpace(student.LastName))
                errors.Add("Last Name is required.");

            if (string.IsNullOrWhiteSpace(student.Course))
                errors.Add("Course is required.");

            if (student.Age <= 0 || student.Age > 120)
                errors.Add("Please enter a valid age between 1 and 120.");

            if (!isUpdate)
            {
                var existingStudent = _dataAccess.GetAllStudents()
                    .FirstOrDefault(s => s.StudentID == student.StudentID);
                if (existingStudent != null)
                {
                    errors.Add("A student with this Student ID already exists.");
                }
            }

            if (errors.Any())
                throw new ValidationException(string.Join("\n", errors));
        }
    }
}

