namespace Project
{
    partial class sample2
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
            panel3 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            editBtn = new Button();
            deleteBtn = new Button();
            viewBtn = new Button();
            saveBtn = new Button();
            addBtn = new Button();
            groupBox1 = new GroupBox();
            searchTxt = new TextBox();
            backBtn = new Button();
            panel4 = new Panel();
            leftPanel.SuspendLayout();
            panel1.SuspendLayout();
            rightPanel.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // leftPanel
            // 
            leftPanel.Controls.Add(panel4);
            leftPanel.Controls.SetChildIndex(panel4, 0);
            leftPanel.Controls.SetChildIndex(panel1, 0);
            // 
            // panel1
            // 
            panel1.Controls.Add(backBtn);
            panel1.Controls.SetChildIndex(backBtn, 0);
            panel1.Controls.SetChildIndex(label1, 0);
            // 
            // rightPanel
            // 
            rightPanel.Controls.Add(panel3);
            rightPanel.Size = new Size(1294, 723);
            rightPanel.Paint += rightPanel_Paint;
            rightPanel.Controls.SetChildIndex(panel2, 0);
            rightPanel.Controls.SetChildIndex(panel3, 0);
            // 
            // panel2
            // 
            panel2.Size = new Size(1294, 80);
            // 
            // label1
            // 
            label1.Location = new Point(82, 0);
            label1.Size = new Size(224, 80);
            // 
            // label2
            // 
            label2.Size = new Size(1171, 80);
            // 
            // panel3
            // 
            panel3.Controls.Add(tableLayoutPanel1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 80);
            panel3.Name = "panel3";
            panel3.Size = new Size(1294, 74);
            panel3.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 7;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.Controls.Add(editBtn, 0, 0);
            tableLayoutPanel1.Controls.Add(deleteBtn, 3, 0);
            tableLayoutPanel1.Controls.Add(viewBtn, 2, 0);
            tableLayoutPanel1.Controls.Add(saveBtn, 1, 0);
            tableLayoutPanel1.Controls.Add(addBtn, 0, 0);
            tableLayoutPanel1.Controls.Add(groupBox1, 5, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1294, 74);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // editBtn
            // 
            editBtn.Cursor = Cursors.Hand;
            editBtn.Dock = DockStyle.Fill;
            editBtn.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            editBtn.FlatAppearance.BorderSize = 2;
            editBtn.FlatStyle = FlatStyle.Flat;
            editBtn.Location = new Point(187, 3);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(178, 68);
            editBtn.TabIndex = 4;
            editBtn.Text = "EDIT";
            editBtn.UseVisualStyleBackColor = true;
            editBtn.Click += button2_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Cursor = Cursors.Hand;
            deleteBtn.Dock = DockStyle.Fill;
            deleteBtn.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            deleteBtn.FlatAppearance.BorderSize = 2;
            deleteBtn.FlatStyle = FlatStyle.Flat;
            deleteBtn.Location = new Point(739, 3);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(178, 68);
            deleteBtn.TabIndex = 3;
            deleteBtn.Text = "DELETE";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // viewBtn
            // 
            viewBtn.Cursor = Cursors.Hand;
            viewBtn.Dock = DockStyle.Fill;
            viewBtn.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            viewBtn.FlatAppearance.BorderSize = 2;
            viewBtn.FlatStyle = FlatStyle.Flat;
            viewBtn.Location = new Point(555, 3);
            viewBtn.Name = "viewBtn";
            viewBtn.Size = new Size(178, 68);
            viewBtn.TabIndex = 2;
            viewBtn.Text = "VIEW";
            viewBtn.UseVisualStyleBackColor = true;
            viewBtn.Click += viewBtn_Click;
            // 
            // saveBtn
            // 
            saveBtn.Cursor = Cursors.Hand;
            saveBtn.Dock = DockStyle.Fill;
            saveBtn.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            saveBtn.FlatAppearance.BorderSize = 2;
            saveBtn.FlatStyle = FlatStyle.Flat;
            saveBtn.Location = new Point(371, 3);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(178, 68);
            saveBtn.TabIndex = 1;
            saveBtn.Text = "SAVE";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // addBtn
            // 
            addBtn.Cursor = Cursors.Hand;
            addBtn.Dock = DockStyle.Fill;
            addBtn.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            addBtn.FlatAppearance.BorderSize = 2;
            addBtn.FlatStyle = FlatStyle.Flat;
            addBtn.Location = new Point(3, 3);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(178, 68);
            addBtn.TabIndex = 0;
            addBtn.Text = "ADD";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // groupBox1
            // 
            tableLayoutPanel1.SetColumnSpan(groupBox1, 2);
            groupBox1.Controls.Add(searchTxt);
            groupBox1.Location = new Point(923, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(290, 68);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "SEARCH";
            groupBox1.Enter += groupBox1_Enter_1;
            // 
            // searchTxt
            // 
            searchTxt.Dock = DockStyle.Fill;
            searchTxt.Location = new Point(3, 27);
            searchTxt.MaxLength = 100;
            searchTxt.Name = "searchTxt";
            searchTxt.Size = new Size(284, 31);
            searchTxt.TabIndex = 0;
            searchTxt.TextChanged += searchTxt_TextChanged;
            // 
            // backBtn
            // 
            backBtn.BackgroundImage = Properties.Resources.BBFinal;
            backBtn.Cursor = Cursors.Hand;
            backBtn.Dock = DockStyle.Fill;
            backBtn.FlatAppearance.BorderSize = 0;
            backBtn.FlatStyle = FlatStyle.Flat;
            backBtn.ForeColor = Color.White;
            backBtn.Location = new Point(0, 0);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(306, 80);
            backBtn.TabIndex = 3;
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Click += backBtn_Click_1;
            // 
            // panel4
            // 
            panel4.Location = new Point(6, 86);
            panel4.Name = "panel4";
            panel4.Size = new Size(300, 68);
            panel4.TabIndex = 2;
            // 
            // sample2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1600, 723);
            Name = "sample2";
            Load += sample2_Load;
            leftPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            rightPanel.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private TableLayoutPanel tableLayoutPanel1;
        private Button deleteBtn;
        private Button viewBtn;
        private Button saveBtn;
        private Button addBtn;
        private Button backBtn;
        private Button editBtn;
        private GroupBox groupBox1;
        protected TextBox searchTxt;
        private Panel panel4;
    }
}