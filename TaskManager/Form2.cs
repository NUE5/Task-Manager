using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Xml;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManager
{
    public partial class Form2 : Form
    {
        
        private readonly object TextTo;
        string emp_id;
        public Form2()
        {
            InitializeComponent();
            display();
        }

        public Form2(string e)
        {
            InitializeComponent();
             emp_id=e;
            Console.WriteLine(emp_id);
            display();
        }
        Form1 f1 = new Form1();
        
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void send_button_Click(object sender, EventArgs e)
        {
            try
            {

                WebClient client = new WebClient();
                Stream s = client.OpenRead(string.Format("https://platform.clickatell.com/messages/http/send?apiKey=Z4D0yKlAQ9Wehw9kMYQ8Dw==&to={0}&content={1}", Text));
                StreamReader reader = new StreamReader(s);
                string result = reader.ReadToEnd();
                MessageBox.Show(result, "message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void display()
        {
          
            //XmlNodeList list = doc.GetElementsByTagName("project");
            //for (int i = 0; i < list.Count; i++)
            //{
            //    XmlNodeList childerns = list[i].ChildNodes;

            //    string projectname = childerns[0].Name;
            //    string ivlaue = childerns[0].InnerText;

            //    string taskid = childerns[1].Name;
            //    string pvlaue = childerns[1].InnerText;

            //    string tsakname = childerns[2].Name;
            //    string nvlaue = childerns[2].InnerText;

            //    projectname_text_box.Text = ivlaue;
            //    taskname_text_box.Text = nvlaue;
            //    taskid_textbox.Text = pvlaue;


            // }
            XmlDocument doc = new XmlDocument();
            doc.Load("projects.xml");
            XmlNodeList list = doc.GetElementsByTagName("ArrayOfProject");

            for (int i = 0; i < list.Count; i++)
            {
                XmlNodeList childerns = list[i].ChildNodes;

                for (int j = 0; j < childerns.Count; j++)
                {
                    XmlNodeList proj_name = childerns[j].ChildNodes;
                  
            
                    XmlNodeList tasks = proj_name[1].ChildNodes;

                    for (int k = 0; k < tasks.Count; k++)
                    {
                        XmlNodeList task = tasks[k].ChildNodes;
                        XmlNodeList childrens = tasks[k].ChildNodes;
                        
                  if(task[1].InnerText==emp_id)
                        {
                            projectname_text_box.Text = proj_name[j].InnerText;
                            taskname_text_box.Text = task[1].InnerText;
                            taskid_textbox.Text = task[0].InnerText;
                        }
                        
                       
                    }
                 
                }
            }
            }
        private void select_filder_button_Click(object sender, EventArgs e)
        {
            string selectdfolderpath = select_folder_text_box.Text;
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.RootFolder = Environment.SpecialFolder.Desktop;
            fbd.Description = "..select your folder...";
            fbd.ShowNewFolderButton = false;
            if (fbd.ShowDialog() == DialogResult.OK) {

                select_folder_text_box.Text = fbd.SelectedPath+"\\"; }
            if (!File.Exists("attachedfiles.xml"))
            {
                XmlWriter writer = XmlWriter.Create("attachedfiles.xml");
                writer.WriteStartDocument();
                writer.WriteStartElement("table");
                writer.WriteAttributeString("name", "attachedfiles");

                writer.WriteStartElement("file1");
                writer.WriteStartElement("path");
                writer.WriteString(select_folder_text_box.Text);
                writer.WriteEndElement();

                writer.WriteStartElement("projectname");
                writer.WriteString(projectname_text_box.Text);
                writer.WriteEndElement();

                writer.WriteStartElement("taskname");
                writer.WriteString(taskname_text_box.Text);
                writer.WriteEndElement();


                writer.WriteStartElement("taskid");
                writer.WriteString(taskid_textbox.Text);
                writer.WriteEndElement();

                
               

                writer.WriteEndElement();
                writer.WriteEndElement();

                writer.WriteEndDocument();
                writer.Close();
            }
            else
            {
                XmlDocument doc = new XmlDocument();
                XmlElement attachedfile = doc.CreateElement("file1");
                XmlElement node = doc.CreateElement("path");
                node.InnerText = select_folder_text_box.Text;
                attachedfile.AppendChild(node);

                node = doc.CreateElement("projectname");
                node.InnerText = projectname_text_box.Text;
                attachedfile.AppendChild(node);


                node = doc.CreateElement("taskname");
                node.InnerText = taskname_text_box.Text;
                attachedfile.AppendChild(node);


                node = doc.CreateElement("taskid");
                node.InnerText = taskid_textbox.Text;
                attachedfile.AppendChild(node);


                
                
                doc.Load("attachedfiles.xml");
                XmlElement root = doc.DocumentElement;
                root.AppendChild(attachedfile);

                doc.Save("attachedfiles.xml");



            }
            MessageBox.Show("successfully added");
        }
    }
}

