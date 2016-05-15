namespace DatabaseProject
{
    partial class CancelReservationForm
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
            this.phoneText = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.customerText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.reservationsCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cancelReservationButt = new System.Windows.Forms.Button();
            this.changeReservationButt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // phoneText
            // 
            this.phoneText.Location = new System.Drawing.Point(123, 38);
            this.phoneText.Mask = "(999) 000-0000";
            this.phoneText.Name = "phoneText";
            this.phoneText.Size = new System.Drawing.Size(100, 20);
            this.phoneText.TabIndex = 0;
            this.phoneText.TextChanged += new System.EventHandler(this.phoneText_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Phone";
            // 
            // customerText
            // 
            this.customerText.Location = new System.Drawing.Point(123, 67);
            this.customerText.Name = "customerText";
            this.customerText.ReadOnly = true;
            this.customerText.Size = new System.Drawing.Size(136, 20);
            this.customerText.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            // 
            // reservationsCombo
            // 
            this.reservationsCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.reservationsCombo.FormattingEnabled = true;
            this.reservationsCombo.Location = new System.Drawing.Point(123, 93);
            this.reservationsCombo.Name = "reservationsCombo";
            this.reservationsCombo.Size = new System.Drawing.Size(385, 21);
            this.reservationsCombo.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Reservations";
            // 
            // cancelReservationButt
            // 
            this.cancelReservationButt.Enabled = false;
            this.cancelReservationButt.Location = new System.Drawing.Point(123, 120);
            this.cancelReservationButt.Name = "cancelReservationButt";
            this.cancelReservationButt.Size = new System.Drawing.Size(129, 23);
            this.cancelReservationButt.TabIndex = 30;
            this.cancelReservationButt.Text = "Cancel Reservation";
            this.cancelReservationButt.UseVisualStyleBackColor = true;
            this.cancelReservationButt.Click += new System.EventHandler(this.cancelReservationButt_Click);
            // 
            // changeReservationButt
            // 
            this.changeReservationButt.Enabled = false;
            this.changeReservationButt.Location = new System.Drawing.Point(258, 120);
            this.changeReservationButt.Name = "changeReservationButt";
            this.changeReservationButt.Size = new System.Drawing.Size(129, 23);
            this.changeReservationButt.TabIndex = 31;
            this.changeReservationButt.Text = "Change Reservation";
            this.changeReservationButt.UseVisualStyleBackColor = true;
            this.changeReservationButt.Click += new System.EventHandler(this.changeResButt_Click);
            // 
            // CancelReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 168);
            this.Controls.Add(this.changeReservationButt);
            this.Controls.Add(this.cancelReservationButt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.reservationsCombo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.customerText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.phoneText);
            this.Name = "CancelReservationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CancelReservation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox phoneText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox customerText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox reservationsCombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cancelReservationButt;
        private System.Windows.Forms.Button changeReservationButt;
    }
}