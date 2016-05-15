using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseProject
{
    internal partial class HotelsForm : Form
    {
        DBConnector conn = null;
        MainForm parentForm = null;

        internal HotelsForm(DBConnector c, MainForm mf)
        {
            InitializeComponent();
            parentForm = mf;
            conn = c;
        }

        private Boolean checkData()
        {
            if ((nameHotel.Text == "") || (typeHotel.Text == "") || (countryText.Text == "") ||
                (cityText.Text == "") || (streetText.Text == "") || (streetnoText.Text == "") || (!phoneText.MaskCompleted) ||
                (!zipcodeText.MaskCompleted))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkData())
                {
                    DBHotels hotel = new DBHotels(nameHotel.Text, typeHotel.Text, starsHotel.Text);
                    DBAddress address = new DBAddress(phoneText.Text, countryText.Text, cityText.Text, zipcodeText.Text, streetText.Text, streetnoText.Text);
                    if (conn.newHotel(hotel, address))
                    {
                        MessageBox.Show("Added hotel successfully");
                        parentForm.renewHotels();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong");
                    }
                }
                else
                {
                    MessageBox.Show("Please fill all data");
                }

            }
            catch (System.FormatException ex)
            {
                MessageBox.Show("Please fill all data properly");
                Console.WriteLine(ex.Data);
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }


        

        private void starsHotel_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int o;
                string p = starsHotel.Text;
                o = Int32.Parse(p);
                if (o > 5)
                {
                    starsHotel.Text = "";
                    MessageBox.Show("Please select from 0 to 5 stars");
                }
            }
            catch (System.FormatException ex)
            {
                Console.WriteLine(ex.Data);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            parentForm.Show();
            this.Close();
        }       
    }
}
