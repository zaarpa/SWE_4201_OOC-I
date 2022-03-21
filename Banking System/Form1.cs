using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankingSystemDependencies;

namespace Banking_System
{
    public partial class Form1 : Form
    {
        public BANK bank = new BANK();
        public Form1()
        {
            InitializeComponent();
        }

        private void createAccountOnClick(object sender, EventArgs e)
        {
            string type = createAccountComboBox.Text;
           
                if (type == "SAVINGS")
                {
                    SAVINGS dummy_savings = new SAVINGS();
                    dummy_savings.accNo = Convert.ToString(bank.acc);
                    dummy_savings.accNo += dummy_savings.suffix;
                    dummy_savings.accOwner = nameTextbox.Text;
                    dummy_savings.contact = contactTextBox.Text;
                    bank.acc++;
                    bank.savingsAccounts.Add(dummy_savings);
                MessageBox.Show("Account Created.");
                MessageBox.Show(dummy_savings.accNo);


            }
                else if (type == "LOAN")
                {
                    LOAN dummy_loan = new LOAN();
                    dummy_loan.accNo = Convert.ToString(bank.acc);
                    dummy_loan.accNo += dummy_loan.suffix;
                    dummy_loan.accOwner = nameTextbox.Text;
                    dummy_loan.contact = contactTextBox.Text;
                    bank.acc++;
                    bank.loanAccounts.Add(dummy_loan);
                MessageBox.Show("Account Created.");
                MessageBox.Show(dummy_loan.accNo);
            }
                else
                {
                    CURRENT dummy_current = new CURRENT();
                    dummy_current.accNo = Convert.ToString(bank.acc);
                    dummy_current.accNo += dummy_current.suffix;
                    dummy_current.accOwner = nameTextbox.Text;
                    dummy_current.contact = contactTextBox.Text;
                    bank.acc++;
                    bank.currentAccounts.Add(dummy_current);
                MessageBox.Show("Account Created.");
                MessageBox.Show(dummy_current.accNo);
            }
   

            
        }

        private void transactionOnClick(object sender, EventArgs e)
        {
            string accNo = accountNoTextBox.Text;
            string accType = accountTypeComboBox.Text;
            int amount = Convert.ToInt32(amountTextBox.Text);
            string action = actionCombobox.Text;
            if (accType == "SAVINGS")
            {
                for (int i = 0; i < bank.savingsAccounts.Count; i++)
                {
                    if (accNo == bank.savingsAccounts[i].accNo)
                    {
                        if (action == "DEPOSIT")
                        {
                            bank.savingsAccounts[i].DEPOSIT(amount);
                        }
                        else if (action == "WITHDRAW")
                        {
                            bank.savingsAccounts[i].WITHDRAW(amount);
                        }
                    }
                }
            }
            else if (accType == "LOAN")
            {
                for (int i = 0; i < bank.loanAccounts.Count; i++)
                {
                    if (accNo == bank.loanAccounts[i].accNo)
                    {
                        if (action == "DEPOSIT")
                        {
                            bank.loanAccounts[i].DEPOSIT(amount);
                        }
                        else
                        {
                            bank.loanAccounts[i].Loan(amount);
                        }

                    }
                }
            }
            else
            {
                for (int i = 0; i < bank.currentAccounts.Count; i++)
                {
                    if (accNo == bank.currentAccounts[i].accNo)
                    {
                        if (action == "DEPOSIT")
                        {
                            bank.currentAccounts[i].DEPOSIT(amount);
                        }
                        else if (action == "WITHDRAW")
                        {
                            bank.currentAccounts[i].WITHDRAW(amount);
                        }
                    }
                }
            }
            MessageBox.Show("Transaction Successful.");
        }

        private void accountInfoOnClick(object sender, EventArgs e)
        {
            string accNo = checkAccNoTextBox.Text;
            showTransactionListbox.Items.Clear();
            for (int i = 0; i < bank.currentAccounts.Count; i++)
            {
                if (accNo == bank.currentAccounts[i].accNo)
                {
                    showTransactionListbox.Items.Add(bank.currentAccounts[i].GETINFO());
                }
            }
            for (int i = 0; i < bank.loanAccounts.Count; i++)
            {
                if (accNo == bank.loanAccounts[i].accNo)
                {
                    showTransactionListbox.Items.Add(bank.loanAccounts[i].GETINFO());
                }
            }
            for (int i = 0; i < bank.savingsAccounts.Count; i++)
            {
                if (accNo == bank.savingsAccounts[i].accNo)
                {
                    showTransactionListbox.Items.Add(bank.savingsAccounts[i].GETINFO());
                }
            }
        }
    }
}
