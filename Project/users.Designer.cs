namespace Project
{
    partial class users
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label3 = new Label();
            nameTxt = new TextBox();
            usernameTxt = new TextBox();
            label4 = new Label();
            passTxt = new TextBox();
            label5 = new Label();
            phoneTxt = new TextBox();
            label6 = new Label();
            emailTxt = new TextBox();
            label7 = new Label();
            nameErrorLabel = new Label();
            usernameErrorLabel = new Label();
            passErrorLabel = new Label();
            phoneErrorLabel = new Label();
            emailErrorLabel = new Label();
            dataGridView1 = new DataGridView();
            userIDGV = new DataGridViewTextBoxColumn();
            NameGV = new DataGridViewTextBoxColumn();
            UserNameGV = new DataGridViewTextBoxColumn();
            PassGV = new DataGridViewTextBoxColumn();
            EmailGV = new DataGridViewTextBoxColumn();
            PhoneGV = new DataGridViewTextBoxColumn();
            statusGV = new DataGridViewTextBoxColumn();
            label8 = new Label();
            statusDD = new ComboBox();
            statusErrorLabel = new Label();
            leftPanel.SuspendLayout();
            panel1.SuspendLayout();
            rightPanel.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // searchTxt
            // 
            searchTxt.Size = new Size(280, 31);
            // 
            // leftPanel
            // 
            leftPanel.Controls.Add(statusDD);
            leftPanel.Controls.Add(label8);
            leftPanel.Controls.Add(emailTxt);
            leftPanel.Controls.Add(label7);
            leftPanel.Controls.Add(phoneTxt);
            leftPanel.Controls.Add(label6);
            leftPanel.Controls.Add(passTxt);
            leftPanel.Controls.Add(label5);
            leftPanel.Controls.Add(usernameTxt);
            leftPanel.Controls.Add(label4);
            leftPanel.Controls.Add(nameTxt);
            leftPanel.Controls.Add(label3);
            leftPanel.Controls.Add(nameErrorLabel);
            leftPanel.Controls.Add(usernameErrorLabel);
            leftPanel.Controls.Add(passErrorLabel);
            leftPanel.Controls.Add(phoneErrorLabel);
            leftPanel.Controls.Add(emailErrorLabel);
            leftPanel.Controls.Add(statusErrorLabel);
            leftPanel.Size = new Size(306, 618);
            leftPanel.Controls.SetChildIndex(statusErrorLabel, 0);
            leftPanel.Controls.SetChildIndex(emailErrorLabel, 0);
            leftPanel.Controls.SetChildIndex(phoneErrorLabel, 0);
            leftPanel.Controls.SetChildIndex(passErrorLabel, 0);
            leftPanel.Controls.SetChildIndex(usernameErrorLabel, 0);
            leftPanel.Controls.SetChildIndex(nameErrorLabel, 0);
            leftPanel.Controls.SetChildIndex(panel1, 0);
            leftPanel.Controls.SetChildIndex(label3, 0);
            leftPanel.Controls.SetChildIndex(nameTxt, 0);
            leftPanel.Controls.SetChildIndex(label4, 0);
            leftPanel.Controls.SetChildIndex(usernameTxt, 0);
            leftPanel.Controls.SetChildIndex(label5, 0);
            leftPanel.Controls.SetChildIndex(passTxt, 0);
            leftPanel.Controls.SetChildIndex(label6, 0);
            leftPanel.Controls.SetChildIndex(phoneTxt, 0);
            leftPanel.Controls.SetChildIndex(label7, 0);
            leftPanel.Controls.SetChildIndex(emailTxt, 0);
            leftPanel.Controls.SetChildIndex(label8, 0);
            leftPanel.Controls.SetChildIndex(statusDD, 0);
            // 
            // rightPanel
            // 
            rightPanel.Controls.Add(dataGridView1);
            rightPanel.Size = new Size(1017, 618);
            rightPanel.Controls.SetChildIndex(panel2, 0);
            rightPanel.Controls.SetChildIndex(dataGridView1, 0);
            // 
            // panel2
            // 
            panel2.Location = new Point(0, 74);
            panel2.Size = new Size(1017, 80);
            // 
            // label1
            // 
            label1.Location = new Point(77, 0);
            label1.Size = new Size(229, 80);
            // 
            // label2
            // 
            label2.Size = new Size(1159, 80);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 173);
            label3.Name = "label3";
            label3.Size = new Size(59, 25);
            label3.TabIndex = 3;
            label3.Text = "Name";
            label3.Click += label3_Click;
            // 
            // nameTxt
            // 
            nameTxt.Location = new Point(12, 201);
            nameTxt.MaxLength = 30;
            nameTxt.Name = "nameTxt";
            nameTxt.Size = new Size(273, 31);
            nameTxt.TabIndex = 4;
            // 
            // usernameTxt
            // 
            usernameTxt.Location = new Point(12, 263);
            usernameTxt.MaxLength = 20;
            usernameTxt.Name = "usernameTxt";
            usernameTxt.Size = new Size(273, 31);
            usernameTxt.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 235);
            label4.Name = "label4";
            label4.Size = new Size(91, 25);
            label4.TabIndex = 5;
            label4.Text = "Username";
            // 
            // passTxt
            // 
            passTxt.Location = new Point(15, 324);
            passTxt.MaxLength = 20;
            passTxt.Name = "passTxt";
            passTxt.Size = new Size(270, 31);
            passTxt.TabIndex = 8;
            passTxt.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 296);
            label5.Name = "label5";
            label5.Size = new Size(87, 25);
            label5.TabIndex = 7;
            label5.Text = "Password";
            // 
            // phoneTxt
            // 
            phoneTxt.Location = new Point(15, 385);
            phoneTxt.MaxLength = 10;
            phoneTxt.Name = "phoneTxt";
            phoneTxt.Size = new Size(270, 31);
            phoneTxt.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 357);
            label6.Name = "label6";
            label6.Size = new Size(213, 25);
            label6.TabIndex = 9;
            label6.Text = "Phone (+91 xxxx-nnnnnn)";
            // 
            // emailTxt
            // 
            emailTxt.Location = new Point(15, 447);
            emailTxt.MaxLength = 50;
            emailTxt.Name = "emailTxt";
            emailTxt.Size = new Size(270, 31);
            emailTxt.TabIndex = 12;
            emailTxt.TextChanged += textBox5_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 419);
            label7.Name = "label7";
            label7.Size = new Size(54, 25);
            label7.TabIndex = 11;
            label7.Text = "Email";
            label7.Click += label7_Click;
            // 
            // nameErrorLabel
            // 
            nameErrorLabel.AutoSize = true;
            nameErrorLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            nameErrorLabel.Location = new Point(68, 160);
            nameErrorLabel.Name = "nameErrorLabel";
            nameErrorLabel.Size = new Size(31, 41);
            nameErrorLabel.TabIndex = 13;
            nameErrorLabel.Text = "*";
            nameErrorLabel.Visible = false;
            nameErrorLabel.Click += label8_Click;
            // 
            // usernameErrorLabel
            // 
            usernameErrorLabel.AutoSize = true;
            usernameErrorLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            usernameErrorLabel.Location = new Point(95, 222);
            usernameErrorLabel.Name = "usernameErrorLabel";
            usernameErrorLabel.Size = new Size(31, 41);
            usernameErrorLabel.TabIndex = 14;
            usernameErrorLabel.Text = "*";
            usernameErrorLabel.Visible = false;
            // 
            // passErrorLabel
            // 
            passErrorLabel.AutoSize = true;
            passErrorLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            passErrorLabel.Location = new Point(95, 283);
            passErrorLabel.Name = "passErrorLabel";
            passErrorLabel.Size = new Size(31, 41);
            passErrorLabel.TabIndex = 15;
            passErrorLabel.Text = "*";
            passErrorLabel.Visible = false;
            // 
            // phoneErrorLabel
            // 
            phoneErrorLabel.AutoSize = true;
            phoneErrorLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            phoneErrorLabel.Location = new Point(220, 344);
            phoneErrorLabel.Name = "phoneErrorLabel";
            phoneErrorLabel.Size = new Size(31, 41);
            phoneErrorLabel.TabIndex = 14;
            phoneErrorLabel.Text = "*";
            phoneErrorLabel.Visible = false;
            // 
            // emailErrorLabel
            // 
            emailErrorLabel.AutoSize = true;
            emailErrorLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            emailErrorLabel.Location = new Point(68, 406);
            emailErrorLabel.Name = "emailErrorLabel";
            emailErrorLabel.Size = new Size(31, 41);
            emailErrorLabel.TabIndex = 16;
            emailErrorLabel.Text = "*";
            emailErrorLabel.Visible = false;
            emailErrorLabel.Click += label12_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { userIDGV, NameGV, UserNameGV, PassGV, EmailGV, PhoneGV, statusGV });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.DarkOrange;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 154);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1017, 464);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // userIDGV
            // 
            userIDGV.HeaderText = "UserID";
            userIDGV.MinimumWidth = 8;
            userIDGV.Name = "userIDGV";
            userIDGV.ReadOnly = true;
            userIDGV.Visible = false;
            // 
            // NameGV
            // 
            NameGV.HeaderText = "Name";
            NameGV.MinimumWidth = 8;
            NameGV.Name = "NameGV";
            NameGV.ReadOnly = true;
            // 
            // UserNameGV
            // 
            UserNameGV.HeaderText = "Username";
            UserNameGV.MinimumWidth = 8;
            UserNameGV.Name = "UserNameGV";
            UserNameGV.ReadOnly = true;
            // 
            // PassGV
            // 
            PassGV.HeaderText = "Password";
            PassGV.MinimumWidth = 8;
            PassGV.Name = "PassGV";
            PassGV.ReadOnly = true;
            PassGV.Visible = false;
            // 
            // EmailGV
            // 
            EmailGV.HeaderText = "Email";
            EmailGV.MinimumWidth = 8;
            EmailGV.Name = "EmailGV";
            EmailGV.ReadOnly = true;
            // 
            // PhoneGV
            // 
            PhoneGV.HeaderText = "Phone#";
            PhoneGV.MinimumWidth = 8;
            PhoneGV.Name = "PhoneGV";
            PhoneGV.ReadOnly = true;
            // 
            // statusGV
            // 
            statusGV.HeaderText = "Status";
            statusGV.MinimumWidth = 8;
            statusGV.Name = "statusGV";
            statusGV.ReadOnly = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 481);
            label8.Name = "label8";
            label8.Size = new Size(60, 25);
            label8.TabIndex = 17;
            label8.Text = "Status";
            label8.Click += label8_Click_1;
            // 
            // statusDD
            // 
            statusDD.DropDownStyle = ComboBoxStyle.DropDownList;
            statusDD.FormattingEnabled = true;
            statusDD.Items.AddRange(new object[] { "Active", "In-active" });
            statusDD.Location = new Point(15, 509);
            statusDD.Name = "statusDD";
            statusDD.Size = new Size(270, 33);
            statusDD.TabIndex = 18;
            statusDD.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // statusErrorLabel
            // 
            statusErrorLabel.AutoSize = true;
            statusErrorLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            statusErrorLabel.Location = new Point(68, 468);
            statusErrorLabel.Name = "statusErrorLabel";
            statusErrorLabel.Size = new Size(31, 41);
            statusErrorLabel.TabIndex = 19;
            statusErrorLabel.Text = "*";
            statusErrorLabel.Visible = false;
            // 
            // users
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1323, 618);
            Name = "users";
            Text = "users";
            Load += users_Load;
            leftPanel.ResumeLayout(false);
            leftPanel.PerformLayout();
            panel1.ResumeLayout(false);
            rightPanel.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox nameTxt;
        private Label label3;
        private TextBox emailTxt;
        private Label label7;
        private TextBox phoneTxt;
        private Label label6;
        private TextBox passTxt;
        private Label label5;
        private TextBox usernameTxt;
        private Label label4;
        private Label nameErrorLabel;
        private Label usernameErrorLabel;
        private Label passErrorLabel;
        private Label phoneErrorLabel;
        private Label emailErrorLabel;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn userIDGV;
        private DataGridViewTextBoxColumn NameGV;
        private DataGridViewTextBoxColumn UserNameGV;
        private DataGridViewTextBoxColumn PassGV;
        private DataGridViewTextBoxColumn EmailGV;
        private DataGridViewTextBoxColumn PhoneGV;
        private DataGridViewTextBoxColumn statusGV;
        private Label label8;
        private ComboBox statusDD;
        private Label statusErrorLabel;
    }
}