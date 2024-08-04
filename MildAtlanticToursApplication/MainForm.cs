/*Student Name: Niranjan Krishnan Devaraj
 *ID: 23105484
 *Date: 27/09/2023
 *Assignment 1
 *Assignment:This Application processes different driver inputs related to their passenger counts and 
 *categories and can display an individual driver summary, as well as a company wide summary cumulative  
 *of all driver inputs. 5 Buttons are being used: Proceed, Process, Clear, Summary and Exit, with uses
 *documented above their respective definitions
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MildAtlanticToursApplication
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        /*Initializing Global Variables for Sum of Passengers, Drivers, Fares for respective categories
         * as well as a few strings to be used for group and form texts. The integer values are signed in
         * order to avoid negative entries
         */
        uint TotalDrivers = 0, TotalPassengers = 0;
        String DefaultTitle = "Welcome to MAT Drivers Portal", ChangedFormTitle = "", DriverSummary = "Driver Summary", CompanySummary = "Company Summary", FinalFormTitle = "MAT Summary Data";
        decimal TotalFareOverall = 0.0m, TotalFullFare = 0.0m, TotalStudentFare = 0.0m, TotalChildFare = 0.0m;
   
        //Declaring const variables for fare calculation
        const decimal CHILDFAREMONEY = 4.75m, FULLFAREMONEY = 9.50m, STUDENTFAREMONEY = 6.75m;

        //Select and Focus on Click for all entry boxes
        private void StudentFareBox_MouseDown(object sender, MouseEventArgs e)
        {
            StudentFareBox.Focus();
            StudentFareBox.SelectAll();
        }

        private void ChildFareBox_MouseDown(object sender, MouseEventArgs e)
        {
            ChildFareBox.Focus();
            ChildFareBox.SelectAll();
        }

        private void DriverNameBox_MouseDown(object sender, MouseEventArgs e)
        {
            DriverNameBox.Focus();
            DriverNameBox.SelectAll();
        }

        private void BusIDBox_MouseDown(object sender, MouseEventArgs e)
        {
            BusIDBox.Focus();
            BusIDBox.SelectAll();
        }

        private void FullFareBox_MouseDown(object sender, MouseEventArgs e)
        {
            FullFareBox.Focus();
            FullFareBox.SelectAll();
        }

        //Setting visibility and enabled status of secondary screens false to prep the screen on load
        private void MainForm_Load(object sender, EventArgs e)
        {
            DriverDailyPassengerGroup.Visible = false;
            DriverDailyPassengerGroup.Enabled = false;
            ControlPanel.Visible = false;
            ControlPanel.Enabled = false;
            DriverSummaryGroup.Visible = false;
            DriverSummaryGroup.Enabled = false;
            TotalDriversLabel.Visible = false;
            TotalDriversLabel.Enabled = false;
            TotalDriversBox.Visible = false;
            TotalDriversBox.Enabled = false;
            SummaryButton.Enabled = false;

            //Repositioning logo image to be below the DriverEntry Panel
            LogoPicture.Location = new Point(33, 130);
        }

        /*Proceed is the first button visible to the user. Accepts Driver Name and Bus ID and enables
         *user to move to the next stage of the data entry process
         */
        private void ProceedButton_Click(object sender, EventArgs e)
        {
            String DriverName = DriverNameBox.Text;
            String BusID = BusIDBox.Text;

            //Checking if the name contains any values, throwing an error to the user if it doesn't
            if (String.IsNullOrEmpty(DriverName))
            {
                MessageBox.Show("Please Enter a Value in Driver Name Field", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DriverNameBox.Focus();
                DriverNameBox.SelectAll();
            }

            //Checking if the bus id field has any values, throwing an error to the user if it doesn't
            if (String.IsNullOrEmpty(BusID))
            {
                MessageBox.Show("Please Enter a Value in Bus ID Field", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                BusIDBox.Focus();
                BusIDBox.SelectAll();
            }

            //Proceeding to the next screen only if the above exceptions are handled and input is valid
            if (!String.IsNullOrEmpty(DriverName) && !String.IsNullOrEmpty(BusID))
            {
                //Changing form title based on user input
                ChangedFormTitle = "Data Entry for Driver: " + DriverName + " Bus ID: " + BusID;
                this.Text = ChangedFormTitle;

                //Changing active panels and repositioning logo image
                DriverEntryPanel.Visible = false;
                DriverEntryPanel.Enabled = false;
                DriverDailyPassengerGroup.Visible = true;
                DriverDailyPassengerGroup.Enabled = true;
                ControlPanel.Visible = true;
                ControlPanel.Enabled = true;
                FullFareBox.Text = "0";
                StudentFareBox.Text = "0";
                ChildFareBox.Text = "0";
                LogoPicture.Location = new Point(33, 450);

                //Focusing on next field to be filled by user
                FullFareBox.Focus();

                //Changing title for usage in Process button
                ChangedFormTitle = "Driver Summary: " + DriverName + " Bus ID: " + BusID;
            }
        }

        /* Process is a part of the control panel presented to the user on clicking Proceed. Process is 
         * responsible for processing the individual driver data entered, and confirms that entered  
         * data has been processed by displaying it in a panel, with business logic implemented 
         * in the panel. This button is disabled when the Summary Button is pressed/clicked
         */
        private void ProcessButton_Click(object sender, EventArgs e)
        {
            /*Initializing field variables for the driver's passenger count and category entry
             * Signed int is used instead of int in order to avoid negative value entries
             */
            uint FullTickets = 0, StudentTickets = 0, ChildTickets = 0, TotalTickets = 0;
            decimal FullFare = 0.0m, StudentFare = 0.0m, ChildFare = 0.0m, TotalFare = 0.0m;

            try
            {
                //input parsing
                FullTickets = uint.Parse(FullFareBox.Text);

                try
                {
                    //input parsing
                    StudentTickets = uint.Parse(StudentFareBox.Text);

                    try
                    {
                        //input parsing
                        ChildTickets = uint.Parse(ChildFareBox.Text);
                        try
                        {
                            //Business Logic
                            TotalTickets = FullTickets + StudentTickets + ChildTickets;
                            FullFare = FullTickets * FULLFAREMONEY;
                            StudentFare = StudentTickets * STUDENTFAREMONEY;
                            ChildFare = ChildTickets * CHILDFAREMONEY;
                            TotalFare = FullFare + StudentFare + ChildFare;

                            //Display of Calculated Values
                            TotalPassengersBox.Text = TotalTickets.ToString();
                            TotalReceiptsBox.Text = TotalFare.ToString("C2");

                            FullReceiptsBox.Text = FullFare.ToString("C2");
                            FullFarePercentBox.Text = (FullFare / TotalFare).ToString("p0");

                            StudentReceiptsBox.Text = StudentFare.ToString("C2");
                            StudentFarePercentBox.Text = (StudentFare / TotalFare).ToString("p0");

                            ChildReceiptsBox.Text = ChildFare.ToString("C2");
                            ChildFarePercentBox.Text = (ChildFare / TotalFare).ToString("p0");

                            //Global Driver Count variable increased on confirming processesing
                            TotalDrivers++;

                            //Updating Global Variables
                            TotalPassengers += TotalTickets;
                            TotalFullFare += FullFare;
                            TotalStudentFare += StudentFare;
                            TotalChildFare += ChildFare;
                            TotalFareOverall += TotalFare;

                            //Panels and group statuses modified to change screen
                            DriverDailyPassengerGroup.Enabled = false;
                            DriverSummaryGroup.Visible = true;
                            DriverSummaryGroup.Enabled = true;

                            //ProcessButton disabled in order to prevent multiple data entry for same data
                            ProcessButton.Enabled = false;

                            //SummaryButton enabled as a minimum of 1 drivers' data has been processed
                            SummaryButton.Enabled = true;

                            //Changing Title for Process Screen
                            this.Text = ChangedFormTitle;
                        }
                        catch
                        {
                            //Exception message and refocus to field to be corrected
                            MessageBox.Show("Atleast one non zero value expected!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            FullFareBox.Focus();
                            FullFareBox.SelectAll();
                        }                       
                    }
                    catch
                    {
                        //Exception message and refocus to field to be corrected
                        MessageBox.Show("Sorry, Whole Number (Numerical) Expected for Number of Child Fare Passengers!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ChildFareBox.Focus();
                        ChildFareBox.SelectAll();                       
                    }
                }
                catch
                {
                    //Exception message and refocus to field to be corrected
                    MessageBox.Show("Sorry, Whole Number (Numerical) Expected for Number of Student Fare Passengers!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    StudentFareBox.Focus();
                    StudentFareBox.SelectAll();
                }
            }
            catch
            {
                //Exception message and refocus to field to be corrected
                MessageBox.Show("Sorry, Whole Number (Numerical) Expected for Number of Full Fare Passengers!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FullFareBox.Focus();
                FullFareBox.SelectAll();
            }
        }

        /* Clear is a button presented in the control panel in the second screen. Clear takes the
         * user back to the first screen, and resets the form for the next driver's entry. Does not modify
         * any of the previously entered data that's already been stored. Can be pressed at all points of 
         * runtime when visible
         */
        private void ClearButton_Click(object sender, EventArgs e)
        {
            //Logo Reset to initial screen position
            LogoPicture.Location = new Point(33, 130);

            //Panels and Group visibility changed to reset screen
            ControlPanel.Visible = false;
            ControlPanel.Enabled = false;
            DriverSummaryGroup.Visible = false;
            DriverSummaryGroup.Enabled = false;
            DriverDailyPassengerGroup.Visible = false;
            DriverDailyPassengerGroup.Enabled = false;
            DriverEntryPanel.Visible = true;
            DriverEntryPanel.Enabled = true;
            TotalDriversLabel.Visible = false;
            TotalDriversLabel.Enabled = false;
            TotalDriversBox.Visible = false;
            TotalDriversBox.Enabled = false;

            //Process Button re-enabled
            ProcessButton.Enabled = true;

            //Clearing Textboxes
            DriverNameBox.Clear();
            BusIDBox.Clear();
            FullFareBox.Clear();
            StudentFareBox.Clear();
            ChildFareBox.Clear();
            TotalPassengersBox.Clear();
            TotalReceiptsBox.Clear();
            FullReceiptsBox.Clear();
            FullFarePercentBox.Clear();
            StudentReceiptsBox.Clear();
            StudentFarePercentBox.Clear();
            ChildReceiptsBox.Clear();
            ChildFarePercentBox.Clear();

            //Resetting Text fields to defaults and focusing DriverName Textbox
            this.Text = DefaultTitle;
            DriverSummaryGroup.Text = DriverSummary;
            DriverNameBox.Focus();
        }

        /*Summary is a button on the control panel that is disabled till the data of atleast
         *one driver has been processed. On press/click, it displays a summary all the drivers'
         *data that has been processed so far. 
         */
        private void SummaryButton_Click(object sender, EventArgs e)
        {
            //Altering status of DriverSummaryGroup
            DriverSummaryGroup.Visible = true;
            DriverSummaryGroup.Enabled = true;

            //Changing visibility of DriverDailyPassengerGroup to modify screen
            DriverDailyPassengerGroup.Visible = false;
            ProcessButton.Enabled = false;

            //Changing title of DriverSummaryGroup to reflect summary button press
            DriverSummaryGroup.Text = CompanySummary;
            
            //Enabling new row in DriverSummaryGroup by making it visible and displaying values in it
            TotalDriversLabel.Visible = true;
            TotalDriversLabel.Enabled = true;
            TotalDriversBox.Visible = true;
            TotalDriversBox.Enabled = true;

            //Business Logic
            TotalDriversBox.Text = TotalDrivers.ToString();
            TotalPassengersBox.Text = TotalPassengers.ToString();
            TotalReceiptsBox.Text = TotalFareOverall.ToString("C2");

            FullReceiptsBox.Text = TotalFullFare.ToString("C2");
            FullFarePercentBox.Text = (TotalFullFare / TotalFareOverall).ToString("p0");

            StudentReceiptsBox.Text = TotalStudentFare.ToString("C2");
            StudentFarePercentBox.Text = (TotalStudentFare / TotalFareOverall).ToString("p0");

            ChildReceiptsBox.Text = TotalChildFare.ToString("C2");
            ChildFarePercentBox.Text = (TotalChildFare / TotalFareOverall).ToString("p0");

            //Changing Form Title and Focusing on Clear button to direct user to next data entry
            this.Text = FinalFormTitle;
            ClearButton.Focus();
        }

        // Exit is a part of the control panel, and is responsible for closing the form
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
