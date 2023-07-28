using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class users : sample2
    {
        int edit = 0; // 0 is an indication to save operation and 1 is to update operation
        int userID;
        short stat;
        public users()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        }
        retrieval r = new retrieval();
        private void users_Load(object sender, EventArgs e)
        {
            mainClass.disable(leftPanel);


        }
        public override void saveBtn_Click(object sender, EventArgs e)
        {
            if (nameTxt.Text == "") { nameErrorLabel.Visible = true; } else { nameErrorLabel.Visible = false; }
            if (usernameTxt.Text == "") { usernameErrorLabel.Visible = true; } else { usernameErrorLabel.Visible = false; }
            if (passTxt.Text == "") { passErrorLabel.Visible = true; } else { passErrorLabel.Visible = false; }
            if (emailTxt.Text == "") { emailErrorLabel.Visible = true; } else { emailErrorLabel.Visible = false; }
            if (phoneTxt.Text == "") { phoneErrorLabel.Visible = true; } else { phoneErrorLabel.Visible = false; }
            if (statusDD.SelectedIndex == -1) { statusErrorLabel.Visible = true; } else { statusErrorLabel.Visible = false; }

            if (nameErrorLabel.Visible || usernameErrorLabel.Visible || passErrorLabel.Visible || emailErrorLabel.Visible || phoneErrorLabel.Visible || statusErrorLabel.Visible)
            {
                mainClass.ShowMSG("Fields with * are mandatory", "stop", "Error");
            }
            else
            {

                if (statusDD.SelectedIndex == 0)
                {
                    stat = 1;
                }
                else if (statusDD.SelectedIndex == 1)
                {
                    stat = 0;
                }
                if (edit == 0)
                {

                    insertion i = new insertion();

                    i.insertUser(nameTxt.Text, usernameTxt.Text, passTxt.Text, emailTxt.Text, phoneTxt.Text, stat);
                    r.showUsers(dataGridView1, userIDGV, NameGV, UserNameGV, PassGV, EmailGV, PhoneGV, statusGV);
                    mainClass.disable_reset(leftPanel);
                }
                else if (edit == 1)
                {
                    DialogResult dr = MessageBox.Show("Are you sure, you want to update the record?", "Question....", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        updation u = new updation();

                        u.updateUser(userID, nameTxt.Text, usernameTxt.Text, passTxt.Text, emailTxt.Text, phoneTxt.Text, stat);
                        r.showUsers(dataGridView1, userIDGV, NameGV, UserNameGV, PassGV, EmailGV, PhoneGV, statusGV);
                        mainClass.disable_reset(leftPanel);
                    }
                }

            }
        }

        public override void viewBtn_Click(object sender, EventArgs e)
        {
            r.showUsers(dataGridView1, userIDGV, NameGV, UserNameGV, PassGV, EmailGV, PhoneGV, statusGV);

        }


        public override void addBtn_Click(object sender, EventArgs e)
        {
            mainClass.enable_reset(leftPanel);
            edit = 0;
        }
        //edit button
        public override void button2_Click(object sender, EventArgs e)
        {
            edit = 1;
            mainClass.enable(leftPanel);
        }
        public override void deleteBtn_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {
                DialogResult dr = MessageBox.Show("Are you sure, you want to delete the record?", "Question....", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    deletion d = new deletion();
                    d.delete(userID, "st_deleteUsers", "@id");
                    r.showUsers(dataGridView1, userIDGV, NameGV, UserNameGV, PassGV, EmailGV, PhoneGV, statusGV);


                }
            }
        }
        public override void searchTxt_TextChanged(object sender, EventArgs e)
        {
            if (searchTxt.Text != "")
            {
                r.showUsers(dataGridView1, userIDGV, NameGV, UserNameGV, PassGV, EmailGV, PhoneGV, statusGV, searchTxt.Text);

            }
            else
            {
                r.showUsers(dataGridView1, userIDGV, NameGV, UserNameGV, PassGV, EmailGV, PhoneGV, statusGV);

            }
        }


        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                userID = Convert.ToInt32(row.Cells["userIDGV"].Value.ToString());
                nameTxt.Text = row.Cells["NameGV"].Value.ToString();
                usernameTxt.Text = row.Cells["UserNameGV"].Value.ToString();
                passTxt.Text = row.Cells["PassGV"].Value.ToString();
                phoneTxt.Text = row.Cells["PhoneGV"].Value.ToString();
                emailTxt.Text = row.Cells["EmailGV"].Value.ToString();
                statusDD.SelectedItem = row.Cells["statusGV"].Value.ToString();
                mainClass.disable(leftPanel);
            }
        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
