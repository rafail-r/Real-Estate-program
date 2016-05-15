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
    internal partial class PaymentsForm : Form
    {

        MainForm parentForm = null;
        DBConnector conn = null;
        Dictionary<String, List<String>> paymentInfo = null;

        internal PaymentsForm(MainForm mf, DBConnector c)
        {
            InitializeComponent();
            parentForm = mf;
            conn = c;
            paymentButt.Enabled = false;
        }

        private void fillTexts()
        {
            try
            {
                reservationsCombo.DataSource = paymentInfo["info"];
                amountText.Text = paymentInfo["amount"][reservationsCombo.SelectedIndex];
            }
            catch (System.ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);
                resetTexts();
            }
        }

        private void resetTexts()
        {
            reservationsCombo.DataSource = null;
            amountText.Text = "";
        }

        private void connect()
        {
            Dictionary<String, String> retVal = conn.getCustomersName(phoneText.Text);
            if (retVal.Any())
            {
                customerText.Text = retVal["name"];
                paymentInfo = conn.getPaymentInfo(phoneText.Text);
                if (paymentInfo["bill_id"].Any())
                {
                    fillTexts();
                    paymentButt.Enabled = true;
                }
                else
                {
                    resetTexts();
                    paymentButt.Enabled = false; ;
                }
            }
            else
            {
                customerText.Text = "No customer found";
            }
        }

        private void phoneText_TextChanged(object sender, EventArgs e)
        {
            if (phoneText.MaskCompleted)
            {
                connect(); 
            }
            else
            {
                customerText.Text = "";
                paymentButt.Enabled = false;
            }
        }

        private void paymentButt_Click(object sender, EventArgs e)
        {
            Boolean retVal = conn.addPayment(paymentInfo["bill_id"][reservationsCombo.SelectedIndex]);
            if (retVal == true)
            {
                MessageBox.Show("Payment was successfull");
                this.Close();
            }
            else
            {
                MessageBox.Show("Payment was not successfull");
                connect();
            }
        }

        private void reservationsCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            amountText.Text = paymentInfo["amount"][reservationsCombo.SelectedIndex];
        }

        internal void setPhoneText(String phone)
        {
            phoneText.Text = phone;
        }
    }
}
