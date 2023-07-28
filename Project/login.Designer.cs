namespace Project
{
    partial class login
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
            usernameText = new TextBox();
            passwordText = new TextBox();
            label4 = new Label();
            LoginBtn = new Button();
            leftPanel.SuspendLayout();
            panel1.SuspendLayout();
            rightPanel.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // leftPanel
            // 
            leftPanel.Controls.Add(LoginBtn);
            leftPanel.Controls.Add(passwordText);
            leftPanel.Controls.Add(label4);
            leftPanel.Controls.Add(usernameText);
            leftPanel.Controls.Add(label3);
            leftPanel.Size = new Size(300, 724);
            leftPanel.Controls.SetChildIndex(panel1, 0);
            leftPanel.Controls.SetChildIndex(label3, 0);
            leftPanel.Controls.SetChildIndex(usernameText, 0);
            leftPanel.Controls.SetChildIndex(label4, 0);
            leftPanel.Controls.SetChildIndex(passwordText, 0);
            leftPanel.Controls.SetChildIndex(LoginBtn, 0);
            // 
            // panel1
            // 
            panel1.Size = new Size(300, 80);
            // 
            // rightPanel
            // 
            rightPanel.Location = new Point(300, 0);
            rightPanel.Size = new Size(1070, 724);
            // 
            // panel2
            // 
            panel2.Size = new Size(1070, 80);
            // 
            // label1
            // 
            label1.Location = new Point(101, 0);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(23, 209);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
            label3.TabIndex = 2;
            label3.Text = "Username";
            label3.Click += label3_Click;
            // 
            // usernameText
            // 
            usernameText.Location = new Point(23, 237);
            usernameText.MaxLength = 32;
            usernameText.Name = "usernameText";
            usernameText.Size = new Size(254, 31);
            usernameText.TabIndex = 3;
            usernameText.TextChanged += textBox1_TextChanged;
            // 
            // passwordText
            // 
            passwordText.Location = new Point(23, 336);
            passwordText.MaxLength = 30;
            passwordText.Name = "passwordText";
            passwordText.Size = new Size(254, 31);
            passwordText.TabIndex = 5;
            passwordText.UseSystemPasswordChar = true;
            passwordText.TextChanged += textBox2_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 308);
            label4.Name = "label4";
            label4.Size = new Size(87, 25);
            label4.TabIndex = 4;
            label4.Text = "Password";
            label4.Click += label4_Click;
            // 
            // LoginBtn
            // 
            LoginBtn.FlatAppearance.BorderSize = 2;
            LoginBtn.FlatStyle = FlatStyle.Flat;
            LoginBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LoginBtn.ForeColor = Color.White;
            LoginBtn.Location = new Point(23, 405);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(252, 56);
            LoginBtn.TabIndex = 6;
            LoginBtn.Text = "LOGIN";
            LoginBtn.UseVisualStyleBackColor = true;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 724);
            Name = "login";
            Text = "login";
            leftPanel.ResumeLayout(false);
            leftPanel.PerformLayout();
            panel1.ResumeLayout(false);
            rightPanel.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TextBox usernameText;
        private Label label3;
        private TextBox passwordText;
        private Label label4;
        private Button LoginBtn;
    }
}