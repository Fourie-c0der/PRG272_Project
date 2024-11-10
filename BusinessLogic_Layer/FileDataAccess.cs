using PRG272_Project.DataAccess_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PRG272_Project.BusinessLogic_Layer
{
    public class FileDataAccess : IStudentData
    {
        private readonly string _studentFilePath;
        private readonly string _summaryFilePath;

        public FileDataAccess()
        {
            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            _studentFilePath = Path.Combine(baseDir, "students.txt");
            _summaryFilePath = Path.Combine(baseDir, "summary.txt");
            InitializeFiles();
        }

        private void InitializeFiles()
        {
            if (!File.Exists(_studentFilePath))
                File.Create(_studentFilePath).Close();
            if (!File.Exists(_summaryFilePath))
                File.Create(_summaryFilePath).Close();
        }

        public List<Students> GetAllStudents()
        {
            try
            {
                if (!File.Exists(_studentFilePath))
                    return new List<Students>();

                return File.ReadAllLines(_studentFilePath)
                    .Where(line => !string.IsNullOrEmpty(line))
                    .Select(line =>
                    {
                        var parts = line.Split('|');
                        return new Students
                        {
                            StudentID = parts[0],
                            FirstName = parts[1],
                            LastName = parts[2],
                            Age = int.Parse(parts[3]),
                            Course = parts[4]
                        };
                    })
                    .ToList();
            }
            catch (Exception)
            {
                return new List<Students>();
            }
        }

        public void AddStudent(Students student)
        {
            var line = $"{student.StudentID}|{student.FirstName}|{student.LastName}|{student.Age}|{student.Course}";
            File.AppendAllText(_studentFilePath, line + Environment.NewLine);
        }

        public void DeleteStudent(string studentId)
        {
            try
            {
                var lines = File.ReadAllLines(_studentFilePath).ToList();
                var updatedLines = lines.Where(line => !line.StartsWith($"{studentId}|")).ToList();

                if (lines.Count == updatedLines.Count)
                    throw new Exception("Student not found.");

                File.WriteAllLines(_studentFilePath, updatedLines);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error deleting student: {ex.Message}");
            }
        }

        public void SaveSummary(int totalStudents, double averageAge)
        {
            try
            {
                string summaryContent = 
                    $"STUDENT SUMMARY REPORT\n" +
                    $"Date: {DateTime.Now}\n" +
                    $"Total Students: {totalStudents}\n" +
                    $"Average Age: {averageAge:F2}\n";

                File.WriteAllText(_summaryFilePath, summaryContent);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error saving summary: {ex.Message}");
            }
        }

        public void UpdateStudent(Students student)
        {
            try
            {
                // Read all existing students
                var students = GetAllStudents();
                
                // Find the student to update
                var studentToUpdate = students.FirstOrDefault(s => s.StudentID == student.StudentID);
                if (studentToUpdate == null)
                {
                    throw new Exception("Student not found.");
                }

                // Update the student's information
                studentToUpdate.FirstName = student.FirstName;
                studentToUpdate.LastName = student.LastName;
                studentToUpdate.Age = student.Age;
                studentToUpdate.Course = student.Course;

                // Convert all students back to file format
                var lines = students.Select(s => 
                    $"{s.StudentID}|{s.FirstName}|{s.LastName}|{s.Age}|{s.Course}");

                // Write all lines back to the file
                File.WriteAllLines(_studentFilePath, lines);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error updating student in file: {ex.Message}");
            }
        }
    }
}
