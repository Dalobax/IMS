using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class products : sample2
    {

        public products()
        {
            InitializeComponent();
        }
        retrieval r = new retrieval();
        private void products_Load(object sender, EventArgs e)
        {

        }

        public override void addBtn_Click(object sender, EventArgs e)
        {
            r.getCategoriesList("st_getCategoriesData", categoryDD, "Category", "ID");
        }
        // edit buttion is button2_click
        public override void button2_Click(object sender, EventArgs e)
        {

        }
        public override void saveBtn_Click(object sender, EventArgs e)
        {

        }

        public override void viewBtn_Click(object sender, EventArgs e)
        {

        }

        public override void searchTxt_TextChanged(object sender, EventArgs e)
        {

        }
        public override void deleteBtn_Click(object sender, EventArgs e)
        {

        }

    }
}
