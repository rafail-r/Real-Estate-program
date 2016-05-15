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
    internal partial class RoomsForm : Form
    {
        MainForm parentForm = null;
        DBConnector conn = null;
        Dictionary<String, List<String>> hotels = null;
        RoomsForm2 roomsForm2 = null;

        internal RoomsForm(MainForm mf, DBConnector c,Dictionary<String, List<String>> h)
        {
            InitializeComponent();
            parentForm = mf;
            conn = c;
            hotels = h;
            hotelsCombo.DataSource = hotels["name"];

            
        }

        private Boolean checkData()
        {
            if ((typeRoom.Text == "") || (priceRoom.Text == "") || (numberRoom.Text == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkData())
                {
                    DBRoom room = new DBRoom(numberRoom.Text, typeRoom.Text, priceRoom.Text,personsText.Text);
                    if (conn.addRooms(room, hotels["id"][hotelsCombo.SelectedIndex]))
                    {
                        typeRoom.Text = "";
                        priceRoom.Text = "";
                        numberRoom.Text = "";
                        personsText.Text = "";
                        MessageBox.Show("Added rooms!");
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong!");
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

        private void FnumberRoom_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            roomsForm2 = new RoomsForm2(this, conn, hotels["id"][hotelsCombo.SelectedIndex]);
            roomsForm2.Show();
            this.Hide();
        }
        internal void deleteRoomForm2(RoomsForm2 rf2)
        {
            if (roomsForm2 == rf2)
            {
                roomsForm2 = null;
            }
        }



        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void fillTexts()
        {
            typeHotel.Text = hotels["type"][hotelsCombo.SelectedIndex];
            starsHotel.Text = hotels["stars"][hotelsCombo.SelectedIndex];
        }

        private void hotelsCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillTexts();
        }

    }
}
