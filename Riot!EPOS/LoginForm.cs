using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Riot_EPOS
{
    //The login form takes care of authorising the employee to be able to generate reports, view summary and use the search facility.
    //There's a pre defined password, with 3 attempts to log in beyond which the program terminates
    public partial class LoginForm : Form
    {
        const string PASSWORD = "ShowMeTheMoney#", USERNAME = "admin";
        const int MAXTRIES = 3;
        int Attempts = 1;

        public LoginForm()
        {
            InitializeComponent();
        }

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
                    MainForm MainForm = new MainForm();
                    MainForm.Show();
                    this.Close();
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
            LoginPanel.Visible = true;
            UsernameTextBox.Focus();
        }

        //EXIT BUTTON : The exit button triggers a confirmation dialog box, on confirming which, the user can exit the application with no changes saved
        private void BackLoginButton_Click(object sender, EventArgs e)
        {
            DialogResult ExitResult = MessageBox.Show("Are you sure?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (ExitResult.Equals(DialogResult.Yes))
                this.Close();
            else
            {
                UsernameTextBox.Text = string.Empty;
                PasswordTextBox.Text = string.Empty;
            }
            LoginPanel.Visible = true;
            UsernameTextBox.Focus();
        }
    }
}
