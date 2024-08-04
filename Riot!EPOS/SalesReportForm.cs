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

namespace Riot_EPOS
{
    //The sales report form's exclusive purpose to be a viewing form for the summary reports and stock reports. There's a save, clear and options for the user
    //to go back to either the EPOS menu or the admin menu, or exit the program.
    public partial class SalesReportForm : Form
    {
        const int LOWERLIMIT = 100000;
        const int UPPERLIMIT = 999999;
        StreamReader Reader;
        StreamWriter Writer;
        const String TempTxnFile = "ItemizedTransaction.txt";
        const String TargetFile = "Sales Report.txt";
        List<int> Transactions = new List<int>();

        public SalesReportForm()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            StreamWriter Writer = new StreamWriter(TargetFile);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            DailySalesReportListbox.Items.Clear();
        }

        private void BackToAdminButton_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm();
            adminForm.Show();
            this.Close();
        }

        private void BackToBillingButton_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Close();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SalesReportForm_Load(object sender, EventArgs e)
        {

        }
    }
}
