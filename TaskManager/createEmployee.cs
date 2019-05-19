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
    public partial class createEmployee : Form
    {
        public createEmployee()
        {
            InitializeComponent();
           
        }

        private void createEmployee_Load(object sender, EventArgs e)
        {

        }

        private void createbtn_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            XmlElement employee = doc.CreateElement("employee");
            XmlElement node = doc.CreateElement("name");
            node.InnerText = Text;
            employee.AppendChild(node);
            node = doc.CreateElement("password");
            node.InnerText = passtext.Text;
            employee.AppendChild(node);
            node = doc.CreateElement("type");
            if(adminbtn.Checked)
            {
                node.InnerText = "admin";
            }
            else if(userbtn.Checked)
            {
                node.InnerText = "user";
            }
            else
            {
                MessageBox.Show("Please Select Employee Type");
            }
            employee.AppendChild(node);
            doc.Load("employee.xml");
            XmlElement root = doc.DocumentElement;
            root.AppendChild(employee);
            doc.Save("employee.xml");
            MessageBox.Show("successfully added");
        }

        private void adminbtn_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
