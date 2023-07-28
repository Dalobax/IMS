namespace Project
{
    partial class products
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
            productTxt = new TextBox();
            label3 = new Label();
            proErrorLabel = new Label();
            barcodeErrorLable = new Label();
            barcodeTxt = new TextBox();
            label5 = new Label();
            label6 = new Label();
            warrentyErrorLabel = new Label();
            expiryPicker = new DateTimePicker();
            priceTxt = new TextBox();
            label8 = new Label();
            priceErroeLabel = new Label();
            categoryTxt = new Label();
            categoryErrorLabel = new Label();
            categoryDD = new ComboBox();
            leftPanel.SuspendLayout();
            panel1.SuspendLayout();
            rightPanel.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // searchTxt
            // 
            searchTxt.Size = new Size(224, 31);
            // 
            // leftPanel
            // 
            leftPanel.Controls.Add(categoryDD);
            leftPanel.Controls.Add(categoryTxt);
            leftPanel.Controls.Add(priceTxt);
            leftPanel.Controls.Add(label8);
            leftPanel.Controls.Add(expiryPicker);
            leftPanel.Controls.Add(label6);
            leftPanel.Controls.Add(barcodeTxt);
            leftPanel.Controls.Add(label5);
            leftPanel.Controls.Add(productTxt);
            leftPanel.Controls.Add(label3);
            leftPanel.Controls.Add(proErrorLabel);
            leftPanel.Controls.Add(barcodeErrorLable);
            leftPanel.Controls.Add(warrentyErrorLabel);
            leftPanel.Controls.Add(priceErroeLabel);
            leftPanel.Controls.Add(categoryErrorLabel);
            leftPanel.Size = new Size(306, 687);
            leftPanel.Controls.SetChildIndex(categoryErrorLabel, 0);
            leftPanel.Controls.SetChildIndex(priceErroeLabel, 0);
            leftPanel.Controls.SetChildIndex(warrentyErrorLabel, 0);
            leftPanel.Controls.SetChildIndex(barcodeErrorLable, 0);
            leftPanel.Controls.SetChildIndex(proErrorLabel, 0);
            leftPanel.Controls.SetChildIndex(label3, 0);
            leftPanel.Controls.SetChildIndex(productTxt, 0);
            leftPanel.Controls.SetChildIndex(label5, 0);
            leftPanel.Controls.SetChildIndex(barcodeTxt, 0);
            leftPanel.Controls.SetChildIndex(label6, 0);
            leftPanel.Controls.SetChildIndex(expiryPicker, 0);
            leftPanel.Controls.SetChildIndex(label8, 0);
            leftPanel.Controls.SetChildIndex(priceTxt, 0);
            leftPanel.Controls.SetChildIndex(categoryTxt, 0);
            leftPanel.Controls.SetChildIndex(panel1, 0);
            leftPanel.Controls.SetChildIndex(categoryDD, 0);
            // 
            // rightPanel
            // 
            rightPanel.Size = new Size(811, 687);
            // 
            // panel2
            // 
            panel2.Size = new Size(811, 80);
            // 
            // productTxt
            // 
            productTxt.Location = new Point(6, 199);
            productTxt.Name = "productTxt";
            productTxt.Size = new Size(294, 31);
            productTxt.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 171);
            label3.Name = "label3";
            label3.Size = new Size(126, 25);
            label3.TabIndex = 5;
            label3.Text = "Product Name";
            // 
            // proErrorLabel
            // 
            proErrorLabel.AutoSize = true;
            proErrorLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            proErrorLabel.Location = new Point(127, 158);
            proErrorLabel.Name = "proErrorLabel";
            proErrorLabel.Size = new Size(31, 41);
            proErrorLabel.TabIndex = 16;
            proErrorLabel.Text = "*";
            proErrorLabel.Visible = false;
            // 
            // barcodeErrorLable
            // 
            barcodeErrorLable.AutoSize = true;
            barcodeErrorLable.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            barcodeErrorLable.Location = new Point(73, 220);
            barcodeErrorLable.Name = "barcodeErrorLable";
            barcodeErrorLable.Size = new Size(31, 41);
            barcodeErrorLable.TabIndex = 19;
            barcodeErrorLable.Text = "*";
            barcodeErrorLable.Visible = false;
            // 
            // barcodeTxt
            // 
            barcodeTxt.Location = new Point(6, 261);
            barcodeTxt.Name = "barcodeTxt";
            barcodeTxt.Size = new Size(294, 31);
            barcodeTxt.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 233);
            label5.Name = "label5";
            label5.Size = new Size(76, 25);
            label5.TabIndex = 17;
            label5.Text = "Barcode";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 297);
            label6.Name = "label6";
            label6.Size = new Size(83, 25);
            label6.TabIndex = 20;
            label6.Text = "Warrenty";
            // 
            // warrentyErrorLabel
            // 
            warrentyErrorLabel.AutoSize = true;
            warrentyErrorLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            warrentyErrorLabel.Location = new Point(82, 284);
            warrentyErrorLabel.Name = "warrentyErrorLabel";
            warrentyErrorLabel.Size = new Size(31, 41);
            warrentyErrorLabel.TabIndex = 22;
            warrentyErrorLabel.Text = "*";
            warrentyErrorLabel.Visible = false;
            // 
            // expiryPicker
            // 
            expiryPicker.CustomFormat = "dd-MMM-YYYY";
            expiryPicker.Format = DateTimePickerFormat.Custom;
            expiryPicker.Location = new Point(6, 325);
            expiryPicker.Name = "expiryPicker";
            expiryPicker.Size = new Size(294, 31);
            expiryPicker.TabIndex = 23;
            // 
            // priceTxt
            // 
            priceTxt.Location = new Point(6, 388);
            priceTxt.Name = "priceTxt";
            priceTxt.Size = new Size(294, 31);
            priceTxt.TabIndex = 25;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(9, 360);
            label8.Name = "label8";
            label8.Size = new Size(49, 25);
            label8.TabIndex = 24;
            label8.Text = "Price";
            // 
            // priceErroeLabel
            // 
            priceErroeLabel.AutoSize = true;
            priceErroeLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            priceErroeLabel.Location = new Point(64, 347);
            priceErroeLabel.Name = "priceErroeLabel";
            priceErroeLabel.Size = new Size(31, 41);
            priceErroeLabel.TabIndex = 26;
            priceErroeLabel.Text = "*";
            priceErroeLabel.Visible = false;
            // 
            // categoryTxt
            // 
            categoryTxt.AutoSize = true;
            categoryTxt.Location = new Point(6, 422);
            categoryTxt.Name = "categoryTxt";
            categoryTxt.Size = new Size(84, 25);
            categoryTxt.TabIndex = 27;
            categoryTxt.Text = "Category";
            // 
            // categoryErrorLabel
            // 
            categoryErrorLabel.AutoSize = true;
            categoryErrorLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            categoryErrorLabel.Location = new Point(96, 409);
            categoryErrorLabel.Name = "categoryErrorLabel";
            categoryErrorLabel.Size = new Size(31, 41);
            categoryErrorLabel.TabIndex = 29;
            categoryErrorLabel.Text = "*";
            categoryErrorLabel.Visible = false;
            // 
            // categoryDD
            // 
            categoryDD.FormattingEnabled = true;
            categoryDD.Location = new Point(6, 457);
            categoryDD.Name = "categoryDD";
            categoryDD.Size = new Size(294, 33);
            categoryDD.TabIndex = 30;
            // 
            // products
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1117, 687);
            Name = "products";
            Text = "Products";
            Load += products_Load;
            leftPanel.ResumeLayout(false);
            leftPanel.PerformLayout();
            panel1.ResumeLayout(false);
            rightPanel.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TextBox productTxt;
        private Label label3;
        private TextBox barcodeTxt;
        private Label label5;
        private Label proErrorLabel;
        private Label barcodeErrorLable;
        private DateTimePicker expiryPicker;
        private Label label6;
        private Label warrentyErrorLabel;
        private TextBox priceTxt;
        private Label label8;
        private Label priceErroeLabel;
        private Label categoryTxt;
        private Label categoryErrorLabel;
        private ComboBox categoryDD;
    }
}