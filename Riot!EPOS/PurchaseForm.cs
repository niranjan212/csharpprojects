using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Riot_EPOS.Auxiliary.Stock;
using static Riot_EPOS.Auxiliary.Stock.StockFile;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Riot_EPOS
{
    //The purchase form is the final stage of the purchase flow, carrying over a cart from the main form, from where the user has the liberty to 
    //discard the cart, pay for it in 2 different ways, go back and add more items or cancel the transaction overall
    public partial class PurchaseForm : Form
    {
        const int LOWERLIMIT = 100000;
        const int UPPERLIMIT = 999999;
        StreamReader Reader;
        StreamWriter Writer;
        const String TempTxnFile = "ItemizedTransaction.txt";
        const String TransactionFile = "Transactions.txt";
        List<int> Transactions = new List<int>();


        public PurchaseForm()
        {
            InitializeComponent();          
        }

        private void CardPaymentButton_Click(object sender, EventArgs e)
        {
            MainForm MainForm = new MainForm();
            MainForm.Show();
            this.Hide();
        }

        private void CashPaymentButton_Click(object sender, EventArgs e)
        {
            MainForm MainForm = new MainForm();
            MainForm.Show();
            this.Hide();
        }

        private void Payment()
        {

            MessageBox.Show("Your Transaction has been Successful!", "Successful!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            MainForm MainForm = new MainForm();
            MainForm.Show();
            this.Hide();
        }

        private void AdminButton_Click(object sender, EventArgs e)
        {
            AdminForm AdminForm = new AdminForm();
            AdminForm.Show();    
            this.Hide();
        }

        private void AddItemsButton_Click(object sender, EventArgs e)
        {
            MainForm MainForm = new MainForm();
            MainForm.Show();
            this.Hide();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            MainForm MainForm = new MainForm();
            MainForm.Show();
            this.Hide();
        }

        private void CouponTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PurchaseForm_Load(object sender, EventArgs e)
        {
            try
            {
                Reader = File.OpenText(TempTxnFile);
                Writer = File.AppendText(TransactionFile);
                while (!Reader.EndOfStream)
                {
                    while (!Reader.EndOfStream)
                    {
                        ;
                    }   
                }
                ;
            }
            catch
            {
                MessageBox.Show("Unable to Access File!", "File Read Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Reader.Close();
            }
        }

        private int GenerateTransactionID()
        {
            Random Random = new Random();
            StreamReader Reader = File.OpenText(TransactionFile);
            while(!Reader.EndOfStream) {
                Transactions.Add(int.Parse(Reader.ReadLine()));
            }

            while (true)
            {
                bool GenerationError = false;
                int GeneratedID = Random.Next(LOWERLIMIT, UPPERLIMIT);

                foreach (int TxnID in Transactions)
                {
                    if (GeneratedID == TxnID)
                    {
                        GenerationError = true;
                        break;
                    }
                }
                if (GenerationError == false)
                {
                    return GeneratedID;
                }
            }
        }
    }
}
