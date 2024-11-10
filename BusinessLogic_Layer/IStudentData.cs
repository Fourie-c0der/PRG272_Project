using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using PRG272_Project.DataAccess_Layer;
namespace PRG272_Project.BusinessLogic_Layer
{
    internal interface IStudentData
    {
            List<Students> GetAllStudents();
            void AddStudent(Students student);
            void UpdateStudent(Students student);
            void DeleteStudent(string studentId);
            void SaveSummary(int totalStudents, double averageAge);
    }
}
