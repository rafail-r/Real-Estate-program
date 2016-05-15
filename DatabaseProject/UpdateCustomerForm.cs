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
    internal partial class UpdateCustomerForm : Form
    {
        MainForm parentForm = null;
        DBConnector conn = null;
        String cust_id;
        Dictionary<String, String> cust;

        internal UpdateCustomerForm(DBConnector c, MainForm mf)
        {
            InitializeComponent();
            parentForm = mf;
            conn = c;
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
        }


        private void phoneTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (phoneTextBox1.MaskCompleted)
            {
                connecting();
            }
        }

        private void connecting()
        {
            cust = conn.getCustomersName(phoneTextBox1.Text);
            if (cust.Any())
            {
                phoneText.Text = cust["phone"];
                countryText.Text = cust["country"];
                cityText.Text = cust["city"];
                zipcodeText.Text = cust["zipcode"];
                streetnoText.Text = cust["streetNo"];
                streetText.Text = cust["street"];
                nameText.Text = cust["firstname"];
                lastnameText.Text = cust["lastname"];
                birthdateText.Text = DateTime.Parse(cust["birthdate"]).ToString("dd-MM-yyyy");
                cust_id = cust["id"];
                groupBox1.Enabled = true;
                groupBox2.Enabled = true;
            }
            else
            {
                nameText.Text = "No customer found";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            parentForm.Show();
            this.Close();
        }

        private Boolean checkData()
        {
            if ((nameText.Text == "") || (lastnameText.Text == "") || (countryText.Text == "") ||
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

        private void button2_Click(object sender, EventArgs e)
        {
            DBCustomer customer = new DBCustomer(nameText.Text, lastnameText.Text, DateTime.Parse(birthdateText.Text));
            customer.addressId = cust["addrid"];
            DBAddress addr = new DBAddress(phoneText.Text, countryText.Text, cityText.Text, zipcodeText.Text, streetText.Text, streetnoText.Text);
            try
            {
                if (checkData())
                {
                    conn.updateCustomer(customer, addr);
                    DBEmail email = new DBEmail(emailText.Text);
                    email.customerId = cust_id;
                    if (conn.isEmailUnique(email.emails))
                    {
                        conn.addEmail(email);
                    }
                    else
                    {
                        MessageBox.Show("You didn't add new mail!");
                    }
                }
                else
                {
                    MessageBox.Show("Fill all data!");
                }
            }
            catch (System.FormatException ex)
            {
                MessageBox.Show("Please fill all data properly");
                Console.WriteLine(ex.Data);
            }
            this.Close();
        }

        private void emailText_TextChanged(object sender, EventArgs e)
        {
            
        }

    }
}
