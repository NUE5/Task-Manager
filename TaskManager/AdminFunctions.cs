using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Xml.Serialization;

namespace TaskManager
{
    public partial class AdminFunctions : Form
    {
        int rowNum,rownum2,rownum3,c;
        List<List<Project>> projects = new List<List<Project>>();
        List<Project> projectList = new List<Project>();
        List<List<Project>> projects2 = new List<List<Project>>();
        List<Employee> employees3 = new List<Employee>();

        List<Project> projects3 = new List<Project>();
        List<Project> projectList2 = new List<Project>();
        List<Project> projectList3 = new List<Project>();
        List<Employee> employees = new List<Employee>();
        List<Employee> employees2 = new List<Employee>();
        //task list for each project
        List<string> projectsName = new List<string>();
        List<Task> tsk = new List<Task>();
        List<List<Task>> tasklist = new List<List<Task>>();
        int rownum = 0;
        public AdminFunctions()
        {
            InitializeComponent();
            ProjectTabs.Hide();
            EmployeeTabs.Hide();
            choose_emp_namePanel.Hide();
            load_project();
            deserialize();


        }
        public void deserialize()
        {
           
            if (File.Exists("projects.xml"))
            {
                XmlSerializer xs = new XmlSerializer(projectList.GetType());
                FileStream fs = new FileStream("projects.xml", FileMode.Open);
                projectList = (List<Project>)xs.Deserialize(fs);
                fs.Close();
               // Console.WriteLine(projectList.Count);
                //Console.WriteLine("Tasks count in each project list");
                for (int i = 0; i < projectList.Count; i++)
                {
                    tasklist.Add(projectList[i].tasks);
                }
                
                projects_dgv.DataSource = projectList;
                grd_CreateTask.DataSource= projectList;
                employee_dgv.DataSource = projectList;
                dataGridView3.DataSource = projectList;
                dataGridView6.DataSource = projectList;

                dataGridView5.DataSource = ProjectsList;
            }
            if (File.Exists("employee.xml"))
            {
                XmlSerializer xs = new XmlSerializer(employees.GetType());
                FileStream fs = new FileStream("employee.xml", FileMode.Open);
                employees = (List<Employee>)xs.Deserialize(fs);
                fs.Close();
                dgv_Projects.DataSource = employees;
                dataGridView5.DataSource = employees;
            }
            if(File.Exists("project.xml"))
            {
                XmlSerializer xs = new XmlSerializer(projects3.GetType());
                FileStream fs = new FileStream("projets.xml",FileMode.Open);
                projects3 = (List<Project>)xs.Deserialize(fs);
                fs.Close();
             //   CloseGridView.DataSource = projects3;
                //   tasks = new 
            }

        }
        private void createEMPbtn_Click(object sender, EventArgs e)
        {
            //  Visible = false;

        }
       
        private void createbtn_Click(object sender, EventArgs e)
        {
            
            Employee p = new Employee();
            p.name = nametext.Text;
            p.id = idtext.Text;
            p.password = passtext.Text;
            List<Project> projects = new List<Project>();
            if (adminbtn.Checked) p.type = "Admin";
            if(userbtn.Checked) p.type = "User";

            employees.Add(p);
            XmlSerializer xs = new XmlSerializer(employees.GetType());
            FileStream fs = new FileStream("employee.xml", FileMode.Create);
            xs.Serialize(fs, employees);
            fs.Close();
          //  load_project();
            MessageBox.Show("successfully added");
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void createProjectBtn_Click(object sender, EventArgs e)
        {
            
            Project p = new Project();
            p.projectName = projectName.Text;
            List<Task> tasks = new List<Task>();
            for (int i = 0; i < tasksgrid.Rows.Count - 1; i++)
            {
                Task t = new Task();
                t.taskID =int.Parse( tasksgrid.Rows[i].Cells[0].Value.ToString());
                t.taskName = tasksgrid.Rows[i].Cells[1].Value.ToString();
                tasks.Add(t);
            }
            p.tasks = tasks;
            projectList.Add(p);
            XmlSerializer xs = new XmlSerializer(projectList.GetType());
            FileStream fs = new FileStream("projects.xml", FileMode.Create);
            xs.Serialize(fs, projectList);
            fs.Close();
            load_project();
            MessageBox.Show("successfully added");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EmployeeTabs.Show();
            ProjectTabs.Hide();
        }

        private void Project_btn_Click(object sender, EventArgs e)
        {
            EmployeeTabs.Hide();
            ProjectTabs.Show();
        }

        private void EditProject_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ProjectsList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void load_project()
        {
            ProjectsList.Items.Clear();
            if (File.Exists("projects.xml"))
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("projects.xml");

                XmlNodeList list = doc.GetElementsByTagName("ArrayOfProject");
                for (int i = 0; i < list.Count; i++)
                {
                    XmlNodeList childerns = list[i].ChildNodes;
                    for (int j = 0; j < childerns.Count; j++)
                    {
                        XmlNodeList proj_name = childerns[j].ChildNodes;    
                        ProjectsList.Items.Add(proj_name[0].InnerText);
                        comboBox1.Items.Add(proj_name[0].InnerText);
                    }
                }
            }
        }



        private void Edit_Proj_btn_Click_1(object sender, EventArgs e)
        {
            //EditProject_dgv.Rows.Clear();
            //XmlDocument doc = new XmlDocument();
            //doc.Load("projects.xml");

            //XmlNodeList list = doc.GetElementsByTagName("ArrayOfProject");
            //for (int i = 0; i < list.Count; i++)
            //{
            //    XmlNodeList childerns = list[i].ChildNodes;

            //    for (int j = 0; j < childerns.Count; j++)
            //    {
            //        XmlNodeList proj_name = childerns[j].ChildNodes;
            //        if (proj_name[0].InnerText == ProjectsList.SelectedItem.ToString())
            //        {
            //            XmlNodeList tasks = proj_name[1].ChildNodes;
            //            for (int k = 0; k < tasks.Count; k++)
            //            {
            //                XmlNodeList task = tasks[k].ChildNodes;
            //                EditProject_dgv.Rows.Add(new string[] { task[0].InnerText, task[1].InnerText });
            //            }
            //        }
            //    }
            //}

           
        }
        private void AdminFunctions_Load(object sender, EventArgs e)
        {

        }

        private void AdminFunctions_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void EditTaskbtn_Click(object sender, EventArgs e)
        {
            
        }

        private void CreateTaskbtn_Click(object sender, EventArgs e)
        {

        }

        private void projects_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(projects_dgv.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                panelTasks.Visible = true;
                rownum = e.RowIndex;
                grd_task.DataSource = tasklist[rownum];
            }
            
        }

        private void donebtn_Click(object sender, EventArgs e)
        {
           
            panelTasks.Visible = false;
         
            List<Task> tasklst = new List<Task>();
       
            for (int i = 0; i < grd_task.Rows.Count-1; i++)
            {
                Task t = new Task(int.Parse(grd_task.Rows[i].Cells[0].Value.ToString()), grd_task.Rows[i].Cells[1].Value.ToString());
                tasklst.Add(t);
            }
            MessageBox.Show("successfully added");

        }
        
        private void saveTaskbtn_Click(object sender, EventArgs e)
        {
           
           
            for(int i=0;i<projects_dgv.Rows.Count;i++)
            {
           
                Project p = new Project();
                p.projectName = projects_dgv.Rows[i].Cells[1].Value.ToString();
                p.tasks = tasklist[i];
                projectList2.Add(p);
            }                                                                    
            XmlSerializer xs = new XmlSerializer(projectList.GetType());
            FileStream fs = new FileStream("projects.xml", FileMode.Create);
            xs.Serialize(fs, projectList2);
            fs.Close();
            MessageBox.Show("successfully Saved");

        }

        private void grd_CreateTask_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void grd_CreateTask_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (grd_CreateTask.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                panelCreateTask.Visible = true;
                rownum = e.RowIndex;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            panelCreateTask.Visible = false;

            List<Task> tasklst = new List<Task>();
          
            for (int i = 0; i < grd_tasks2.Rows.Count - 1; i++)
            {
                Task t = new Task(int.Parse(grd_tasks2.Rows[i].Cells[0].Value.ToString()), grd_tasks2.Rows[i].Cells[1].Value.ToString());
                tasklst.Add(t);
                tasklist[rownum].Add(t);
            }
            grd_tasks2.Rows.Clear();
            MessageBox.Show("successfully added");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < projects_dgv.Rows.Count; i++)
            {
                Console.WriteLine("enterded");
                Project p = new Project();
                p.projectName = projects_dgv.Rows[i].Cells[1].Value.ToString();
                p.tasks = tasklist[i];
                projectList2.Add(p);
            }
            XmlSerializer xs = new XmlSerializer(projectList.GetType());
            FileStream fs = new FileStream("projects.xml", FileMode.Create);
            xs.Serialize(fs, projectList2);
            fs.Close();
            MessageBox.Show("successfully Saved");

        }

        private void addEmployee_btn_Click(object sender, EventArgs e)
        {

            for(int i = 0; i < dgv_Projects.Rows.Count; i++)
            {
                Employee em = new Employee();
                em.id = dgv_Projects.Rows[i].Cells[1].Value.ToString();
                em.name = dgv_Projects.Rows[i].Cells[2].Value.ToString();
                em.password = dgv_Projects.Rows[i].Cells[3].Value.ToString();
                em.type = dgv_Projects.Rows[i].Cells[4].Value.ToString();
              
                
                employees2.Add(em);
            }

            XmlSerializer s = new XmlSerializer(employees2.GetType());
            FileStream fs = new FileStream("employee.xml",FileMode.Create);
            s.Serialize(fs, employees2);
            fs.Close();

            MessageBox.Show("successfully added");
        }

        private void dgv_Projects_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgv_Projects.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                EmployeePanel.Visible = true;
                rowNum = e.RowIndex;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            EmployeePanel.Visible = false;
            List<Project> list = new List<Project>();
            for(int i = 0; i < employee_dgv.Rows.Count ;i++)
            {
               if(employee_dgv.Rows[i].Cells[0].Value != null && employee_dgv.Rows[i].Cells[0].Value.ToString() == "True")
                {
                    list.Add(projectList[i]);
                }
            }
            while (projects.Count <= rowNum)
                projects.Add(new List<Project>());
            projects[rowNum] = list;
            for (int i = 0; i < employee_dgv.Rows.Count; i++)
                employee_dgv.Rows[i].Cells[0].Value = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;

            List<Task> tasklst = new List<Task>();

            for (int i = 0; i < dataGridView4.Rows.Count ; i++)
            {
                Task t = new Task(int.Parse(dataGridView4.Rows[i].Cells[0].Value.ToString()), dataGridView4.Rows[i].Cells[1].Value.ToString(), dataGridView4.Rows[i].Cells[2].Selected, Emp_task_cb.SelectedItem.ToString());
                tasklst.Add(t);
            }
            tasklist[c] = tasklst;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView3.Rows.Count; i++)
            {

                Project p = new Project();
                p.projectName = projects_dgv.Rows[i].Cells[1].Value.ToString();
                p.tasks = tasklist[i];
                projectList2.Add(p);
            }
            XmlSerializer xs = new XmlSerializer(projectList.GetType());
            FileStream fs = new FileStream("projects.xml", FileMode.Create);
            xs.Serialize(fs, projectList2);
            fs.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         
            c = comboBox1.SelectedIndex;
            Console.WriteLine(c);
           
            dataGridView1.DataSource = tasklist[c];
        }
        public void loadEmployees()
        {
            ProjectsList.Items.Clear();
            if (File.Exists("employee.xml"))
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("employee.xml");

                XmlNodeList list = doc.GetElementsByTagName("ArrayOfEmployee");
                for (int i = 0; i < list.Count; i++)
                {
                    XmlNodeList childerns = list[i].ChildNodes;
                    for (int j = 0; j < childerns.Count; j++)
                    {
                        XmlNodeList Emp_name = childerns[j].ChildNodes;
                        comboBox1.Items.Add(Emp_name[1].InnerText);
                    }
                }
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void Emp_task_cb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            projects_data p1 = new projects_data();
            p1.Show();
            this.Hide();
        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView5.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                panel3.Visible = true;
                rownum2 = e.RowIndex;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            List<Project> list = new List<Project>();
            for (int i = 0; i < employee_dgv.Rows.Count; i++)
            {
                if (employee_dgv.Rows[i].Cells[0].Value != null && employee_dgv.Rows[i].Cells[0].Value.ToString() == "True")
                {
                    list.Add(projectList[i]);
                }
            }
            while (projects.Count <= rowNum)
                projects.Add(new List<Project>());
            projects[rowNum] = list;
            for (int i = 0; i < employee_dgv.Rows.Count; i++)
                employee_dgv.Rows[i].Cells[0].Value = false;
        }

        private void button9_Click_1(object sender, EventArgs e)
        {

            for (int i = 0; i < dataGridView5.Rows.Count; i++)
            {
                Employee em = new Employee();
                em.id = dataGridView5.Rows[i].Cells[1].Value.ToString();
                em.name = dataGridView5.Rows[i].Cells[2].Value.ToString();
                em.password = dataGridView5.Rows[i].Cells[3].Value.ToString();
                em.type = dataGridView5.Rows[i].Cells[4].Value.ToString();
                if (i < projects2.Count)
                    em.projects = projects2[i];
                else
                    em.projects = null;
                employees3.Add(em);
            }

            XmlSerializer s = new XmlSerializer(employees3.GetType());
            FileStream fs = new FileStream("employee.xml", FileMode.Create);
            s.Serialize(fs, employees3);
            fs.Close();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            EditProject_dgv.Rows.Clear();
            XmlDocument doc = new XmlDocument();
            doc.Load("projects.xml");

            XmlNodeList list = doc.GetElementsByTagName("ArrayOfProject");
            for (int i = 0; i < list.Count; i++)
            {
                XmlNodeList childerns = list[i].ChildNodes;

                for (int j = 0; j < childerns.Count; j++)
                {
                    XmlNodeList proj_name = childerns[j].ChildNodes;
                    if (proj_name[0].InnerText == ProjectsList.SelectedItem.ToString())
                    {
                        XmlNodeList tasks = proj_name[1].ChildNodes;
                        for (int k = 0; k < tasks.Count; k++)
                        {
                            XmlNodeList task = tasks[k].ChildNodes;
                            EditProject_dgv.Rows.Add(new string[] { task[0].InnerText, task[1].InnerText });
                        }
                    }
                }
            }
            doc.Save("projects.xml");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            List<Project> list = new List<Project>();
            for (int i = 0; i < dataGridView7.Rows.Count; i++)
            {
                if (dataGridView7.Rows[i].Cells[0].Value != null && dataGridView7.Rows[i].Cells[0].Value.ToString() == "True")
                {
                    list.Add(projectList[i]);
                }
            }
            while (projects2.Count <= rownum2)
                projects2.Add(new List<Project>());
            projects2[rownum2] = list;
            for (int i = 0; i < dataGridView5.Rows.Count; i++)
                dataGridView5.Rows[i].Cells[0].Value = false;
        }

        private void emp_task_btn_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;

            List<Task> tasklst = new List<Task>();

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {


                Task t= new Task(int.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString()), dataGridView1.Rows[i].Cells[2].Value.ToString());
                   
                
                if(i==c)
                {
               t = new Task(int.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString()), dataGridView1.Rows[i].Cells[2].Value.ToString(), dataGridView1.Rows[i].Cells[3].Selected, Emp_task_cb.SelectedItem.ToString());
                   
                }
            tasklst.Add(t);
        }
            tasklist[c] = tasklst;
            Project p = new Project();
                p.projectName = comboBox1.SelectedItem.ToString();
                p.tasks = tasklist[c];
                
                projectList3.Add(p);
            
            XmlSerializer xs = new XmlSerializer(projectList.GetType());
            FileStream fs = new FileStream("projects.xml", FileMode.Create);
            xs.Serialize(fs, projectList3);
            fs.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grd_CreateTask.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                choose_emp_namePanel.Visible = true;
                for(int i=0;i<employees.Count;i++)
                {
                    Emp_task_cb.Items.Add(employees[i].name);
                }
            }
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView3.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                panel1.Visible = true;
                rownum2 = e.RowIndex;
                dataGridView4.DataSource = tasklist[rownum2];
            }
        }
    }
}
