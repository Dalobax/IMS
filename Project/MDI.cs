using System.IO;
namespace Project
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MDI_Load(object sender, EventArgs e)
        {
            string Path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (File.Exists(Path + "\\connect"))
            {
                login log = new login();
                mainClass.showWindow(log, this);

            }
            else
            {
                settings settings = new settings();
                mainClass.showWindow(settings, this);
            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            settings settings = new settings();
            mainClass.showWindow(settings, this);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            System.Windows.Forms.Application.Exit();
        }
    }
}