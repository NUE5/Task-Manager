using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    public class Employee
    {
        public string id { set; get; }
        public string name { set; get; }
        public string type { set; get; }
        public string password { set; get; }
        public List<string> tasks { set; get; }
        public List<Project> projects { set; get; }

        public Employee()
        {
            tasks = new List<string>();
            projects = new List<Project>();

        }
    }
}
