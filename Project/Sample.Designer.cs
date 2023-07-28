namespace Project
{
    partial class Sample
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            leftPanel = new Panel();
            panel1 = new Panel();
            label1 = new Label();
            rightPanel = new Panel();
            panel2 = new Panel();
            label2 = new Label();
            leftPanel.SuspendLayout();
            panel1.SuspendLayout();
            rightPanel.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // leftPanel
            // 
            leftPanel.BackColor = Color.FromArgb(255, 128, 0);
            leftPanel.Controls.Add(panel1);
            leftPanel.Dock = DockStyle.Left;
            leftPanel.ForeColor = Color.White;
            leftPanel.Location = new Point(0, 0);
            leftPanel.Name = "leftPanel";
            leftPanel.Size = new Size(306, 723);
            leftPanel.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(306, 80);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Right;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(107, 0);
            label1.Name = "label1";
            label1.Size = new Size(199, 80);
            label1.TabIndex = 2;
            label1.Text = "Welcome";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // rightPanel
            // 
            rightPanel.Controls.Add(panel2);
            rightPanel.Dock = DockStyle.Fill;
            rightPanel.Location = new Point(306, 0);
            rightPanel.Name = "rightPanel";
            rightPanel.Size = new Size(1029, 723);
            rightPanel.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1029, 80);
            panel2.TabIndex = 2;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Left;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(929, 80);
            label2.TabIndex = 0;
            label2.Text = "User";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Sample
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1335, 723);
            ControlBox = false;
            Controls.Add(rightPanel);
            Controls.Add(leftPanel);
            Name = "Sample";
            Load += Sample_Load;
            leftPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            rightPanel.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        public Panel leftPanel;
        public Panel panel1;
        public Panel rightPanel;
        public Panel panel2;
        public Label label1;
        public Label label2;
    }
}