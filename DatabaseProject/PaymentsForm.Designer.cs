namespace DatabaseProject
{
    partial class PaymentsForm
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
            this.customerText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.paymentButt = new System.Windows.Forms.Button();
            this.amountText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.reservationsCombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // phoneText
            // 
            this.phoneText.Location = new System.Drawing.Point(110, 59);
            this.phoneText.Mask = "(999) 000-0000";
            this.phoneText.Name = "phoneText";
            this.phoneText.Size = new System.Drawing.Size(90, 20);
            this.phoneText.TabIndex = 0;
            this.phoneText.TextChanged += new System.EventHandler(this.phoneText_TextChanged);
            // 
            // customerText
            // 
            this.customerText.Location = new System.Drawing.Point(110, 88);
            this.customerText.Name = "customerText";
            this.customerText.ReadOnly = true;
            this.customerText.Size = new System.Drawing.Size(257, 20);
            this.customerText.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Customer\'s Phone";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(53, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Customer";
            // 
            // paymentButt
            // 
            this.paymentButt.Location = new System.Drawing.Point(110, 167);
            this.paymentButt.Name = "paymentButt";
            this.paymentButt.Size = new System.Drawing.Size(75, 23);
            this.paymentButt.TabIndex = 24;
            this.paymentButt.Text = "Payment";
            this.paymentButt.UseVisualStyleBackColor = true;
            this.paymentButt.Click += new System.EventHandler(this.paymentButt_Click);
            // 
            // amountText
            // 
            this.amountText.Location = new System.Drawing.Point(110, 141);
            this.amountText.Name = "amountText";
            this.amountText.ReadOnly = true;
            this.amountText.Size = new System.Drawing.Size(75, 20);
            this.amountText.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Amount";
            // 
            // reservationsCombo
            // 
            this.reservationsCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.reservationsCombo.FormattingEnabled = true;
            this.reservationsCombo.Location = new System.Drawing.Point(110, 114);
            this.reservationsCombo.Name = "reservationsCombo";
            this.reservationsCombo.Size = new System.Drawing.Size(385, 21);
            this.reservationsCombo.TabIndex = 27;
            this.reservationsCombo.SelectedIndexChanged += new System.EventHandler(this.reservationsCombo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Reservation";
            // 
            // PaymentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 207);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.reservationsCombo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.amountText);
            this.Controls.Add(this.paymentButt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.customerText);
            this.Controls.Add(this.phoneText);
            this.Name = "PaymentsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaymentsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox phoneText;
        private System.Windows.Forms.TextBox customerText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button paymentButt;
        private System.Windows.Forms.TextBox amountText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox reservationsCombo;
        private System.Windows.Forms.Label label2;
    }
}