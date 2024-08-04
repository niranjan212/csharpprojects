using Riot_EPOS.Auxiliary;
using System;
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

namespace Riot_EPOS
{
    /*Name: Niranjan Krishnan Devaraj
     * ID: 23105484
     * This program has been designed as POS System for a clothing brand, RIOT!, who have a variety of t shirts in different sizes and colours.
     * This program has been written such that a normal user will be able to check out on their own on it, while admin staff who can log in to
     * the system can access reports and additional features exclusive to the workers at RIOT. There are several forms in this project: A MainForm,
     * an AdminForm, a LoginForm, a PurchaseForm, and a SalesReportForm, and the data is managed through a system of files and collections
     */
    public partial class MainForm : Form
    {
        //Constants and Global Variables
        const decimal ZeroNumeral = 0.0m;
        const String StockFile = "ActiveStockFile.txt";
        const String TempTxnFile = "ItemizedTransaction.txt";
        List<StockFile> Stock = new List<StockFile>();
        List<StockFile> Cart = new List<StockFile>();
        DateTime TransactionDate;
        StockFile Holder = null;
        int[] CurrentSelections = { -1, -1, -1 };
        int Quantity;
        StreamWriter Writer;

        //In the constructor, we're using an auxiliary class which we've defined for the purpose of easing file read and text output operations for the Stock file
        public MainForm()
        {
            InitializeComponent();
            StockFileMethods StockFileHandler = new StockFileMethods(StockFile);
            Stock = StockFileHandler.ReadItemsFromFile();
            List<String> DistinctItems = StockFileHandler.ReadUniqueProductsFromFile();
            List<String> DistinctSizes = StockFileHandler.ReadUniqueSizesFromFile();
            List<String> DistinctColours = StockFileHandler.ReadUniqueColoursFromFile();

            foreach (String Item in DistinctItems)
            {
                ItemListbox.Items.Add(Item);
            }

            foreach (String Colour in DistinctColours)
            {
                ColourListbox.Items.Add(Colour);
            }

            foreach (String Size in DistinctSizes)
            {
                SizeListbox.Items.Add(Size);
            }
        }

        //This method keeps track of user choice, and alters the price labels accordingly. The user has an option to add the selected item to the holding cart
        private void SomeItemSelected()
        {
            try
            {
                if (ItemListbox.SelectedIndex != -1 && ColourListbox.SelectedIndex != -1 && SizeListbox.SelectedIndex != -1)
                {
                    CurrentSelections[0] = ItemListbox.SelectedIndex;
                    CurrentSelections[1] = ColourListbox.SelectedIndex;
                    CurrentSelections[2] = SizeListbox.SelectedIndex;
                    foreach (StockFile Item in Stock)
                    {
                        if (Item.Name.Equals(ItemListbox.SelectedItem))
                        {
                            if (Item.Colour.Equals(ColourListbox.SelectedItem))
                            {
                                if (Item.Size.Equals(SizeListbox.SelectedItem))
                                {
                                    if (!int.TryParse(QuantityTextbox.Text, out Quantity))
                                    {
                                        MessageBox.Show("Please Choose a Valid Whole Number", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                    Holder = Item;
                                    Holder.Cost = Quantity * Item.DiscountedPrice;
                                    Holder.Quantity = Quantity;
                                    TotalPriceValueLabel.Text = (Quantity * Item.DiscountedPrice).ToString("N2") + " EUR";
                                    UnitPriceValueLabel.Text = Item.DiscountedPrice.ToString("N2") + " EUR";
                                    TaxValueLabel.Text = Item.Tax.ToString("N2") + " EUR";
                                    SavingsValueLabel.Text = (Item.Cost - Item.DiscountedPrice).ToString("N2") + " EUR";
                                    OriginalPriceValueLabel.Text = (Quantity * Item.Cost).ToString("N2") + " EUR";
                                }
                            }
                        }
                    }
                }
            }
            catch
            {
                AvailabilityDisclaimerLabel.Visible = true;
            }
        }

        //This method adds the item selected into the holding cart, where it's held until the cart is finalized
        private void AddItemButton_Click(object sender, EventArgs e)
        {
            Cart.Add(Holder);
            TransactionListbox.Items.Add(Holder.ToString());
            decimal.TryParse(CartValueLabel.Text, out decimal OriginalTotalValue);
            CartValueLabel.Text = (Holder.Cost + OriginalTotalValue).ToString("N2");
            decimal.TryParse(CartTaxValueLabel.Text, out decimal OriginalTotalTax);
            CartTaxValueLabel.Text = (Holder.Tax + OriginalTotalTax).ToString("N2");
            decimal.TryParse(CartSavingsValueLabel.Text, out decimal OriginalSavings);
            CartSavingsValueLabel.Text = (Holder.Savings + OriginalSavings).ToString("N2");
        }

        //Methods that detect when the listbox choice has changed
        private void ItemListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(ItemListbox.SelectedIndex == CurrentSelections[0]))
                SomeItemSelected();
        }

        private void ColourListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(ItemListbox.SelectedIndex == CurrentSelections[1]))
                SomeItemSelected();
        }

        private void SizeListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(ItemListbox.SelectedIndex == CurrentSelections[2]))
                SomeItemSelected();
        }

        //This button adds one unit quantity to the item selected, and shows a message if the availability has run out or if its an invalid entry
        private void AddButton_Click(object sender, EventArgs e)
        {
            int AddClick;
            if (int.TryParse(QuantityTextbox.Text, out AddClick))
            {
                if (CheckAvailability(AddClick))
                {
                    QuantityTextbox.Text = (++AddClick).ToString();
                    SubtractButton.Enabled = true;
                    //SomeItemSelected();
                }
                else
                    StockWarningLabel.Visible = true;
            }
            else
                MessageBox.Show("Please Choose a Valid Whole Number", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        //This button subtracts one unit quantity to the item selected, and shows a message if the availability has run out or if its an invalid entry
        private void SubtractButton_Click(object sender, EventArgs e)
        {
            int MinusClick;
            if (int.TryParse(QuantityTextbox.Text, out MinusClick) && !(MinusClick == 1))
            {
                QuantityTextbox.Text = (--MinusClick).ToString();
                //SomeItemSelected();
            }
            else
            {
                SubtractButton.Enabled = false;
                MessageBox.Show("Please Remove Item If Not Needed", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //This button changes the current unit quantity according to the text entered to the item selected, and shows a message if the a
        //vailability has run out or if its an invalid entry
        private void QuantityTextbox_TextChanged(object sender, EventArgs e)
        {
            int Change;
            if (int.TryParse(QuantityTextbox.Text, out Change))
            {
                if (CheckAvailability(Change))
                {
                    SubtractButton.Enabled = true;
                    SomeItemSelected();
                }
            }
            else
                MessageBox.Show("Please Choose a Valid Whole Number", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        //This method checks stock availability of the selected product before being able to add it to the cart
        private Boolean CheckAvailability(int Quantity)
        {
            if (Holder == null)
                return true;
            else if (Holder.StockLevel > Quantity)
                return true;
            else
                return false;
        }

        //This method removes item from the holding cart
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            TransactionListbox.Items.Remove(TransactionListbox.SelectedItem);
            Cart.RemoveAt(Cart.Count - 1);
        }

        //This button clears all the selections across the listboxes, and the price labels
        private void ClearButton_Click(object sender, EventArgs e)
        {
            QuantityTextbox.Text = "1";
            ItemListbox.SelectedIndex = -1;
            ColourListbox.SelectedIndex = -1;
            SizeListbox.SelectedIndex = -1;
            TotalPriceValueLabel.Text = UnitPriceValueLabel.Text = TaxValueLabel.Text = SavingsValueLabel.Text = OriginalPriceValueLabel.Text = ZeroNumeral.ToString("N2");
        }

        //This button clears the holding cart entirely
        private void ClearCartButton_Click(object sender, EventArgs e)
        {
            TransactionListbox.Items.Clear();
            Cart.Clear();
            ClearButton_Click(sender, e);
        }

        //This button processes the holding cart, stores it in a while and opens the next relevant form
        private void ProceedButton_Click(object sender, EventArgs e)
        {
            if (Cart.Count > 0 && TransactionListbox.Items.Count > 0)
            {
                Writer = File.AppendText(TempTxnFile);
                for (int i = 0; i < Cart.Count; i++)
                {
                    Writer.WriteLine(Cart[i].Id.ToString());
                    Writer.WriteLine(TransactionDate.ToShortDateString());
                    Writer.WriteLine(Cart[i].DiscountedPrice.ToString());
                    Writer.WriteLine(Cart[i].Quantity.ToString());
                }
                Writer.Close();
                PurchaseForm Purchase = new PurchaseForm();
                Purchase.Show();
                this.Hide();
            }
        }

        //This button closes the application
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //This button takes the user to the Admin Controls
        private void AdminButton_Click(object sender, EventArgs e)
        {
            AdminForm Admin = new AdminForm();
            Admin.Show();
            this.Hide();
        }
    }
}
 
