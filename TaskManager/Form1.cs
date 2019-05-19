using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace TaskManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string name;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            bool found = false;
            XmlDocument doc = new XmlDocument();
            doc.Load("employee.xml");
            XmlNodeList list = doc.GetElementsByTagName("Employee");
            for (int i = 0; i < list.Count; i++)
            {
                XmlNodeList children = list[i].ChildNodes;
                string userid = children[0].InnerText;

                string password = children[3].InnerText;
                string type = children[2].InnerText;
                
                if (type == "Admin")
                {
                    if (userid == useridtext.Text && password == passtext.Text)
                    {
                        MessageBox.Show("Admin found");
                        Visible = false;
                        AdminFunctions a = new AdminFunctions();
                        a.Show();
                        found = true;
                        break;
                    }
                }
               else if (type == "User")
                {
                    if (userid == useridtext.Text && password == passtext.Text)
                    {
                         name = children[1].InnerText;
                        MessageBox.Show("employee found");
                        Visible = false;
                        found = true;
                        
                        Form2 form_employee = new Form2(name);
                        form_employee.Show();
                        break;
                    }
                   
                }
            }
            if(!found)
                MessageBox.Show("Wrong Id or Password");

        }

        public string display()
        {
            return name;
        }


    }
}
