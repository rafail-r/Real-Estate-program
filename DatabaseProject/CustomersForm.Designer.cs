namespace DatabaseProject
{
    partial class CustomersForm
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.emailText = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.birthdateText = new System.Windows.Forms.MaskedTextBox();
            this.lastnameText = new System.Windows.Forms.TextBox();
            this.nameText = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.zipcodeText = new System.Windows.Forms.MaskedTextBox();
            this.streetnoText = new System.Windows.Forms.MaskedTextBox();
            this.phoneText = new System.Windows.Forms.MaskedTextBox();
            this.streetText = new System.Windows.Forms.TextBox();
            this.cityText = new System.Windows.Forms.TextBox();
            this.countryText = new System.Windows.Forms.TextBox();
            this.addCustButt = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.emailText);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.birthdateText);
            this.groupBox2.Controls.Add(this.lastnameText);
            this.groupBox2.Controls.Add(this.nameText);
            this.groupBox2.Location = new System.Drawing.Point(253, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(212, 216);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Customer";
            // 
            // emailText
            // 
            this.emailText.Location = new System.Drawing.Point(53, 145);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(153, 20);
            this.emailText.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(50, 129);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Emails";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(50, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Birthdate";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(50, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Last Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "First Name";
            // 
            // birthdateText
            // 
            this.birthdateText.Location = new System.Drawing.Point(53, 106);
            this.birthdateText.Mask = "00/00/0000";
            this.birthdateText.Name = "birthdateText";
            this.birthdateText.Size = new System.Drawing.Size(100, 20);
            this.birthdateText.TabIndex = 2;
            this.birthdateText.ValidatingType = typeof(System.DateTime);
            // 
            // lastnameText
            // 
            this.lastnameText.Location = new System.Drawing.Point(53, 67);
            this.lastnameText.Name = "lastnameText";
            this.lastnameText.Size = new System.Drawing.Size(100, 20);
            this.lastnameText.TabIndex = 1;
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(53, 28);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(100, 20);
            this.nameText.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.zipcodeText);
            this.groupBox1.Controls.Add(this.streetnoText);
            this.groupBox1.Controls.Add(this.phoneText);
            this.groupBox1.Controls.Add(this.streetText);
            this.groupBox1.Controls.Add(this.cityText);
            this.groupBox1.Controls.Add(this.countryText);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(194, 269);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Street Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Street";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Zipcode";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "City";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Country";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Phone";
            // 
            // zipcodeText
            // 
            this.zipcodeText.Location = new System.Drawing.Point(34, 157);
            this.zipcodeText.Mask = "00000";
            this.zipcodeText.Name = "zipcodeText";
            this.zipcodeText.Size = new System.Drawing.Size(100, 20);
            this.zipcodeText.TabIndex = 3;
            this.zipcodeText.ValidatingType = typeof(int);
            // 
            // streetnoText
            // 
            this.streetnoText.Location = new System.Drawing.Point(34, 235);
            this.streetnoText.Mask = "00000";
            this.streetnoText.Name = "streetnoText";
            this.streetnoText.Size = new System.Drawing.Size(100, 20);
            this.streetnoText.TabIndex = 5;
            this.streetnoText.ValidatingType = typeof(int);
            // 
            // phoneText
            // 
            this.phoneText.Location = new System.Drawing.Point(34, 40);
            this.phoneText.Mask = "(999) 000-0000";
            this.phoneText.Name = "phoneText";
            this.phoneText.Size = new System.Drawing.Size(100, 20);
            this.phoneText.TabIndex = 0;
            // 
            // streetText
            // 
            this.streetText.Location = new System.Drawing.Point(34, 196);
            this.streetText.Name = "streetText";
            this.streetText.Size = new System.Drawing.Size(100, 20);
            this.streetText.TabIndex = 4;
            // 
            // cityText
            // 
            this.cityText.Location = new System.Drawing.Point(34, 118);
            this.cityText.Name = "cityText";
            this.cityText.Size = new System.Drawing.Size(100, 20);
            this.cityText.TabIndex = 2;
            // 
            // countryText
            // 
            this.countryText.Location = new System.Drawing.Point(34, 79);
            this.countryText.Name = "countryText";
            this.countryText.Size = new System.Drawing.Size(100, 20);
            this.countryText.TabIndex = 1;
            // 
            // addCustButt
            // 
            this.addCustButt.Location = new System.Drawing.Point(331, 247);
            this.addCustButt.Name = "addCustButt";
            this.addCustButt.Size = new System.Drawing.Size(75, 22);
            this.addCustButt.TabIndex = 18;
            this.addCustButt.Text = "Add Customer";
            this.addCustButt.UseVisualStyleBackColor = true;
            this.addCustButt.Click += new System.EventHandler(this.addCustButt_Click);
            // 
            // CustomersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 315);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.addCustButt);
            this.Name = "CustomersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox emailText;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox birthdateText;
        private System.Windows.Forms.TextBox lastnameText;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox zipcodeText;
        private System.Windows.Forms.MaskedTextBox streetnoText;
        private System.Windows.Forms.MaskedTextBox phoneText;
        private System.Windows.Forms.TextBox streetText;
        private System.Windows.Forms.TextBox cityText;
        private System.Windows.Forms.TextBox countryText;
        private System.Windows.Forms.Button addCustButt;
    }
}