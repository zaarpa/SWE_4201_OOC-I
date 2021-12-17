using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pharmacy_Dependencies;

namespace PHARMACY_MANAGEMENT_SYSTEM
{
    public partial class Form1 : Form
    {
        List<MEDICINE> medicines = new List<MEDICINE>();
        ACCOUNT shop_account = new ACCOUNT();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addMedicineOnClick(object sender, EventArgs e)
        {
            string name = medicineNameTextBox.Text;
            int quantity = Convert.ToInt32(medicineQuantityTextBox.Text);
            double buyPrice = Convert.ToDouble(medicineBuyPriceTextBox.Text);

            bool med_exists = false;
            MEDICINE dummy_medicine = new MEDICINE();

            for (int i = 0; i < medicines.Count; i++)
            {
                if (name == medicines[i].medicineName && medicines[i].medicineAmount > 0)
                {
                    med_exists = true;


                }
            }

            if (med_exists == true)
            {
                for (int i = 0; i < medicines.Count; i++)
                {
                    if (name == medicines[i].medicineName)
                    {
                        medicines[i].medicineAmount += quantity;



                    }
                }

                MessageBox.Show("Medicine Bought.");

            }
            else
            {
                dummy_medicine.medicineName = name;
                dummy_medicine.medicineAmount = quantity;
                dummy_medicine.buyPrice = buyPrice;
                if (quantity * buyPrice < shop_account.accountBalance)
                {
                    medicines.Add(dummy_medicine);
                    shop_account.accountBalance -= quantity * buyPrice;
                    MessageBox.Show("Successfully Bought Medicine.");
                }
                else
                {
                    MessageBox.Show("Not enough fund.");
                }
            }
        }
            private void sellMedicineOnClick(object sender, EventArgs e)
            {
                string name = soldMedicineNameTextBox.Text;
                int amount = Convert.ToInt32(soldMedicineQuantityTextBox.Text);
                double sellPrice = Convert.ToDouble(soldMedicineSellPriceTextBox.Text);

                bool med_exists = false;


                for (int i = 0; i < medicines.Count; i++)
                {
                    if (name == medicines[i].medicineName && medicines[i].medicineAmount > 0)
                    {
                        med_exists = true;
                    }
                }

                if (med_exists == true)
                {
                    for (int i = 0; i < medicines.Count; i++)
                    {
                        if (name == medicines[i].medicineName)
                        {
                            medicines[i].medicineAmount -= amount;
                            shop_account.accountBalance += sellPrice * amount;

                        }
                    }

                    MessageBox.Show("Medicine Sold");

                }
                else
                {
                    MessageBox.Show("Medicine not available.");
                }
            }

            private void seeCurrentStockOnClick(object sender, EventArgs e)
            {
            string name = stockMedicineNameTextBox.Text;



            bool med_exists = false;


            for (int i = 0; i < medicines.Count; i++)
            {
                if (name == medicines[i].medicineName && medicines[i].medicineAmount > 0)
                {
                    med_exists = true;
                }
            }

            if (med_exists == true)
            {
                for (int i = 0; i < medicines.Count; i++)
                {
                    if (name == medicines[i].medicineName)
                    {
                        showStockListBox.Items.Clear();
                        showStockListBox.Items.Add(medicines[i].getMedicineInfo());
                        break; 
                    }
                }
            }
            else
            {
                MessageBox.Show("Medicine not available.");
            }
        }

            private void seeCurrentBalanceOnClick(object sender, EventArgs e)
            {
                currentBalanceLabel.Text = "BDT: " + Convert.ToString(shop_account.accountBalance);
            }
        }
    }
