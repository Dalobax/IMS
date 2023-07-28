namespace Project
{
    partial class homescreen
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
            tableLayoutPanel1 = new TableLayoutPanel();
            button4 = new Button();
            button3 = new Button();
            productbtn = new Button();
            button1 = new Button();
            usersBtn = new Button();
            leftPanel.SuspendLayout();
            panel1.SuspendLayout();
            rightPanel.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // leftPanel
            // 
            leftPanel.Size = new Size(300, 717);
            // 
            // panel1
            // 
            panel1.Size = new Size(300, 80);
            // 
            // rightPanel
            // 
            rightPanel.Controls.Add(tableLayoutPanel1);
            rightPanel.Location = new Point(300, 0);
            rightPanel.Size = new Size(1019, 717);
            rightPanel.Controls.SetChildIndex(panel2, 0);
            rightPanel.Controls.SetChildIndex(tableLayoutPanel1, 0);
            // 
            // panel2
            // 
            panel2.Size = new Size(1019, 80);
            // 
            // label1
            // 
            label1.Location = new Point(101, 0);
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(button4, 4, 0);
            tableLayoutPanel1.Controls.Add(button3, 3, 0);
            tableLayoutPanel1.Controls.Add(productbtn, 2, 0);
            tableLayoutPanel1.Controls.Add(button1, 1, 0);
            tableLayoutPanel1.Controls.Add(usersBtn, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 80);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(1019, 637);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // button4
            // 
            button4.Cursor = Cursors.Hand;
            button4.Dock = DockStyle.Fill;
            button4.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            button4.FlatAppearance.BorderSize = 2;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(815, 3);
            button4.Name = "button4";
            button4.Size = new Size(201, 121);
            button4.TabIndex = 4;
            button4.Text = "Status";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.Dock = DockStyle.Fill;
            button3.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            button3.FlatAppearance.BorderSize = 2;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(612, 3);
            button3.Name = "button3";
            button3.Size = new Size(197, 121);
            button3.TabIndex = 3;
            button3.Text = "Last modified";
            button3.UseVisualStyleBackColor = true;
            // 
            // productbtn
            // 
            productbtn.Cursor = Cursors.Hand;
            productbtn.Dock = DockStyle.Fill;
            productbtn.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            productbtn.FlatAppearance.BorderSize = 2;
            productbtn.FlatStyle = FlatStyle.Flat;
            productbtn.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            productbtn.Location = new Point(409, 3);
            productbtn.Name = "productbtn";
            productbtn.Size = new Size(197, 121);
            productbtn.TabIndex = 2;
            productbtn.Text = "Product";
            productbtn.UseVisualStyleBackColor = true;
            productbtn.Click += productbtn_Click;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Dock = DockStyle.Fill;
            button1.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(206, 3);
            button1.Name = "button1";
            button1.Size = new Size(197, 121);
            button1.TabIndex = 1;
            button1.Text = "Category";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // usersBtn
            // 
            usersBtn.Cursor = Cursors.Hand;
            usersBtn.Dock = DockStyle.Fill;
            usersBtn.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            usersBtn.FlatAppearance.BorderSize = 2;
            usersBtn.FlatStyle = FlatStyle.Flat;
            usersBtn.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            usersBtn.Location = new Point(3, 3);
            usersBtn.Name = "usersBtn";
            usersBtn.Size = new Size(197, 121);
            usersBtn.TabIndex = 0;
            usersBtn.Text = "Users";
            usersBtn.UseVisualStyleBackColor = true;
            usersBtn.Click += usersBtn_Click;
            // 
            // homescreen
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1319, 717);
            Name = "homescreen";
            Text = "Home Screen";
            Load += homescreen_Load;
            leftPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            rightPanel.ResumeLayout(false);
            panel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button button4;
        private Button button3;
        private Button productbtn;
        private Button button1;
        private Button usersBtn;
    }
}