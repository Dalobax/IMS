namespace Project
{
    partial class categories
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
            label5 = new Label();
            catTxt = new TextBox();
            label3 = new Label();
            catErrorLabel = new Label();
            activeErrorLable = new Label();
            activeDD = new ComboBox();
            dataGridView1 = new DataGridView();
            catIDGV = new DataGridViewTextBoxColumn();
            NameGV = new DataGridViewTextBoxColumn();
            statusGV = new DataGridViewTextBoxColumn();
            leftPanel.SuspendLayout();
            panel1.SuspendLayout();
            rightPanel.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // searchTxt
            // 
            searchTxt.Size = new Size(238, 31);
            // 
            // leftPanel
            // 
            leftPanel.Controls.Add(activeDD);
            leftPanel.Controls.Add(label5);
            leftPanel.Controls.Add(catTxt);
            leftPanel.Controls.Add(label3);
            leftPanel.Controls.Add(catErrorLabel);
            leftPanel.Controls.Add(activeErrorLable);
            leftPanel.Size = new Size(306, 575);
            leftPanel.Controls.SetChildIndex(panel1, 0);
            leftPanel.Controls.SetChildIndex(activeErrorLable, 0);
            leftPanel.Controls.SetChildIndex(catErrorLabel, 0);
            leftPanel.Controls.SetChildIndex(label3, 0);
            leftPanel.Controls.SetChildIndex(catTxt, 0);
            leftPanel.Controls.SetChildIndex(label5, 0);
            leftPanel.Controls.SetChildIndex(activeDD, 0);
            // 
            // rightPanel
            // 
            rightPanel.Controls.Add(dataGridView1);
            rightPanel.Size = new Size(860, 575);
            rightPanel.Controls.SetChildIndex(panel2, 0);
            rightPanel.Controls.SetChildIndex(dataGridView1, 0);
            // 
            // panel2
            // 
            panel2.Location = new Point(0, 74);
            panel2.Size = new Size(860, 80);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 229);
            label5.Name = "label5";
            label5.Size = new Size(78, 25);
            label5.TabIndex = 23;
            label5.Text = "Is Active";
            // 
            // catTxt
            // 
            catTxt.Location = new Point(6, 195);
            catTxt.Name = "catTxt";
            catTxt.Size = new Size(294, 31);
            catTxt.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 167);
            label3.Name = "label3";
            label3.Size = new Size(74, 25);
            label3.TabIndex = 20;
            label3.Text = "Product";
            // 
            // catErrorLabel
            // 
            catErrorLabel.AutoSize = true;
            catErrorLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            catErrorLabel.Location = new Point(137, 154);
            catErrorLabel.Name = "catErrorLabel";
            catErrorLabel.Size = new Size(31, 41);
            catErrorLabel.TabIndex = 22;
            catErrorLabel.Text = "*";
            catErrorLabel.Visible = false;
            // 
            // activeErrorLable
            // 
            activeErrorLable.AutoSize = true;
            activeErrorLable.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            activeErrorLable.Location = new Point(82, 216);
            activeErrorLable.Name = "activeErrorLable";
            activeErrorLable.Size = new Size(31, 41);
            activeErrorLable.TabIndex = 25;
            activeErrorLable.Text = "*";
            activeErrorLable.Visible = false;
            activeErrorLable.Click += barcodeErrorLable_Click;
            // 
            // activeDD
            // 
            activeDD.DropDownStyle = ComboBoxStyle.DropDownList;
            activeDD.FormattingEnabled = true;
            activeDD.Items.AddRange(new object[] { "Yes", "No" });
            activeDD.Location = new Point(6, 258);
            activeDD.Name = "activeDD";
            activeDD.Size = new Size(294, 33);
            activeDD.TabIndex = 26;
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { catIDGV, NameGV, statusGV });
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
            dataGridView1.Size = new Size(860, 421);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // catIDGV
            // 
            catIDGV.HeaderText = "CatID";
            catIDGV.MinimumWidth = 8;
            catIDGV.Name = "catIDGV";
            catIDGV.ReadOnly = true;
            catIDGV.Visible = false;
            // 
            // NameGV
            // 
            NameGV.HeaderText = "Name";
            NameGV.MinimumWidth = 8;
            NameGV.Name = "NameGV";
            NameGV.ReadOnly = true;
            // 
            // statusGV
            // 
            statusGV.HeaderText = "Status";
            statusGV.MinimumWidth = 8;
            statusGV.Name = "statusGV";
            statusGV.ReadOnly = true;
            statusGV.Resizable = DataGridViewTriState.True;
            // 
            // categories
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1166, 575);
            Name = "categories";
            Text = "categories";
            Load += categories_Load;
            leftPanel.ResumeLayout(false);
            leftPanel.PerformLayout();
            panel1.ResumeLayout(false);
            rightPanel.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox activeDD;
        private Label label5;
        private TextBox catTxt;
        private Label label3;
        private Label catErrorLabel;
        private Label activeErrorLable;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn catIDGV;
        private DataGridViewTextBoxColumn NameGV;
        private DataGridViewTextBoxColumn statusGV;
    }
}