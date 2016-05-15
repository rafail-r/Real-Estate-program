namespace DatabaseProject
{
    partial class ReservationsForm
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
            this.hotelsCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.toDate = new System.Windows.Forms.MaskedTextBox();
            this.fromDate = new System.Windows.Forms.MaskedTextBox();
            this.roomsList = new System.Windows.Forms.ListBox();
            this.nextReserveButt = new System.Windows.Forms.Button();
            this.selectionLabel = new System.Windows.Forms.Label();
            this.peopleNo = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hotelsCombo
            // 
            this.hotelsCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hotelsCombo.FormattingEnabled = true;
            this.hotelsCombo.Location = new System.Drawing.Point(83, 14);
            this.hotelsCombo.Name = "hotelsCombo";
            this.hotelsCombo.Size = new System.Drawing.Size(122, 21);
            this.hotelsCombo.TabIndex = 0;
            this.hotelsCombo.SelectedIndexChanged += new System.EventHandler(this.hotelsCombo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hotels";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "From";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "To";
            // 
            // toDate
            // 
            this.toDate.Location = new System.Drawing.Point(84, 93);
            this.toDate.Mask = "00/00/0000";
            this.toDate.Name = "toDate";
            this.toDate.Size = new System.Drawing.Size(121, 20);
            this.toDate.TabIndex = 3;
            this.toDate.ValidatingType = typeof(System.DateTime);
            this.toDate.TextChanged += new System.EventHandler(this.toDate_TextChanged);
            // 
            // fromDate
            // 
            this.fromDate.Location = new System.Drawing.Point(83, 67);
            this.fromDate.Mask = "00/00/0000";
            this.fromDate.Name = "fromDate";
            this.fromDate.Size = new System.Drawing.Size(122, 20);
            this.fromDate.TabIndex = 2;
            this.fromDate.ValidatingType = typeof(System.DateTime);
            this.fromDate.TextChanged += new System.EventHandler(this.fromDate_TextChanged);
            // 
            // roomsList
            // 
            this.roomsList.FormattingEnabled = true;
            this.roomsList.Location = new System.Drawing.Point(84, 122);
            this.roomsList.Name = "roomsList";
            this.roomsList.Size = new System.Drawing.Size(121, 95);
            this.roomsList.TabIndex = 4;
            this.roomsList.SelectedIndexChanged += new System.EventHandler(this.roomsList_SelectedIndexChanged_1);
            // 
            // nextReserveButt
            // 
            this.nextReserveButt.Enabled = false;
            this.nextReserveButt.Location = new System.Drawing.Point(129, 251);
            this.nextReserveButt.Name = "nextReserveButt";
            this.nextReserveButt.Size = new System.Drawing.Size(76, 23);
            this.nextReserveButt.TabIndex = 5;
            this.nextReserveButt.Text = "Next";
            this.nextReserveButt.UseVisualStyleBackColor = true;
            this.nextReserveButt.Click += new System.EventHandler(this.proceedReserveButt_Click);
            // 
            // selectionLabel
            // 
            this.selectionLabel.AutoSize = true;
            this.selectionLabel.Location = new System.Drawing.Point(81, 220);
            this.selectionLabel.Name = "selectionLabel";
            this.selectionLabel.Size = new System.Drawing.Size(57, 13);
            this.selectionLabel.TabIndex = 9;
            this.selectionLabel.Text = "Selection: ";
            // 
            // peopleNo
            // 
            this.peopleNo.Location = new System.Drawing.Point(83, 41);
            this.peopleNo.Mask = "0";
            this.peopleNo.Name = "peopleNo";
            this.peopleNo.Size = new System.Drawing.Size(122, 20);
            this.peopleNo.TabIndex = 1;
            this.peopleNo.TextChanged += new System.EventHandler(this.peopleNo_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "People";
            // 
            // ReservationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 286);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.peopleNo);
            this.Controls.Add(this.selectionLabel);
            this.Controls.Add(this.nextReserveButt);
            this.Controls.Add(this.roomsList);
            this.Controls.Add(this.fromDate);
            this.Controls.Add(this.toDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hotelsCombo);
            this.Name = "ReservationsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MakeReservation";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ReservationsForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox hotelsCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox toDate;
        private System.Windows.Forms.MaskedTextBox fromDate;
        private System.Windows.Forms.ListBox roomsList;
        private System.Windows.Forms.Button nextReserveButt;
        private System.Windows.Forms.Label selectionLabel;
        private System.Windows.Forms.MaskedTextBox peopleNo;
        private System.Windows.Forms.Label label4;
    }
}