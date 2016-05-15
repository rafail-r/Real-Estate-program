namespace DatabaseProject
{
    partial class RoomsForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.typeRoom = new System.Windows.Forms.TextBox();
            this.priceRoom = new System.Windows.Forms.TextBox();
            this.numberRoom = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.typeHotel = new System.Windows.Forms.TextBox();
            this.starsHotel = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.personsText = new System.Windows.Forms.TextBox();
            this.hotelsCombo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hotel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Room Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Room Price";
            // 
            // typeRoom
            // 
            this.typeRoom.Location = new System.Drawing.Point(102, 117);
            this.typeRoom.Name = "typeRoom";
            this.typeRoom.Size = new System.Drawing.Size(100, 20);
            this.typeRoom.TabIndex = 8;
            // 
            // priceRoom
            // 
            this.priceRoom.Location = new System.Drawing.Point(102, 154);
            this.priceRoom.Name = "priceRoom";
            this.priceRoom.Size = new System.Drawing.Size(100, 20);
            this.priceRoom.TabIndex = 9;
            // 
            // numberRoom
            // 
            this.numberRoom.Location = new System.Drawing.Point(174, 195);
            this.numberRoom.Name = "numberRoom";
            this.numberRoom.Size = new System.Drawing.Size(28, 20);
            this.numberRoom.TabIndex = 10;
            this.numberRoom.TextChanged += new System.EventHandler(this.FnumberRoom_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(128, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Add Rooms";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(65, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Type";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(65, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Stars";
            // 
            // typeHotel
            // 
            this.typeHotel.Location = new System.Drawing.Point(102, 53);
            this.typeHotel.Name = "typeHotel";
            this.typeHotel.ReadOnly = true;
            this.typeHotel.Size = new System.Drawing.Size(109, 20);
            this.typeHotel.TabIndex = 14;
            this.typeHotel.TabStop = false;
            // 
            // starsHotel
            // 
            this.starsHotel.Location = new System.Drawing.Point(102, 84);
            this.starsHotel.Name = "starsHotel";
            this.starsHotel.ReadOnly = true;
            this.starsHotel.Size = new System.Drawing.Size(109, 20);
            this.starsHotel.TabIndex = 15;
            this.starsHotel.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 198);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Select the numbers of rooms:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(128, 278);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Check Rooms";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(16, 278);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 23;
            this.button3.TabStop = false;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 240);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Max persons";
            // 
            // personsText
            // 
            this.personsText.Location = new System.Drawing.Point(86, 237);
            this.personsText.Name = "personsText";
            this.personsText.Size = new System.Drawing.Size(32, 20);
            this.personsText.TabIndex = 25;
            // 
            // hotelsCombo
            // 
            this.hotelsCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hotelsCombo.FormattingEnabled = true;
            this.hotelsCombo.Location = new System.Drawing.Point(102, 22);
            this.hotelsCombo.Name = "hotelsCombo";
            this.hotelsCombo.Size = new System.Drawing.Size(110, 21);
            this.hotelsCombo.TabIndex = 26;
            this.hotelsCombo.SelectedIndexChanged += new System.EventHandler(this.hotelsCombo_SelectedIndexChanged);
            // 
            // RoomsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 329);
            this.Controls.Add(this.hotelsCombo);
            this.Controls.Add(this.personsText);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.starsHotel);
            this.Controls.Add(this.typeHotel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numberRoom);
            this.Controls.Add(this.priceRoom);
            this.Controls.Add(this.typeRoom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "RoomsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RoomsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox typeRoom;
        private System.Windows.Forms.TextBox priceRoom;
        private System.Windows.Forms.TextBox numberRoom;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox typeHotel;
        private System.Windows.Forms.TextBox starsHotel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox personsText;
        private System.Windows.Forms.ComboBox hotelsCombo;
    }
}