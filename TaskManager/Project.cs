using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
namespace TaskManager
{
  
    
   public class Project
    {
       
        public string projectName { set; get; }
        public List<Task> tasks { set; get; }
        public List<Employee> employees { set; get; }
        public Project()
        {
            tasks = new List<Task>();
        }

    }
}
