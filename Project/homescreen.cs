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
    public partial class homescreen : Sample
    {
        public homescreen()
        {
            InitializeComponent();
        }

        private void homescreen_Load(object sender, EventArgs e)
        {

        }

        private void usersBtn_Click(object sender, EventArgs e)
        {
            users u = new users();
            mainClass.showWindow(u, this, MDI.ActiveForm);
        }
        //product button below
        private void button1_Click(object sender, EventArgs e)
        {
            categories u = new categories();
            mainClass.showWindow(u, this, MDI.ActiveForm);
        }

        private void productbtn_Click(object sender, EventArgs e)
        {
            products u = new products();
            mainClass.showWindow(u, this, MDI.ActiveForm);
        }
    }
}
