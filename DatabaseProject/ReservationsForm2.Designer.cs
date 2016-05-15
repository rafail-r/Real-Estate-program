namespace DatabaseProject
{
    partial class ReservationsForm2
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
            this.hotelText = new System.Windows.Forms.TextBox();
            this.roomTypeText = new System.Windows.Forms.TextBox();
            this.fromText = new System.Windows.Forms.TextBox();
            this.toText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.totalPriceText = new System.Windows.Forms.TextBox();
            this.backButt = new System.Windows.Forms.Button();
            this.phoneCustomerText = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.finalReserveButt = new System.Windows.Forms.Button();
            this.customerText = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.paymentMethodCombo = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.peopleNoText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hotelText
            // 
            this.hotelText.Location = new System.Drawing.Point(126, 12);
            this.hotelText.Name = "hotelText";
            this.hotelText.ReadOnly = true;
            this.hotelText.Size = new System.Drawing.Size(120, 20);
            this.hotelText.TabIndex = 1;
            // 
            // roomTypeText
            // 
            this.roomTypeText.Location = new System.Drawing.Point(126, 116);
            this.roomTypeText.Name = "roomTypeText";
            this.roomTypeText.ReadOnly = true;
            this.roomTypeText.Size = new System.Drawing.Size(120, 20);
            this.roomTypeText.TabIndex = 2;
            // 
            // fromText
            // 
            this.fromText.Location = new System.Drawing.Point(126, 38);
            this.fromText.Name = "fromText";
            this.fromText.ReadOnly = true;
            this.fromText.Size = new System.Drawing.Size(120, 20);
            this.fromText.TabIndex = 4;
            // 
            // toText
            // 
            this.toText.Location = new System.Drawing.Point(126, 64);
            this.toText.Name = "toText";
            this.toText.ReadOnly = true;
            this.toText.Size = new System.Drawing.Size(120, 20);
            this.toText.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Hotel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Room Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "From";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(100, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "To";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(62, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Total Price";
            // 
            // totalPriceText
            // 
            this.totalPriceText.Location = new System.Drawing.Point(126, 142);
            this.totalPriceText.Name = "totalPriceText";
            this.totalPriceText.ReadOnly = true;
            this.totalPriceText.Size = new System.Drawing.Size(120, 20);
            this.totalPriceText.TabIndex = 11;
            // 
            // backButt
            // 
            this.backButt.Location = new System.Drawing.Point(12, 267);
            this.backButt.Name = "backButt";
            this.backButt.Size = new System.Drawing.Size(75, 23);
            this.backButt.TabIndex = 13;
            this.backButt.Text = "Back";
            this.backButt.UseVisualStyleBackColor = true;
            this.backButt.Click += new System.EventHandler(this.backButt_Click);
            // 
            // phoneCustomerText
            // 
            this.phoneCustomerText.Location = new System.Drawing.Point(127, 168);
            this.phoneCustomerText.Mask = "(999) 000-0000";
            this.phoneCustomerText.Name = "phoneCustomerText";
            this.phoneCustomerText.Size = new System.Drawing.Size(120, 20);
            this.phoneCustomerText.TabIndex = 14;
            this.phoneCustomerText.TextChanged += new System.EventHandler(this.phoneCustomerText_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Customer\'s Phone";
            // 
            // finalReserveButt
            // 
            this.finalReserveButt.Enabled = false;
            this.finalReserveButt.Location = new System.Drawing.Point(251, 267);
            this.finalReserveButt.Name = "finalReserveButt";
            this.finalReserveButt.Size = new System.Drawing.Size(75, 23);
            this.finalReserveButt.TabIndex = 17;
            this.finalReserveButt.Text = "Reserve";
            this.finalReserveButt.UseVisualStyleBackColor = true;
            this.finalReserveButt.Click += new System.EventHandler(this.finalReserveButt_Click);
            // 
            // customerText
            // 
            this.customerText.Location = new System.Drawing.Point(126, 221);
            this.customerText.Name = "customerText";
            this.customerText.ReadOnly = true;
            this.customerText.Size = new System.Drawing.Size(153, 20);
            this.customerText.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(69, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Customer";
            // 
            // paymentMethodCombo
            // 
            this.paymentMethodCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.paymentMethodCombo.FormattingEnabled = true;
            this.paymentMethodCombo.Location = new System.Drawing.Point(126, 194);
            this.paymentMethodCombo.Name = "paymentMethodCombo";
            this.paymentMethodCombo.Size = new System.Drawing.Size(121, 21);
            this.paymentMethodCombo.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 197);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Payment Method";
            // 
            // peopleNoText
            // 
            this.peopleNoText.Location = new System.Drawing.Point(126, 90);
            this.peopleNoText.Name = "peopleNoText";
            this.peopleNoText.ReadOnly = true;
            this.peopleNoText.Size = new System.Drawing.Size(120, 20);
            this.peopleNoText.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "People";
            // 
            // ReservationsForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 307);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.peopleNoText);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.paymentMethodCombo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.customerText);
            this.Controls.Add(this.finalReserveButt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.phoneCustomerText);
            this.Controls.Add(this.backButt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.totalPriceText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toText);
            this.Controls.Add(this.fromText);
            this.Controls.Add(this.roomTypeText);
            this.Controls.Add(this.hotelText);
            this.Name = "ReservationsForm2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReservationsForm2";
            this.Shown += new System.EventHandler(this.ReservationsForm2_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox hotelText;
        private System.Windows.Forms.TextBox roomTypeText;
        private System.Windows.Forms.TextBox fromText;
        private System.Windows.Forms.TextBox toText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox totalPriceText;
        private System.Windows.Forms.Button backButt;
        private System.Windows.Forms.MaskedTextBox phoneCustomerText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button finalReserveButt;
        private System.Windows.Forms.TextBox customerText;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox paymentMethodCombo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox peopleNoText;
        private System.Windows.Forms.Label label3;
    }
}