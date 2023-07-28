namespace Project
{
    partial class settings
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
            label3 = new Label();
            serverText = new TextBox();
            databaseText = new TextBox();
            label4 = new Label();
            userText = new TextBox();
            label5 = new Label();
            passwordText = new TextBox();
            label6 = new Label();
            isCB = new CheckBox();
            saveBtn = new Button();
            leftPanel.SuspendLayout();
            SuspendLayout();
            // 
            // leftPanel
            // 
            leftPanel.Controls.Add(saveBtn);
            leftPanel.Controls.Add(isCB);
            leftPanel.Controls.Add(passwordText);
            leftPanel.Controls.Add(label6);
            leftPanel.Controls.Add(userText);
            leftPanel.Controls.Add(label5);
            leftPanel.Controls.Add(databaseText);
            leftPanel.Controls.Add(label4);
            leftPanel.Controls.Add(serverText);
            leftPanel.Controls.Add(label3);
            leftPanel.Size = new Size(300, 722);
            leftPanel.Controls.SetChildIndex(label3, 0);
            leftPanel.Controls.SetChildIndex(serverText, 0);
            leftPanel.Controls.SetChildIndex(label4, 0);
            leftPanel.Controls.SetChildIndex(databaseText, 0);
            leftPanel.Controls.SetChildIndex(label5, 0);
            leftPanel.Controls.SetChildIndex(userText, 0);
            leftPanel.Controls.SetChildIndex(label6, 0);
            leftPanel.Controls.SetChildIndex(passwordText, 0);
            leftPanel.Controls.SetChildIndex(isCB, 0);
            leftPanel.Controls.SetChildIndex(saveBtn, 0);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 221);
            label3.Name = "label3";
            label3.Size = new Size(61, 25);
            label3.TabIndex = 2;
            label3.Text = "Server";
            // 
            // serverText
            // 
            serverText.Location = new Point(12, 249);
            serverText.MaxLength = 50;
            serverText.Name = "serverText";
            serverText.Size = new Size(266, 31);
            serverText.TabIndex = 3;
            serverText.TextChanged += serverText_TextChanged;
            // 
            // databaseText
            // 
            databaseText.Location = new Point(12, 322);
            databaseText.MaxLength = 50;
            databaseText.Name = "databaseText";
            databaseText.Size = new Size(266, 31);
            databaseText.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 294);
            label4.Name = "label4";
            label4.Size = new Size(86, 25);
            label4.TabIndex = 4;
            label4.Text = "Database";
            // 
            // userText
            // 
            userText.Location = new Point(12, 384);
            userText.MaxLength = 32;
            userText.Name = "userText";
            userText.Size = new Size(266, 31);
            userText.TabIndex = 7;
            userText.TextChanged += userText_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 356);
            label5.Name = "label5";
            label5.Size = new Size(70, 25);
            label5.TabIndex = 6;
            label5.Text = "User ID";
            // 
            // passwordText
            // 
            passwordText.Location = new Point(12, 445);
            passwordText.MaxLength = 30;
            passwordText.Name = "passwordText";
            passwordText.Size = new Size(266, 31);
            passwordText.TabIndex = 9;
            passwordText.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 417);
            label6.Name = "label6";
            label6.Size = new Size(87, 25);
            label6.TabIndex = 8;
            label6.Text = "Password";
            // 
            // isCB
            // 
            isCB.AutoSize = true;
            isCB.Location = new Point(12, 482);
            isCB.Name = "isCB";
            isCB.Size = new Size(187, 29);
            isCB.TabIndex = 10;
            isCB.Text = "Integrated Security";
            isCB.UseVisualStyleBackColor = true;
            isCB.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // saveBtn
            // 
            saveBtn.FlatAppearance.BorderSize = 2;
            saveBtn.FlatStyle = FlatStyle.Flat;
            saveBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            saveBtn.Location = new Point(12, 522);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(266, 58);
            saveBtn.TabIndex = 11;
            saveBtn.Text = "SAVE";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += button1_Click;
            // 
            // settings
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1866, 722);
            Name = "settings";
            Text = "settings";
            leftPanel.ResumeLayout(false);
            leftPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button saveBtn;
        private CheckBox isCB;
        private TextBox passwordText;
        private Label label6;
        private TextBox userText;
        private Label label5;
        private TextBox databaseText;
        private Label label4;
        private TextBox serverText;
        private Label label3;
    }
}