using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PRG272_Project.BusinessLogic_Layer;
namespace PRG272_Project.DataAccess_Layer
{
    public class Students
    {
        public string StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Course { get; set; }
    }
}
