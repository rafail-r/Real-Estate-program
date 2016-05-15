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
    internal partial class RoomsForm2 : Form
    {
        RoomsForm parentForm = null;
        DBConnector conn = null;
        String id_h;
        
        internal RoomsForm2(RoomsForm mf, DBConnector c, String id)
        {
            InitializeComponent();
            parentForm = mf;
            conn = c;
            id_h = id;
            cone();
        }

        internal void cone()
        {
            Dictionary<String, List<String>> rooms = conn.getRoomsInfo(id_h);
            hotelsCombo.DataSource = rooms["number"];
            listBox2.DataSource = rooms["data"];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            parentForm.Show();
            parentForm.deleteRoomForm2(this);
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Sure??", "Delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (conn.deleteRoom(hotelsCombo.Text))
                {
                    MessageBox.Show("Deleted!");
                }
                else
                {
                    MessageBox.Show("This number room is already reserved!!!!!Contact with customer first!!!!!!!");
                }
            }
            parentForm.Show();
            this.Close();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
