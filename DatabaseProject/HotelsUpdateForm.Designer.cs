namespace DatabaseProject
{
    partial class HotelsUpdateForm
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
            this.addButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.starsHotel2 = new System.Windows.Forms.TextBox();
            this.typeHotel2 = new System.Windows.Forms.TextBox();
            this.stars = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.nameHotel2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.zipcodeText2 = new System.Windows.Forms.MaskedTextBox();
            this.streetnoText2 = new System.Windows.Forms.MaskedTextBox();
            this.phoneText2 = new System.Windows.Forms.MaskedTextBox();
            this.streetText2 = new System.Windows.Forms.TextBox();
            this.cityText2 = new System.Windows.Forms.TextBox();
            this.countryText2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.hotelsCombo = new System.Windows.Forms.ComboBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(414, 241);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 27;
            this.addButton.Text = "Update";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.starsHotel2);
            this.groupBox2.Controls.Add(this.typeHotel2);
            this.groupBox2.Controls.Add(this.stars);
            this.groupBox2.Controls.Add(this.type);
            this.groupBox2.Controls.Add(this.name);
            this.groupBox2.Controls.Add(this.nameHotel2);
            this.groupBox2.Location = new System.Drawing.Point(273, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(216, 154);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hotel";
            // 
            // starsHotel2
            // 
            this.starsHotel2.Location = new System.Drawing.Point(92, 115);
            this.starsHotel2.Name = "starsHotel2";
            this.starsHotel2.Size = new System.Drawing.Size(31, 20);
            this.starsHotel2.TabIndex = 6;
            // 
            // typeHotel2
            // 
            this.typeHotel2.Location = new System.Drawing.Point(41, 79);
            this.typeHotel2.Name = "typeHotel2";
            this.typeHotel2.Size = new System.Drawing.Size(100, 20);
            this.typeHotel2.TabIndex = 4;
            // 
            // stars
            // 
            this.stars.AutoSize = true;
            this.stars.Location = new System.Drawing.Point(38, 118);
            this.stars.Name = "stars";
            this.stars.Size = new System.Drawing.Size(31, 13);
            this.stars.TabIndex = 3;
            this.stars.Text = "Stars";
            // 
            // type
            // 
            this.type.AutoSize = true;
            this.type.Location = new System.Drawing.Point(38, 63);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(31, 13);
            this.type.TabIndex = 2;
            this.type.Text = "Type";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(38, 24);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(70, 13);
            this.name.TabIndex = 1;
            this.name.Text = "Hotel\'s Name";
            // 
            // nameHotel2
            // 
            this.nameHotel2.Location = new System.Drawing.Point(41, 40);
            this.nameHotel2.Name = "nameHotel2";
            this.nameHotel2.Size = new System.Drawing.Size(100, 20);
            this.nameHotel2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.zipcodeText2);
            this.groupBox1.Controls.Add(this.streetnoText2);
            this.groupBox1.Controls.Add(this.phoneText2);
            this.groupBox1.Controls.Add(this.streetText2);
            this.groupBox1.Controls.Add(this.cityText2);
            this.groupBox1.Controls.Add(this.countryText2);
            this.groupBox1.Location = new System.Drawing.Point(35, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(194, 269);
            this.groupBox1.TabIndex = 25;
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
            // zipcodeText2
            // 
            this.zipcodeText2.Location = new System.Drawing.Point(34, 157);
            this.zipcodeText2.Mask = "00000";
            this.zipcodeText2.Name = "zipcodeText2";
            this.zipcodeText2.Size = new System.Drawing.Size(100, 20);
            this.zipcodeText2.TabIndex = 3;
            this.zipcodeText2.ValidatingType = typeof(int);
            // 
            // streetnoText2
            // 
            this.streetnoText2.Location = new System.Drawing.Point(34, 235);
            this.streetnoText2.Mask = "00000";
            this.streetnoText2.Name = "streetnoText2";
            this.streetnoText2.Size = new System.Drawing.Size(100, 20);
            this.streetnoText2.TabIndex = 5;
            this.streetnoText2.ValidatingType = typeof(int);
            // 
            // phoneText2
            // 
            this.phoneText2.Location = new System.Drawing.Point(34, 40);
            this.phoneText2.Mask = "(999) 000-0000";
            this.phoneText2.Name = "phoneText2";
            this.phoneText2.Size = new System.Drawing.Size(100, 20);
            this.phoneText2.TabIndex = 0;
            // 
            // streetText2
            // 
            this.streetText2.Location = new System.Drawing.Point(34, 196);
            this.streetText2.Name = "streetText2";
            this.streetText2.Size = new System.Drawing.Size(100, 20);
            this.streetText2.TabIndex = 4;
            // 
            // cityText2
            // 
            this.cityText2.Location = new System.Drawing.Point(34, 118);
            this.cityText2.Name = "cityText2";
            this.cityText2.Size = new System.Drawing.Size(100, 20);
            this.cityText2.TabIndex = 2;
            // 
            // countryText2
            // 
            this.countryText2.Location = new System.Drawing.Point(34, 79);
            this.countryText2.Name = "countryText2";
            this.countryText2.Size = new System.Drawing.Size(100, 20);
            this.countryText2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(35, 350);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 30;
            this.button1.TabStop = false;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // hotelsCombo
            // 
            this.hotelsCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hotelsCombo.FormattingEnabled = true;
            this.hotelsCombo.Location = new System.Drawing.Point(107, 13);
            this.hotelsCombo.Name = "hotelsCombo";
            this.hotelsCombo.Size = new System.Drawing.Size(121, 21);
            this.hotelsCombo.TabIndex = 31;
            this.hotelsCombo.SelectedIndexChanged += new System.EventHandler(this.hotelsCombo_SelectedIndexChanged);
            // 
            // HotelsUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 396);
            this.Controls.Add(this.hotelsCombo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "HotelsUpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HotelsUpdateForm";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox starsHotel2;
        private System.Windows.Forms.TextBox typeHotel2;
        private System.Windows.Forms.Label stars;
        private System.Windows.Forms.Label type;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox nameHotel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox zipcodeText2;
        private System.Windows.Forms.MaskedTextBox streetnoText2;
        private System.Windows.Forms.MaskedTextBox phoneText2;
        private System.Windows.Forms.TextBox streetText2;
        private System.Windows.Forms.TextBox cityText2;
        private System.Windows.Forms.TextBox countryText2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox hotelsCombo;

    }
}