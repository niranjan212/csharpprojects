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
using static Riot_EPOS.Auxiliary.Stock.StockFile;
using static Riot_EPOS.Auxiliary.Stock;

namespace Riot_EPOS
{
    //The Admin Form covers the Login, Stock Open and Close, and Report Generation Options, with the Report Generation Function
    //Taking place in it's own seperate form
    public partial class AdminForm : Form
    {
        StreamReader Reader;
        StreamWriter Writer;
        List<StockFile> Stock = new List<StockFile>();
        const String StockFile = "ActiveStockFile.txt";
        DateTime TransactionDate;

        public AdminForm()
        {
            InitializeComponent();
            StockFileMethods StockFileHandler = new StockFileMethods(StockFile);
            Stock = StockFileHandler.ReadItemsFromFile();
        }

        private void StockOpenButton_Click(object sender, EventArgs e)
        {
            Writer = File.AppendText(StockFile);
            Writer.WriteLine("The Stock has been opened for the date: "+ (TransactionDate.ToShortDateString()));
            Writer.Close();
        }

        private void StockCloseButton_Click(object sender, EventArgs e)
        {
            Writer = File.AppendText(StockFile);
            Writer.WriteLine("The Stock has been closed for the date: " + (TransactionDate.ToShortDateString()));
            Writer.Close();
        }

        private void GenerateStockButton_Click(object sender, EventArgs e)
        {
            SalesReportForm SalesReportForm = new SalesReportForm();
            SalesReportForm.Show();
            this.Close();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            MainForm MainForm = new MainForm();
            MainForm.Show();
            this.Close();
        }

        private void GenerateDailySalesButton_Click(object sender, EventArgs e)
        {
            SalesReportForm SalesReportForm = new SalesReportForm();
            SalesReportForm.Show();
            this.Close();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            LoginForm LoginForm = new LoginForm();
            LoginForm.Show();
            this.Close();
        }
    }
}
