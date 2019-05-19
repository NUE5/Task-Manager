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

namespace TaskManager
{
    public partial class projects_data : Form
    {
        public projects_data()
        {
            InitializeComponent();
        }

        private void projects_data_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //dgv_show.Rows.Clear();
            XmlDocument doc = new XmlDocument();
            doc.Load("projects.xml");
            dgv_show.Visible = true;
            XmlNodeList list = doc.GetElementsByTagName("ArrayOfProject");

            for (int i = 0; i < list.Count; i++)
            {
                XmlNodeList childerns = list[i].ChildNodes;

                for (int j = 0; j < childerns.Count; j++)
                {
                    XmlNodeList proj_name = childerns[j].ChildNodes;
                
                    Console.WriteLine(proj_name.Count);
                    XmlNodeList tasks = proj_name[1].ChildNodes;

                    for (int k = 0; k < tasks.Count; k++)
                    {
                        XmlNodeList task = tasks[k].ChildNodes;
                        //XmlNodeList childrens = tasks[k].ChildNodes;
                  
                        dgv_show.Rows.Add(new string[] { proj_name[j].InnerText, task[0].InnerText, task[1].InnerText, task[2].InnerText, task[3].InnerText });
                    }
                    // }
                }
            }
        
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminFunctions admin = new AdminFunctions();
            admin.Show();
        }
    }
}

       