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

namespace Invest4UWebApp
{
    /* Name: Niranjan Krishnan Devaraj
     * ID: 23105484
     * Project: Invest4U, an investment app designed for an Employee of Mad4Money Bank Corp. The Employee is able to
     * Log in as the admin with a set password, calculate and invest money for their client between 4 set terms, with
     * bonuses and gainful interest rate applying based on investment amount. The employee or the manager can also view
     * a Summary of all transactions, with Average Investment and Average Term highlighted, and is also able to search
     * for specific transaction(s) based on email id, date, or transaction ID. Further in depth functioning will be 
     * explained in the appropriate junctures.
     */
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        //4 terms of investment periods, 1,3,5,and 10 years respectively
        const int Term1 = 1, Term2 = 3, Term3 = 5, Term4 = 10;
        //random number generator upper and lower limits
        const int LowerLimit = 100000, UpperLimit = 999999;
        //password attempt limiter
        const int MAXTRIES = 3;
        //form size coordinates for screen changes, with 3 different pairs. Note: Scaling affects the coordinates, so might not be fully accurate on all displays
        const int Screen1X = 311, Screen1Y = 508, Screen2X = 666, Screen2Y = 361, Screen3X = 615, Screen3Y = 562;
        //interest rates for investments <= 1000000 for 4 different terms
        const decimal Tier1InterestTerm1 = 0.005000m, Tier1InterestTerm2 = 0.006250m, Tier1InterestTerm3 = 0.007125m, Tier1InterestTerm4 = 0.011250m;
        //interest rates for investments > 1000000 for 4 different terms
        const decimal Tier2InterestTerm1 = 0.006000m, Tier2InterestTerm2 = 0.007250m, Tier2InterestTerm3 = 0.008125m, Tier2InterestTerm4 = 0.012500m;
        //password and username of the employee
        const string PASSWORD = "ShowMeTheMoney#", USERNAME = "admin";
        //form header strings for different scenarios
        const string Initial = "Hello!", Investment = "Enter Investment Amount: ", Summary = "Summary", SearchResults = "Search Results", ChooseTerm = "Choose Term", Finalize = "Finalize";
        //global variables for transactiondate, id, passwordattempt counter, and finance variables for investment term, investment, cumulative amount,
        //compound interest, name of investor, contact, email and a boolean flag to differentiate between the investment interest rate applicable
        //(could be calculated everytime but is more useful when available as on demand)
        DateTime TransactionDate;
        int TransactionID, Attempts = 1, FinalTerm;
        decimal FinalCumulativeAmount = 0.0m, FinalInvestedAmount = 0.0m, FinalInterest, FinalCompoundInterest = 0.0m;
        string FinalName, FinalContact, FinalEmailID;
        bool LowInterestIndicator = false;

        //Initializing the Form with the appropriate form size and changing form title
        private void MainForm_Load(object sender, EventArgs e)
        {
            FormResizer(Screen1X, Screen1Y);
            this.Text = Initial;
        }

        //LOGIN BUTTON: The login button takes care of verifying the credentials entered. If they match, the screen is changed to the Investment Screen
        //If they don't, the user is left to try for 3 times, before the application exits.There's input validation done regarding the validity of the 
        //Username and Password entered, and a ProceedFlag maintained to indicate if we can proceed. Changes form text
        private void LoginButton_Click(object sender, EventArgs e)
        {
            string TryUsername = UsernameTextBox.Text;
            string TryPassword = PasswordTextBox.Text;
            bool ProceedFlag = true;
            if (TryUsername.Length == 0)
            {
                MessageBox.Show("Please Enter Username to Proceed!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UsernameTextBox.Focus();
                UsernameTextBox.SelectAll();
                ProceedFlag = false;
            }
            if (TryPassword.Length == 0)
            {
                MessageBox.Show("Please Enter Password to Proceed!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PasswordTextBox.Focus();
                PasswordTextBox.SelectAll();
                ProceedFlag = false;
            }
            if (ProceedFlag)
            {
                if (TryPassword.Equals(PASSWORD) && TryUsername.Equals(USERNAME))
                {
                    LoginPanel.Visible = false;
                    this.Text = Investment;
                    InvestmentPanel.Visible = true;
                    AmountTextBox.Focus();
                }
                else if (Attempts < MAXTRIES)
                {
                    Attempts++;
                    LoginWarningLabel.Visible = true;
                    LoginWarningLabel.Text = "Incorrect password!\nYou've got " + (MAXTRIES - Attempts + 1) + " More Attempts!";
                    PasswordTextBox.Text = string.Empty;
                    PasswordTextBox.Focus();
                    PasswordTextBox.SelectAll();
                }
                else
                {
                    MessageBox.Show("You've run out of attempts!", "Critical Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
        }

        //CLEAR BUTTON : The clear button resets whatever was input. It doesn't reset the counter, however.
        private void ClearLoginButton_Click(object sender, EventArgs e)
        {
            ResetAll();
            LoginPanel.Visible = true;
            UsernameTextBox.Focus();
        }

        //EXIT BUTTON : The exit button triggers a confirmation dialog box, on confirming which, the user can exit the application with no changes saved
        private void ExitLoginButton_Click(object sender, EventArgs e)
        {
            DialogResult ExitResult = MessageBox.Show("Are you sure?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (ExitResult.Equals(DialogResult.Yes))
                this.Close();
            else
                ResetAll();
            LoginPanel.Visible = true;
            UsernameTextBox.Focus();
        }

        //DISPLAY BUTTON : The display button is the home screen, where the employee can choose to invest, or view summary, or search records
        //The data for the next screen is loaded in this method upon input validation by calling the CalculateTerms method,
        //and the screen is resized. The form title is changed
        private void DisplayButton_Click(object sender, EventArgs e)
        {
            decimal InvestmentAmount;
            if (decimal.TryParse(AmountTextBox.Text, out InvestmentAmount) && InvestmentAmount > 0)
            {
                FinalInvestedAmount = InvestmentAmount;
                CalculateTerms(InvestmentAmount);

                FormResizer(Screen2X, Screen2Y);
                this.Text = ChooseTerm;
                ProceedPanel.Visible = true;
                InvestmentPanel.Visible = false;
            }
            else
            {
                AmountWarningLabel.Visible = true;
                AmountTextBox.SelectAll();
                AmountTextBox.Focus();
            }
        }

        //CLEAR AMOUNT BUTTON : The Clear button resets the amount entered, and focuses on the amount box, to allow for accidental input correction
        private void ClearAmountButton_Click(object sender, EventArgs e)
        {
            AmountWarningLabel.Visible = false;
            AmountTextBox.Text = string.Empty;
            AmountTextBox.Focus();
        }

        //EXIT BUTTON : The Exit Button warns the user about losing progress before allowing them to quit without saving progress. On choosing no, the 
        //value entered is cleared and refocused.
        private void ExitInvestmentButton_Click(object sender, EventArgs e)
        {
            DialogResult ExitResult = MessageBox.Show("Are you sure? You will lose all progress!", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (ExitResult.Equals(DialogResult.Yes))
                this.Close();
            else
                ResetAll();
            InvestmentPanel.Visible = true;
            AmountTextBox.Focus();
            AmountTextBox.SelectAll();
        }

        //PROCEED BUTTON : The proceed button finalizes the term that the user chooses, and proceeds to the final transaction screen. It calculates all
        //the financial information necessary, such as term, interest, cumulative amount, compound interest and gets it ready for later use. There's input
        //validation done on whether any terms are picked at all. The form title is changed.
        private void ProceedButton_Click(object sender, EventArgs e)
        {
            bool ProceedFlag = false;
            if (Term1Radio.Checked)
            {
                FinalTerm = Term1;
                if (LowInterestIndicator)
                    FinalInterest = Tier1InterestTerm1;
                else
                    FinalInterest = Tier2InterestTerm1;
                ProceedFlag = true;
            }
            else if (Term2Radio.Checked)
            {
                FinalTerm = Term2;
                if (LowInterestIndicator)
                    FinalInterest = Tier1InterestTerm2;
                else
                    FinalInterest = Tier2InterestTerm2;
                ProceedFlag = true;
            }
            else if (Term3Radio.Checked)
            {
                FinalTerm = Term3;
                if (LowInterestIndicator)
                    FinalInterest = Tier1InterestTerm3;
                else
                    FinalInterest = Tier2InterestTerm3;
                ProceedFlag = true;
            }
            else if (Term4Radio.Checked)
            {
                FinalTerm = Term4;
                if (LowInterestIndicator)
                    FinalInterest = Tier1InterestTerm4;
                else
                    FinalInterest = Tier2InterestTerm4;
                ProceedFlag = true;
            }
            else
            {
                RadioWarningLabel.Visible = true;
            }

            if (ProceedFlag)
            {
                FinalCompoundInterest = (decimal)CalculateCompountInterest(FinalTerm, FinalInterest, FinalInvestedAmount);
                TransactionID = GenerateTransactionID();
                TransactionIDLabel.Text += TransactionID.ToString();
                TransactionDate = DateTime.Now;
                DateLabel.Text += TransactionDate.ToShortDateString();

                this.Text = Finalize;
                TransactionGroupBox.Visible = true;
                ProceedPanel.Visible = false;
            }
        }

        //The cancel button here takes the user back to the investment screen, while resetting all progress, changing form title and resizing the screen in the process
        private void CancelInvestmentButton_Click(object sender, EventArgs e)
        {
            DialogResult ExitResult = MessageBox.Show("Are you sure? You will lose all progress!", "Cancel Transaction!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (ExitResult.Equals(DialogResult.Yes))
            {
                ResetAll();
                InvestmentPanel.Visible = true;

                this.Text = Investment;
                FormResizer(Screen1X, Screen1Y);
                AmountTextBox.Focus();
                AmountTextBox.SelectAll();
            }
        }

        //SUBMIT BUTTON : this button is responsible for writing all the transactional info to the external file, and does it with the help of streamwriter and streamreader
        //This button marks the end of the flow, and after this the user is allowed to either exit or continue, with continue taking them back to the investment screen
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            bool ProceedFlag = true;
            if (NameTextBox.Text.Length == 0)
            {
                MessageBox.Show("Enter a value in the Name field", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TransactionWarningLabel.Visible = true;
                NameTextBox.Focus();
                ProceedFlag = false;
            }
            if (ContactTextBox.Text.Length == 0)
            {
                MessageBox.Show("Enter a valid number in the Contact field", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TransactionWarningLabel.Visible = true;
                if (ProceedFlag)
                    ContactTextBox.Focus();
                ProceedFlag = false;
            }
            if (EmailTextBox.Text.Length == 0 || !EmailTextBox.Text.Contains("@") || !EmailTextBox.Text.Contains("."))
            {
                MessageBox.Show("Enter a valid ID in the Email field", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TransactionWarningLabel.Visible = true;
                if (ProceedFlag)
                    EmailTextBox.Focus();
                ProceedFlag = false;
            }
            if (ProceedFlag)
            {
                FinalName = NameTextBox.Text;
                FinalContact = ContactTextBox.Text;
                FinalEmailID = EmailTextBox.Text;
                string ConfirmationText = "Investment Details: \n" +
                                          "Name: " + FinalName + "\n" + "Contact Number: " + FinalContact + "\n" +
                                          "Email: " + FinalEmailID + "\n" + "Term: " + FinalTerm + "\n" +
                                          "Invested Amount: " + FinalInvestedAmount.ToString("C2") + "\n" +
                                          "Interest Rate: " + FinalInterest.ToString() + "%\n" +
                                          "Interest Amount: " + FinalCompoundInterest.ToString("C2") + "\n";
                if (FinalInvestedAmount <= 1000000)
                {
                    FinalCumulativeAmount = FinalInvestedAmount + FinalCompoundInterest;
                    ConfirmationText += "Total Amount: " + FinalCumulativeAmount.ToString("C2") + "\n\nProceed with next investment?";
                }
                else
                {
                    FinalCumulativeAmount = FinalInvestedAmount + FinalCompoundInterest + 25000;
                    ConfirmationText += "Total Amount: " + FinalCumulativeAmount.ToString("C2") + "\nBonus of 25,000 is added \n\nProceed with next investment?";
                }

                try
                {
                    StreamWriter Writer = File.AppendText("Invest4UTransactionTable.txt");
                    Writer.WriteLine(TransactionID);
                    Writer.WriteLine(TransactionDate.ToShortDateString());
                    Writer.WriteLine(FinalEmailID);
                    Writer.WriteLine(FinalName);
                    Writer.WriteLine(FinalContact);
                    Writer.WriteLine(FinalTerm);
                    Writer.WriteLine(FinalInterest);
                    Writer.WriteLine(FinalInvestedAmount);
                    Writer.WriteLine(FinalCompoundInterest);
                    Writer.WriteLine(FinalCumulativeAmount);
                    Writer.Close();

                    DialogResult ContinueDialog = MessageBox.Show(ConfirmationText, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (ContinueDialog == DialogResult.Yes)
                    {
                        ResetAll();

                        this.Text = Investment;
                        FormResizer(Screen1X, Screen1Y);
                        InvestmentPanel.Visible = true;
                        AmountTextBox.Focus();
                    }
                    else if (ContinueDialog == DialogResult.No)
                    {
                        this.Close();
                    }
                }
                catch
                {
                    DialogResult CrashDialog = MessageBox.Show("Unable to Write to File due to Memory Error! Exiting Process!", "Critical Write Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (CrashDialog == DialogResult.OK)
                        this.Close();
                }
            }
        }

        //CANCEL BUTTON : this resets everything, and cancels the progress so far, and takes the user back to the investment screen
        private void CancelTransactionButton_Click(object sender, EventArgs e)
        {
            DialogResult ExitResult = MessageBox.Show("Are you sure? You will lose all progress!", "Cancel Transaction!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (ExitResult.Equals(DialogResult.Yes))
            {
                ResetAll();

                this.Text = Investment;
                FormResizer(Screen1X, Screen1Y);
                InvestmentPanel.Visible = true;
                AmountTextBox.Focus();
                AmountTextBox.SelectAll();
            }
        }

        //The Summary Button displays Financial data such as investment amount, term, interest, and amount
        //for all the transactions that have been recorded on the file on a listbox

        private void SummaryButton_Click(object sender, EventArgs e)
        {
            StreamReader Reader;
            try
            {
                Reader = File.OpenText("Invest4UTransactionTable1.txt");
                PrepareSummary(ref Reader);
            }
            catch
            {
                MessageBox.Show("Unable to Access File! Please Locate File Manually", "File Read Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (OpenFile.ShowDialog() == DialogResult.OK)
                {
                    Reader = File.OpenText(OpenFile.FileName);
                    PrepareSummary(ref Reader);
                }
            }
        }

        //The Back button takes the user back to the investment window, changing form title and resizing the window in the process
        private void BackSummaryButton_Click(object sender, EventArgs e)
        {
            ResetAll();

            this.Text = Investment;
            FormResizer(Screen1X, Screen1Y);
            InvestmentPanel.Visible = true;
        }

        //This exit button closes the application from the summary screen, after giving the user an option to confirm their choice
        private void ExitSummaryButton_Click(object sender, EventArgs e)
        {
            DialogResult ExitResult = MessageBox.Show("Are you sure?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (ExitResult.Equals(DialogResult.Yes))
                this.Close();
        }

        //The Search button takes the user to the search screen, resizing the form in the process
        private void SearchButton_Click(object sender, EventArgs e)
        {
            ResetAll();

            FormResizer(Screen3X, Screen3Y);
            this.Text = SearchResults;
            SearchListBox.Items.Clear();
            SearchGroupBox.Visible = true;
        }

        // EmailSearchTextBox_TextChanged, DateSearchTextBox_TextChanged, and TransactionIDSearchTextBox_TextChanged ensures that
        // the user can only enter one search term, by emptying the other options when there's fresh input in one of them 
        private void EmailSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            TransactionIDSearchTextBox.Text = string.Empty;
            DateSearchTextBox.Text = string.Empty;
        }

        private void DateSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            TransactionIDSearchTextBox.Text = string.Empty;
            EmailSearchTextBox.Text = string.Empty;
        }

        private void TransactionIDSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            EmailSearchTextBox.Text = string.Empty;
            DateSearchTextBox.Text = string.Empty;
        }

        //The Search Button in the search screen takes the input keyword, and looks for it in the Records File, returning the transaction(s)
        //for the appropriate Transaction ID, date or email ID
        private void SearchInfoButton_Click(object sender, EventArgs e)
        {
            String EmailIDSearch = EmailSearchTextBox.Text;
            String DateSearch = DateSearchTextBox.Text;
            String TransactionIDSearch = TransactionIDSearchTextBox.Text;


            if (EmailIDSearch.Length != 0 || DateSearch.Length != 0 || TransactionIDSearch.Length != 0)
            {
                StreamReader Reader;
                SearchListBox.Items.Clear();
                try
                {
                    Reader = File.OpenText("Invest4UTransactionTable1.txt");
                    PrepareSearchResults(ref Reader, EmailIDSearch, DateSearch, TransactionIDSearch);
                }
                catch
                {
                    MessageBox.Show("Unable to Access File! Please Locate File Manually", "File Read Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (OpenFile.ShowDialog() == DialogResult.OK)
                    {
                        Reader = File.OpenText(OpenFile.FileName);
                        PrepareSearchResults(ref Reader, EmailIDSearch, DateSearch, TransactionIDSearch);
                    }
                }
            }
        }

        //This Back Button takes the user back to the Investment Window, Changing form title and Resizing the form in the process
        private void BackSearchButton_Click(object sender, EventArgs e)
        {
            ResetAll();

            this.Text = Investment;
            FormResizer(Screen1X, Screen1Y);
            InvestmentPanel.Visible = true;
        }

        //This Button clears the Search options and Search Results, getting the screen ready for a fresh search
        private void ClearSearchButton_Click(object sender, EventArgs e)
        {
            SearchListBox.Items.Clear();
            ResetAll();
            SearchGroupBox.Visible = true;
        }

        //COMMON METHODS 

        //SetTerm is called by CalculateTerms, which in itself is called when the Display button is clicked. It's used to 
        //populate text on the radio buttons with financial data like Term, Interest Rate and Compound Interst for the user to choose.
        //SetTerm calls CalculateCompountInterest, which is a generic function to calculate Compound Interest for the given parameters
        private string SetTerm(int Term, decimal TermInterest, decimal InputAmount)
        {
            decimal CompoundInterest = (decimal) CalculateCompountInterest(Term, TermInterest, InputAmount);
            return Term + " Year Term @ Interest Rate of " + TermInterest + "%, Final Amount: " + CompoundInterest.ToString("C2");
        }

        private double CalculateCompountInterest(int Term, decimal TermInterest, decimal InputAmount)
        {
            double CompoundInterest = Decimal.ToDouble(InputAmount) * Math.Pow((1 + Decimal.ToDouble(TermInterest) / 12), Term);
            return CompoundInterest;
        }

        private void CalculateTerms(decimal AmountEntered)
        {
            if(AmountEntered <= 100000)
            {
                LowInterestIndicator = true;
                Term1Radio.Text = SetTerm(Term1, Tier1InterestTerm1, AmountEntered);
                Term2Radio.Text = SetTerm(Term2, Tier1InterestTerm2, AmountEntered);
                Term3Radio.Text = SetTerm(Term3, Tier1InterestTerm3, AmountEntered);
                Term4Radio.Text = SetTerm(Term4, Tier1InterestTerm4, AmountEntered);
            }
            else
            {
                Term1Radio.Text = SetTerm(Term1, Tier2InterestTerm1, AmountEntered);
                Term2Radio.Text = SetTerm(Term2, Tier2InterestTerm2, AmountEntered);
                Term3Radio.Text = SetTerm(Term3, Tier2InterestTerm3, AmountEntered);
                Term4Radio.Text = SetTerm(Term4, Tier2InterestTerm4, AmountEntered);
            }
        }

        //GenerateTransactionID Generates a random 6 digit Transaction ID based on the upper and lower limits set earlier in the program
        private int GenerateTransactionID()
        {
            Random RandomGenerator = new Random();
            int GeneratedID = RandomGenerator.Next(LowerLimit, UpperLimit);
            return GeneratedID;
        }

        //This Function returns a formatted string, which will in turn be used in the PrepareSearchResults method, where it is used to populate the search results
        private String FormatSearchResult(int TransactionID, string TransactionDate, string EmailID, string Name, string Contact, int Term, string Interest, decimal Investment, decimal CompoundInterest, decimal CumulativeAmount)
        {
            string SearchResult = "Transaction ID: " + TransactionID + " Transaction Date: " + TransactionDate + " Email ID: " + EmailID + " Name: " +
                                                    Name + " Contact: " + Contact + " Term: " + Term + " Years Interest: " + Interest + "% Investment: " + Investment.ToString("C2") +
                                                    " Compound Interest: " + CompoundInterest.ToString("C2") + " Cumulative Amount: " + CumulativeAmount.ToString("C2");
            return SearchResult;
        }

        //This method reads the record file, and asks the user to open the file manually if there's an exception,
        //after which the file is parsed and searched for the input search term, and returns the appropriate results.
        private void PrepareSearchResults(ref StreamReader Reader, string EmailIDSearch, string DateSearch, string TransactionIDSearch)
        {
            bool ProceedFlag = true, FoundEmailFlag = false, FoundDateFlag = false, FoundIDFLag = false;
            try
            {
                int TransactionID, Term;
                decimal Investment, CompoundInterest, CumulativeAmount;
                string TransactionDate, EmailID, Name, Contact, Interest;
                while (!Reader.EndOfStream)
                {
                    if (!int.TryParse(Reader.ReadLine(), out TransactionID))
                    {
                        MessageBox.Show("Unable to Proceed! File Not of the Expected Format!", "File Read Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ProceedFlag = false;
                        break;
                    }
                    TransactionDate = Reader.ReadLine();
                    EmailID = Reader.ReadLine();
                    Name = Reader.ReadLine();
                    Contact = Reader.ReadLine();
                    if (!int.TryParse(Reader.ReadLine(), out Term))
                    {
                        MessageBox.Show("Unable to Proceed File Not of the Expected Format!", "File Read Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ProceedFlag = false;
                        break;
                    }
                    Interest = Reader.ReadLine();
                    if (!decimal.TryParse(Reader.ReadLine(), out Investment))
                    {
                        MessageBox.Show("Unable to Proceed! File Not of the Expected Format!", "File Read Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ProceedFlag = false;
                        break;
                    }
                    if (!decimal.TryParse(Reader.ReadLine(), out CompoundInterest))
                    {
                        MessageBox.Show("Unable to Proceed! File Not of the Expected Format!", "File Read Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ProceedFlag = false;
                        break;
                    }
                    if (!decimal.TryParse(Reader.ReadLine(), out CumulativeAmount))
                    {
                        MessageBox.Show("Unable to Proceed! File Not of the Expected Format!", "File Read Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ProceedFlag = false;
                        break;
                    }


                    if (EmailIDSearch.Length != 0)
                    {
                        if (EmailID.Contains(EmailIDSearch))
                        {
                            FoundEmailFlag = true;
                            SearchListBox.Items.Add(FormatSearchResult(TransactionID, TransactionDate, EmailID, Name, Contact, Term, Interest, Investment, CompoundInterest, CumulativeAmount));
                        }
                    }
                    else if(DateSearch.Length != 0)
                    {
                        if (TransactionDate.Contains(DateSearch))
                        {
                            FoundDateFlag = true;
                            SearchListBox.Items.Add(FormatSearchResult(TransactionID, TransactionDate, EmailID, Name, Contact, Term, Interest, Investment, CompoundInterest, CumulativeAmount));
                        }
                    }
                    else if(TransactionIDSearch.Length != 0 && !FoundIDFLag)
                    {
                        if (TransactionID.ToString().Contains(TransactionIDSearch))
                        {
                            FoundIDFLag = true;
                            SearchListBox.Items.Add(FormatSearchResult(TransactionID, TransactionDate, EmailID, Name, Contact, Term, Interest, Investment, CompoundInterest, CumulativeAmount));
                        }
                    }
                }
                if (FoundEmailFlag)
                {
                    ResultInfoLabel.Text = "We Found Results for the Email ID Entered!";
                }else if (FoundDateFlag)
                {
                    ResultInfoLabel.Text = "We Found Results for the Date Entered!";
                }else if(FoundIDFLag)
                {
                    ResultInfoLabel.Text = "We Found a Result for the Transaction ID Entered!";
                }
                else
                {
                    ResultInfoLabel.Text = "There were no records that matched the search term!";
                }
                ResultInfoLabel.Visible = true;
            }
            catch
            {
                if (ProceedFlag)
                    MessageBox.Show("Unable to Proceed! File Not of the Expected Format!", "File Read Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //This method prepares the summary, and is called by the Summary Button earlier in the program. This method parses through the
        //record file and formats the output, displaying the Transaction ID, Investment, Compound Interest, Cumulative Amount, as well
        //as calculating average term and average investment and returning it to the Summary Button method
        private void PrepareSummary(ref StreamReader Reader)
        {
            decimal TotalInvestments = 0.0m, TotalTerm = 0.0m;
            int TransactionID, Term, TotalTransactions = 0;
            decimal Investment, CompoundInterest, CumulativeAmount;
            bool ProceedFlag = true;

            SummaryListBox.Items.Clear();
            SummaryInfoLabel.Text = "";
            try
            {
                while (!Reader.EndOfStream)
                {
                    if (!int.TryParse(Reader.ReadLine(), out TransactionID))
                    {
                        MessageBox.Show("Unable to Proceed! File Not of the Expected Format!", "File Read Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ProceedFlag = false;
                        break;
                    }
                    Reader.ReadLine();
                    Reader.ReadLine();
                    Reader.ReadLine();
                    Reader.ReadLine();
                    if (!int.TryParse(Reader.ReadLine(), out Term))
                    {
                        MessageBox.Show("Unable to Proceed File Not of the Expected Format!", "File Read Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ProceedFlag = false;
                        break;
                    }
                    Reader.ReadLine();
                    if (!decimal.TryParse(Reader.ReadLine(), out Investment))
                    {
                        MessageBox.Show("Unable to Proceed! File Not of the Expected Format!", "File Read Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ProceedFlag = false;
                        break;
                    }
                    if (!decimal.TryParse(Reader.ReadLine(), out CompoundInterest))
                    {
                        MessageBox.Show("Unable to Proceed! File Not of the Expected Format!", "File Read Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ProceedFlag = false;
                        break;
                    }
                    if (!decimal.TryParse(Reader.ReadLine(), out CumulativeAmount))
                    {
                        MessageBox.Show("Unable to Proceed! File Not of the Expected Format!", "File Read Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ProceedFlag = false;
                        break;
                    }


                    SummaryListBox.Items.Add("Transaction ID: " + TransactionID + " Investment: " + Investment.ToString("C2") +
                                             " Interest Amount: " + CompoundInterest.ToString("C2") + " Cumulative Amount: " +
                                             CumulativeAmount.ToString("C2") + " Term: " + Term + " Years");

                    TotalInvestments += Investment;
                    TotalTerm += Term;
                    TotalTransactions++;
                }
                SummaryInfoLabel.Text = "Average Invested Amount: " + (TotalInvestments / TotalTransactions).ToString("C2") + " " +
                        "Average Term: " + (TotalTerm * 12 / TotalTransactions).ToString("N2") + " Years";
                Reader.Close();
                ResetAll();
                FormResizer(Screen3X, Screen3Y);
                this.Text = Summary;
                SummaryGroupBox.Visible = true;
            }
            catch
            {   
                if(ProceedFlag)
                    MessageBox.Show("Unable to Proceed! File Not of the Expected Format!", "File Read Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //This method resets all the textboxes, radio buttons, warning labels and is used in most of the above methods
        private void ResetAll()
        {
            UsernameTextBox.Text = string.Empty;
            PasswordTextBox.Text = string.Empty;
            LoginPanel.Visible = false;
            InvestmentPanel.Visible = false;
            ProceedPanel.Visible = false;
            TransactionGroupBox.Visible = false;
            SearchGroupBox.Visible = false;
            SummaryGroupBox.Visible = false;
            AmountTextBox.Text = string.Empty;
            NameTextBox.Text = string.Empty;
            ContactTextBox.Text = string.Empty;
            EmailTextBox.Text = string.Empty;
            Term1Radio.Checked = false;
            Term2Radio.Checked = false;
            Term3Radio.Checked = false;
            Term4Radio.Checked = false;
            LoginWarningLabel.Visible = false;
            AmountWarningLabel.Visible = false;
            RadioWarningLabel.Visible = false;
            ResultInfoLabel.Visible = false;
            TransactionWarningLabel.Visible = false;
            EmailSearchTextBox.Text = string.Empty;
            TransactionIDSearchTextBox.Text = string.Empty;
            DateSearchTextBox.Text = string.Empty;
        }

        //This method resizes the form to the input coordinates
        private void FormResizer(int X, int Y)
        {
            this.Size = new Size(X, Y);
        }
    }
}
