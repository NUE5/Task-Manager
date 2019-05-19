using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
   public class Task 
    {
        public int taskID { set; get; }
        public string taskName { set; get; }
        public bool status { set; get; }
        public string empName { set; get; }

        public Task()
        {
          // employee = new Employee();
        }
        public Task(int taskID, string taskName)
        {
            this.taskID = taskID;
            this.taskName = taskName;
            //  employee = new Employee();
        }
        public Task(int taskID, string taskName,bool status)
        {
            this.taskID = taskID;
            this.taskName = taskName;
            this.status = status;
            ///  employee = new Employee();
        }
        public Task(int taskID, string taskName, bool status,string empName)
        {
            this.taskID = taskID;
            this.taskName = taskName;
            this.status = status;
            this.empName = empName;
        }

    }
}
