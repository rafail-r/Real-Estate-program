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
    internal partial class CustomersForm : Form
    {
        DBConnector conn = null;
        MainForm parentForm = null;

        internal CustomersForm(DBConnector c, MainForm mf)
        {
            InitializeComponent();
            parentForm = mf;
            conn = c;
        }

        private Boolean checkData()
        {
            if ((emailText.Text == "") || (nameText.Text == "") || (lastnameText.Text == "") || (countryText.Text == "") ||
                (cityText.Text == "") || (streetText.Text == "") || (streetnoText.Text == "") || (!phoneText.MaskCompleted) ||
                (!zipcodeText.MaskCompleted) || (!birthdateText.MaskCompleted))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void addCustButt_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkData())
                {
                    DBCustomer customer = new DBCustomer(nameText.Text, lastnameText.Text, DateTime.Parse(birthdateText.Text));
                    DBAddress address = new DBAddress(phoneText.Text, countryText.Text, cityText.Text, zipcodeText.Text, streetText.Text, streetnoText.Text);
                    DBEmail email = new DBEmail(emailText.Text);
                    conn.newCustomer(customer, address, email);
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
    }
}
