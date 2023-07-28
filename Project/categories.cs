using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project
{
    public partial class categories : sample2
    {
        int edit = 0; // 0 is an indication to save operation and 1 is to update operation
        int catID;
        short stat;
        retrieval r = new retrieval();
        public categories()
        {
            InitializeComponent();
        }

        private void barcodeErrorLable_Click(object sender, EventArgs e)
        {

        }

        private void categories_Load(object sender, EventArgs e)
        {
            mainClass.disable(leftPanel);
        }
        public override void addBtn_Click(object sender, EventArgs e)
        {
            mainClass.enable_reset(leftPanel);
            edit = 0;
        }
        // edit buttion is button2_click
        public override void button2_Click(object sender, EventArgs e)
        {
            edit = 1;
            mainClass.enable(leftPanel);
        }
        public override void saveBtn_Click(object sender, EventArgs e)
        {
            if (catTxt.Text == "") { catErrorLabel.Visible = true; } else { catErrorLabel.Visible = false; }

            if (activeDD.SelectedIndex == -1) { activeErrorLable.Visible = true; } else { activeErrorLable.Visible = false; }

            if (activeErrorLable.Visible || catErrorLabel.Visible)
            {
                mainClass.ShowMSG("Fields with * are mandatory", "stop", "Error");
            }
            else
            {

                if (activeDD.SelectedIndex == 0)
                {
                    stat = 1;
                }
                else if (activeDD.SelectedIndex == 1)
                {
                    stat = 0;
                }
                if (edit == 0)
                {

                    insertion i = new insertion();

                    i.insertCat(catTxt.Text, stat);
                    r.showCategories(dataGridView1, catIDGV, NameGV, statusGV);
                    mainClass.disable_reset(leftPanel);
                }
                else if (edit == 1)
                {
                    DialogResult dr = MessageBox.Show("Are you sure, you want to update the record?", "Question....", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        updation u = new updation();

                        u.updateCat(catID, catTxt.Text, stat);
                        r.showCategories(dataGridView1, catIDGV, NameGV, statusGV);
                        mainClass.disable_reset(leftPanel);
                    }
                }

            }
        }

        public override void viewBtn_Click(object sender, EventArgs e)
        {
            r.showCategories(dataGridView1, catIDGV, NameGV, statusGV);
        }

        public override void searchTxt_TextChanged(object sender, EventArgs e)
        {
            if (searchTxt.Text != "")
            {
                r.showCategories(dataGridView1, catIDGV, NameGV, statusGV, searchTxt.Text);

            }
            else
            {
                r.showCategories(dataGridView1, catIDGV, NameGV, statusGV);

            }
        }
        public override void deleteBtn_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {
                DialogResult dr = MessageBox.Show("Are you sure, you want to delete the record?", "Question....", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    deletion d = new deletion();
                    d.delete(catID, "str_deleteCategory", "@id");
                    r.showCategories(dataGridView1, catIDGV, NameGV, statusGV);


                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                catID = Convert.ToInt32(row.Cells["catIDGV"].Value.ToString());
                catTxt.Text = row.Cells["NameGV"].Value.ToString();
                activeDD.SelectedItem = row.Cells["statusGV"].Value.ToString();
                mainClass.disable(leftPanel);
            }
        }
    }
}
