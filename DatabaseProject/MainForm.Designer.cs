namespace DatabaseProject
{
    partial class MainForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.updateCustomerBtn = new System.Windows.Forms.Button();
            this.newCustomerBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.searchButton = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.reservationsBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.phoneText = new System.Windows.Forms.MaskedTextBox();
            this.newPaymentButt = new System.Windows.Forms.Button();
            this.cancelResButt = new System.Windows.Forms.Button();
            this.newReservationButt = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.updateHotelBtn = new System.Windows.Forms.Button();
            this.newHotelBtn = new System.Windows.Forms.Button();
            this.hotelRoomsButt = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(668, 362);
            this.tabControl1.TabIndex = 16;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.updateCustomerBtn);
            this.tabPage1.Controls.Add(this.newCustomerBtn);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.searchButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(660, 336);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // updateCustomerBtn
            // 
            this.updateCustomerBtn.Location = new System.Drawing.Point(532, 291);
            this.updateCustomerBtn.Name = "updateCustomerBtn";
            this.updateCustomerBtn.Size = new System.Drawing.Size(98, 23);
            this.updateCustomerBtn.TabIndex = 13;
            this.updateCustomerBtn.Text = "Update Customer";
            this.updateCustomerBtn.UseVisualStyleBackColor = true;
            this.updateCustomerBtn.Click += new System.EventHandler(this.updateCustomerBtn_Click);
            // 
            // newCustomerBtn
            // 
            this.newCustomerBtn.Location = new System.Drawing.Point(532, 262);
            this.newCustomerBtn.Name = "newCustomerBtn";
            this.newCustomerBtn.Size = new System.Drawing.Size(98, 23);
            this.newCustomerBtn.TabIndex = 12;
            this.newCustomerBtn.Text = "New Customer";
            this.newCustomerBtn.UseVisualStyleBackColor = true;
            this.newCustomerBtn.Click += new System.EventHandler(this.newCustomerBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(38, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(592, 188);
            this.dataGridView1.TabIndex = 9;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(532, 233);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(98, 23);
            this.searchButton.TabIndex = 8;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.reservationsBox);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.phoneText);
            this.tabPage3.Controls.Add(this.newPaymentButt);
            this.tabPage3.Controls.Add(this.cancelResButt);
            this.tabPage3.Controls.Add(this.newReservationButt);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(660, 336);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Reservations";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // reservationsBox
            // 
            this.reservationsBox.FormattingEnabled = true;
            this.reservationsBox.Location = new System.Drawing.Point(30, 50);
            this.reservationsBox.Name = "reservationsBox";
            this.reservationsBox.Size = new System.Drawing.Size(349, 225);
            this.reservationsBox.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Customer\'s Phone";
            // 
            // phoneText
            // 
            this.phoneText.Location = new System.Drawing.Point(125, 24);
            this.phoneText.Mask = "(999) 000-0000";
            this.phoneText.Name = "phoneText";
            this.phoneText.Size = new System.Drawing.Size(100, 20);
            this.phoneText.TabIndex = 16;
            this.phoneText.TextChanged += new System.EventHandler(this.phoneText_TextChanged);
            // 
            // newPaymentButt
            // 
            this.newPaymentButt.Location = new System.Drawing.Point(436, 108);
            this.newPaymentButt.Name = "newPaymentButt";
            this.newPaymentButt.Size = new System.Drawing.Size(157, 23);
            this.newPaymentButt.TabIndex = 12;
            this.newPaymentButt.Text = "New Payment";
            this.newPaymentButt.UseVisualStyleBackColor = true;
            this.newPaymentButt.Click += new System.EventHandler(this.newPaymentButt_Click);
            // 
            // cancelResButt
            // 
            this.cancelResButt.Location = new System.Drawing.Point(436, 79);
            this.cancelResButt.Name = "cancelResButt";
            this.cancelResButt.Size = new System.Drawing.Size(157, 23);
            this.cancelResButt.TabIndex = 13;
            this.cancelResButt.Text = "Cancel/Change Reservation";
            this.cancelResButt.UseVisualStyleBackColor = true;
            this.cancelResButt.Click += new System.EventHandler(this.cancelResButt_Click);
            // 
            // newReservationButt
            // 
            this.newReservationButt.Location = new System.Drawing.Point(436, 50);
            this.newReservationButt.Name = "newReservationButt";
            this.newReservationButt.Size = new System.Drawing.Size(157, 23);
            this.newReservationButt.TabIndex = 10;
            this.newReservationButt.Text = "New Reservation";
            this.newReservationButt.UseVisualStyleBackColor = true;
            this.newReservationButt.Click += new System.EventHandler(this.newReservationButt_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Controls.Add(this.passwordBox);
            this.tabPage4.Controls.Add(this.updateHotelBtn);
            this.tabPage4.Controls.Add(this.newHotelBtn);
            this.tabPage4.Controls.Add(this.hotelRoomsButt);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(660, 336);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Administration";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Password";
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(229, 22);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(100, 20);
            this.passwordBox.TabIndex = 18;
            this.passwordBox.TextChanged += new System.EventHandler(this.passwordBox_TextChanged);
            // 
            // updateHotelBtn
            // 
            this.updateHotelBtn.Location = new System.Drawing.Point(226, 119);
            this.updateHotelBtn.Name = "updateHotelBtn";
            this.updateHotelBtn.Size = new System.Drawing.Size(187, 52);
            this.updateHotelBtn.TabIndex = 17;
            this.updateHotelBtn.Text = "Update Hotel";
            this.updateHotelBtn.UseVisualStyleBackColor = true;
            this.updateHotelBtn.Click += new System.EventHandler(this.updateHotelBtn_Click);
            // 
            // newHotelBtn
            // 
            this.newHotelBtn.Location = new System.Drawing.Point(226, 61);
            this.newHotelBtn.Name = "newHotelBtn";
            this.newHotelBtn.Size = new System.Drawing.Size(187, 52);
            this.newHotelBtn.TabIndex = 16;
            this.newHotelBtn.Text = "New Hotel";
            this.newHotelBtn.UseVisualStyleBackColor = true;
            this.newHotelBtn.Click += new System.EventHandler(this.newHotelBtn_Click);
            // 
            // hotelRoomsButt
            // 
            this.hotelRoomsButt.Location = new System.Drawing.Point(226, 177);
            this.hotelRoomsButt.Name = "hotelRoomsButt";
            this.hotelRoomsButt.Size = new System.Drawing.Size(187, 52);
            this.hotelRoomsButt.TabIndex = 14;
            this.hotelRoomsButt.Text = "Rooms";
            this.hotelRoomsButt.UseVisualStyleBackColor = true;
            this.hotelRoomsButt.Click += new System.EventHandler(this.hotelRoomsButt_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 392);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "For Teh Lulz";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button hotelRoomsButt;
        private System.Windows.Forms.Button newReservationButt;
        private System.Windows.Forms.Button cancelResButt;
        private System.Windows.Forms.Button newPaymentButt;
        private System.Windows.Forms.Button updateCustomerBtn;
        private System.Windows.Forms.Button newCustomerBtn;
        private System.Windows.Forms.Button updateHotelBtn;
        private System.Windows.Forms.Button newHotelBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox phoneText;
        private System.Windows.Forms.ListBox reservationsBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passwordBox;



    }
}

