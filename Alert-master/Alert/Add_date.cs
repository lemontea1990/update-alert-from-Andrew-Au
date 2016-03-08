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

namespace Alert
{
    public partial class Add_date : Form
    {
        public Add_date()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (!File.Exists("alert_date.xml"))
            {



                XmlDocument date_doc = new XmlDocument();
                //XmlNode date_node = date_doc.CreateNode(XmlNodeType.XmlDeclaration, "d_a", "");
                //date_doc.AppendChild(date_node);

                XmlElement root_ele = date_doc.CreateElement("", "date_alert", "");
                date_doc.AppendChild(root_ele);

                XmlElement insert_date = date_doc.CreateElement("", "Insert_date", "");
                insert_date.InnerText = System.DateTime.Now.ToString();
                root_ele.AppendChild(insert_date);

                XmlElement date_insert = date_doc.CreateElement("alert_date");
                XmlElement time_insert = date_doc.CreateElement("alert_time");
                XmlElement title_insert = date_doc.CreateElement("alert_title");

                date_insert.InnerText = dtp_date.Value.ToShortDateString();
                time_insert.InnerText = dtp_time.Value.ToShortTimeString();
                title_insert.InnerText = txtbox_at.Text;


                insert_date.AppendChild(date_insert);
                insert_date.AppendChild(time_insert);
                insert_date.AppendChild(title_insert);

                //string xml_path = "D:\\alert\\alert_date.xml";
                //System.IO.Directory.CreateDirectory(xml_path);
                date_doc.Save("alert_date.xml");

                MessageBox.Show("Add success");
            }
            else
            {
                XmlDocument date_doc = new XmlDocument();
                //date_doc.LoadXml("alert_date.xml");
                date_doc.Load(@"alert_date.xml");
                XmlNode root_ele = date_doc.SelectSingleNode("date_alert");
                //if (date_node)
                //    MessageBox.Show("load success");
                date_doc.AppendChild(root_ele);

                //XmlElement root_ele = date_doc.CreateElement("", "date_alert", "");
                //XmlElement root_ele = new XmlElement();
                //date_node.AppendChild(root_ele);
               

                XmlElement insert_date = date_doc.CreateElement("", "Insert_date", "");
                insert_date.InnerText = System.DateTime.Now.ToString();
                root_ele.AppendChild(insert_date);

                XmlElement date_insert = date_doc.CreateElement("alert_date");
                XmlElement time_insert = date_doc.CreateElement("alert_time");
                XmlElement title_insert = date_doc.CreateElement("alert_title");

                date_insert.InnerText = dtp_date.Value.ToShortDateString();
                time_insert.InnerText = dtp_time.Value.ToShortTimeString();
                title_insert.InnerText = txtbox_at.Text;


                insert_date.AppendChild(date_insert);
                insert_date.AppendChild(time_insert);
                insert_date.AppendChild(title_insert);

                date_doc.Save("alert_date.xml");

                MessageBox.Show("Add success");

            }

        }

        private void Add_date_Load(object sender, EventArgs e)
        {
            MessageBox.Show("date: "+dtp_date.Value.Date.ToShortDateString());
            MessageBox.Show("time"+dtp_time.Value.ToShortTimeString());
            MessageBox.Show("today is "+System.DateTime.Now.ToString());
        }

        private void btn_run_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            this.Hide();
            this.WindowState = FormWindowState.Minimized;
            mf.Show();
        }
    }
}
