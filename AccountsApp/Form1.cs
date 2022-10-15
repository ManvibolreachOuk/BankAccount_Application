using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountsApp
{
    public partial class Accounts : Form
    {
        //accounts is used to store list of account
        private List<Account> accounts = new List<Account>();
        public Accounts()
        {
            InitializeComponent();
        }
        // Used to enable and disable when radio button is check changes
        private void rbtnChecking_CheckedChanged(object sender, EventArgs e)
        {
            //when checking is checked
            if (rbtnChecking.Checked)
            {
                txtLimit.Enabled = true;
                txtInterest.Enabled = false;
            }
            //when savings is checked
            else
            {
                txtLimit.Enabled = false;
                txtInterest.Enabled = true;
            }                        
        }
        /// Used to create account when Create account button is clicked
        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            //using try-catch
            try
            {
                if (rbtnChecking.Checked)
                {
                    CheckingAccount myCheckingAccount = new CheckingAccount(int.Parse(txtNumber.Text),
                        txtName.Text,
                        double.Parse(txtBalance.Text),
                        double.Parse(txtLimit.Text));                   
                    accounts.Add(myCheckingAccount);
                }
                else
                {
                    
                    SavingsAccount mySavingsAccount = new SavingsAccount(int.Parse(txtNumber.Text),
                        txtName.Text,
                        double.Parse(txtBalance.Text),
                        double.Parse(txtInterest.Text));
                    accounts.Add(mySavingsAccount);
                }
                // show the total number of accounts stored in the accounts list
                MessageBox.Show($"The total number of Account is {accounts.Count}");
                //clear all textboxes
                ClearControls();
                

            }
            //show error message
            catch (FormatException)
            {
                MessageBox.Show($"Invalid Format!!");
            }
           
        }
        //reusable method to clear all controls at once
        private void ClearControls()
        {
            txtBalance.Text = "";
            txtInterest.Text = "";
            txtLimit.Text = "";
            txtName.Text = "";
            txtNumber.Text = "";
            rbtnChecking.Checked = true;
            rbtnSavings.Checked = false;
        }


    }
}
