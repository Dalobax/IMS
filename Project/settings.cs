using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class settings : Sample
    {
        public settings()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (isCB.Checked)
            {
                userText.Enabled = false;
                passwordText.Enabled = false;
                userText.Text = "";
                passwordText.Text = "";
            }
            else
            {
                userText.Enabled = true;
                passwordText.Enabled = true;
            }
        }

        private void userText_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s;
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); 
            if (isCB.Checked)
            {
                if (serverText.Text != "" && databaseText.Text != "") 
                {
                    s = "Data Source" + serverText.Text + ";Initial Catalog" + databaseText.Text + ";Integrated Security = true; ";
                    File.WriteAllText(path+"\\connect", s);
                    DialogResult dr = MessageBox.Show("Settings saved succesfully...", "Information.....", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        login log = new login();
                        mainClass.showWindow(log, this, MDI.ActiveForm);
                    }
                } 
                else
                {
                    MessageBox.Show("please give complete data to continue");
                }
            }
            else
            {
                if (serverText.Text != "" && databaseText.Text != "" && userText.Text != "" && passwordText.Text != "") 
                {
                    s = "Data Source=" + serverText.Text + ";Initial Catalog=" + databaseText.Text + ";User Id="+userText.Text+";Password="+passwordText.Text+";";
                    File.WriteAllText(path + "\\connect", s);
                    DialogResult dr = MessageBox.Show("Settings saved succesfully...", "Information.....", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        login log = new login();
                        mainClass.showWindow(log, this, MDI.ActiveForm);
                    }
                }
                else
                {
                    MessageBox.Show("please give complete data to continue");
                }
            }
            
        }

            private void serverText_TextChanged(object sender, EventArgs e)
            {

            }
        
    }
}
