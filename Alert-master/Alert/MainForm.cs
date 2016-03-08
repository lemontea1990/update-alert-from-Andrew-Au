/**
 * Display a full screen message
 */
using System.IO;
using System.Xml;
using System.Collections.Generic;
namespace Alert
{
    using System;
    using System.Windows.Forms;
    using System.Threading;

    public partial class MainForm : Form
    {
        private string text;

        public MainForm()
            : this("Done")
        {
        }

        public MainForm(string text)
        {
            this.InitializeComponent();
            this.text = text;
        }

        private void OnMainFormLoaded(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
           // MessageBox.Show("time is "+DateTime.Now.Date.DayOfYear.ToString()+4%2);
            if (judge_date() ==1)
            {

                this.load_date();    
                this.GoFullScreen();
                   
            }
            
        }

        private void GoFullScreen()
        {
            this.textLabel.Text = this.text;
            this.textLabel.Left = (this.ClientSize.Width - this.textLabel.Width) / 2;
            this.textLabel.Top = (this.ClientSize.Height - this.textLabel.Height) / 2;
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.Focus();

            for (int i = 0; i < 10; i++)
            {
            //    this.BackColor = System.Drawing.Color.White;
            //    //Thread.Sleep(1);
               
            //    this.BackColor = System.Drawing.Color.Red;
            //}
                if (i % 2 == 0)
                {
                    //this.ForeColor = System.Drawing.Color.Red;
                    this.BackColor = System.Drawing.Color.Red;
                    MessageBox.Show("Waring");
                    this.FormBorderStyle = FormBorderStyle.None;

                   // this.textLabel.Text += 2;
                }
                if (i % 2 == 1)
                { 
                
                    this.BackColor = System.Drawing.Color.White;
                    MessageBox.Show("Waring again!");
                }
                //this.BackColor = System.Drawing.Color.Red;
                //Thread.Sleep(1000);
                //this.BackColor = System.Drawing.Color.White;
            }
        }


        private void OnMainFormClicked(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private List<string>  load_date()
        {
            XmlDocument date_x = new XmlDocument();
            date_x.Load("alert_date.xml");

            XmlElement root_ele = date_x.DocumentElement;
            XmlNodeList list_node = root_ele.GetElementsByTagName("Insert_date");

            if (list_node.Count < 1)
                MessageBox.Show("load error");
           // MessageBox.Show("count of record is"+list_node.Count);
           
            List<string> xml_list = new List<string>();

            foreach( XmlNode node in list_node)
            {
              
                //MessageBox.Show("insert start" + ((XmlElement)node).InnerText.ToString());
                xml_list.Add(((XmlElement)node).InnerText.ToString());
                //MessageBox.Show("insert complete ");
                
            }
            //MessageBox.Show("record length is"+xml_list.Count.ToString());
            //for (int a = 0; a < xml_list.Count ; a++)
            //{
            //    MessageBox.Show("insert time is" + xml_list[a]);
            //}
            return xml_list;
        }


        private int  judge_date()
        {
            List<string> judge = load_date();

            List<string> substring_date = new List<string>();
            for (int a = 0; a < judge.Count; a++)
            {
                substring_date.Add(judge[a].ToString().Substring(0,7));
            }


            foreach (string compare_date in substring_date)
            {
                if (System.DateTime.Now.ToShortDateString() == compare_date)
                {
                    
                    break;
                }
            }

            int judge_res;
            return judge_res = 1;

        }
    }
}
