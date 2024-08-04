/*Student Name: Niranjan Krishnan Devaraj
 *ID: 23105484
 *Date: 16/10/2023
 *Assignment 2
 *Program Description: The program is a Fitness Company's Booking application, where in a user can pick from a variety of gym programs
 *session bundles, optional upgrades and customizations, and through that avail conditional discounts. In addition, the user is also
 *able to view a summary of all the orders that have been booked successfully. There are 5 buttons, Display, Book, Summary, Clear and Exit
 *along with Radio Buttons for Upgrades and a Check Box for Customization, with their associated actions detailed in the relevant sections.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HaloFitnessApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        //Constants for bundle discounts, bottle cost, conditional discount, training program costs and default form title
        const decimal Bundle1Percent = 1.0m, Bundle3Percent = 0.95m, Bundle5Percent = 0.9m, Bundle7Percent = 0.85m, Bundle10Percent = 0.8m, Bundle12Percent = 0.7m, BottleCost = 7.99m, FinalDiscount = 0.925m;
        const int CircuitTrainingCost = 25, PilatesCost = 40, HIITCost = 25, AerobicsCost = 25, FitnessCost = 20, WeightCost = 25, AgilityCost = 50, YogaCost = 35, SpeedCost = 45;
        const string DefaultFormTitle = "Welcome To Halo Fitness!";

        //Global Permanent and Temporary Variables for bookings, user counter, total program value, total option value, average revenue
        int TotalBookings = 0, UserCounter = 1, TotalBookingsWithOptions = 0;
        decimal TotalProgramValue = 0.0m, TotalOptionsValue = 0.0m, AverageRevenue = 0.0m, TempTotalProgramValue = 0.0m, TempTotalOptionsValue = 0.0m;
        
        //Global Variable for Message Statement String
        String BookingStatement = "";

        /*The program defaults to the program of Circuit Training and a session bundle of 1 when initialized, with the focus passed on to
        *the attendee textbox
        */
        private void MainForm_Load(object sender, EventArgs e)
        {
            ProgramListBox.SetSelected(0, true);
            SessionListBox.SetSelected(0, true);
            AttendeeTextBox.Focus();
            ClearButton.Enabled = false;
        }

        //Enables and Disabled Radio options for Upgrade when UpgradeYesRadio and UpgradeNoRadio are checked respectively
        private void UpgradeYesRadio_CheckedChanged(object sender, EventArgs e)
        {
            ClearButton.Enabled = true;
            OneToOneRadio.Enabled = true;
            SmallGroupRadio.Enabled = true;
            MediumGroupRadio.Enabled = true;
        }

        private void UpgradeNoRadio_CheckedChanged(object sender, EventArgs e)
        {
            ClearButton.Enabled = true;
            OneToOneRadio.Enabled = false;
            OneToOneRadio.Checked = false;
            SmallGroupRadio.Enabled = false;
            SmallGroupRadio.Checked = false;
            MediumGroupRadio.Enabled = false;
            MediumGroupRadio.Checked = false;
        }

        //Enables and Disables CustomTextBox based on CustomBottleCheckBox check status
        private void CustomBottleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ClearButton.Enabled = true;
            if (CustomBottleCheckBox.Checked)
                CustomTextBox.Enabled = true;
            else
                CustomTextBox.Enabled = false;
        }

        private void AttendeeTextBox_TextChanged(object sender, EventArgs e)
        {
            ClearButton.Enabled = true;
        }

        /*The Display button serves as a preface to finalizing the booking plan. On click, it calculates the discounts, upgrades
         *and option costs based on the program and session bundle chosen. It displays all the info calculated on a panel, along
         *with a general description of the program chosen
         */
        private void DisplayButton_Click(object sender, EventArgs e)
        {
            //Text Descriptions for all the programs
            String CircuitTrainingDescription = "Circuit training is a workout method that involves performing a series of exercises in succession with minimal rest to target various muscle groups and boost cardiovascular fitness.";
            String PilatesDescription = "Pilates is a physical fitness system that focuses on strengthening the core muscles, improving flexibility, and promoting overall body awareness and balance.";
            String HIITDescription = "HIIT (High-Intensity Interval Training) is a form of exercise that alternates short bursts of intense activity with brief periods of rest or low-intensity exercise, designed to maximize cardiovascular and metabolic benefits in a short time.";
            String AerobicsDescription = "Aerobics is a type of physical exercise that combines rhythmic, repetitive movements with music to improve cardiovascular fitness, flexibility, and overall health.";
            String FitnessDescription = "A fitness bootcamp is an intense and structured group workout program that combines various exercises to improve fitness levels, typically involving cardiovascular, strength, and agility training.";
            String WeightDescription = "Weight training is a form of exercise that involves lifting weights or resistance to build and strengthen muscles, enhance bone density, and improve overall physical strength and fitness.";
            String AgilityDescription = "Agility training is a form of exercise that focuses on improving an individual's ability to move quickly, change direction, and react with agility.";
            String YogaDescription = "Yoga is a mind-body practice that combines physical postures, controlled breathing, and meditation to promote flexibility, strength, relaxation, and mental well-being.";
            String SpeedDescription = "Speed training is a form of exercise or athletic training that focuses on improving an individual's ability to move rapidly and cover distances quickly, often involving specific drills and techniques to enhance sprinting and agility.";
            
            //Local Variables used for building the final display and booking messages
            String BookingMessageBuilder = "";
            String UpgradeText = "";
            String ProgramName = "";

            //Local Variables used for computation
            uint TotalAttendees = 0;
            int ProgramPrice = 0, TotalSessions = 0, UpgradePrice = 0;
            decimal BundleDiscount = 0.0m, TotalAmount = 0.0m;

            //Local Boolean flags used to determine user choices, compute discounts, and whether we can proceed
            bool CustomBottleFlag = false, UpgradeFlag = false, FinalDiscountFlag = false, ProceedFlag = true;

            //Altering Control states in order to display the form in the appropriate state
            SummaryButton.Enabled = false;
            SummaryPanel.Visible = false;
            SummaryPanel.Enabled = false;
            SummaryInfoPanel.Visible = false;
            SummaryInfoPanel.Enabled = false;
            DisplayLabel.Visible = true;
            DisplayLabel.Enabled = true;
            DisplayTextBox.Visible = true;
            DisplayTextBox.Enabled = true;
            TotalProgramLabel.Visible = false;
            TotalOptionsLabel.Visible = false;
            TotalBookingsLabel.Visible = false;           
            AverageLabel.Visible = false;
            AverageTextBox.Visible = false;
            TotalValueProgramsTextBox.Visible = false;
            TotalValueOptionTextBox.Visible = false;          
            TotalBookingsTextBox.Visible = false;

            /*Enabling upgrade options based on Radio chosen, and toggling UpgradeFlag based on chosen option
             *ProceedFlag is set to false if the input validation fails
             */
            if (UpgradeYesRadio.Checked)
            {
                if (OneToOneRadio.Checked)
                {
                    UpgradePrice = 25;
                    UpgradeFlag = true;
                    UpgradeText += " an One to One Training Upgrade";
                }
                else if (SmallGroupRadio.Checked)
                {
                    UpgradePrice = 15;
                    UpgradeFlag = true;
                    UpgradeText += " a Small Group Training Upgrade";
                }
                else if (MediumGroupRadio.Checked)
                {
                    UpgradePrice = 5;
                    UpgradeFlag = true;
                    UpgradeText += " a Medium Group Training Upgrade";
                }
                else
                {
                    MessageBox.Show("Please Select a Training Upgrade Option or Deselect the Upgrade Option", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ProceedFlag = false;
                }
            }           

            /*Checking if the checkbox has been checked, and if so, if the custom text has been entered
             *ProceedFlag is set to false if the input validation fails
             */
            if (CustomBottleCheckBox.Checked && CustomTextBox.Text != null)
            {
                if (CustomTextBox.Text == string.Empty)
                {
                    MessageBox.Show("Please Enter a Valid Custom Bottle Name or Deselect the Customization Option", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    CustomTextBox.Focus();
                    CustomTextBox.SelectAll();
                    ProceedFlag = false;
                }
                CustomBottleFlag = true;
            }

            //TryParsing the AttendeeTextBox in order to see if the user has entered valid data, and proceeding if valid
            if (uint.TryParse(AttendeeTextBox.Text, out TotalAttendees) && TotalAttendees != 0)
            {
                //Checking for attendee count in order to potentially enable the 7.5% discount
                if (TotalAttendees >= 4)
                    FinalDiscountFlag = true;

                //Checking which program has been selected, and prepping variables for Summary and Display messages
                switch (ProgramListBox.SelectedIndex)
                {
                    case 0:
                        {
                            BookingMessageBuilder = CircuitTrainingDescription;
                            ProgramPrice = CircuitTrainingCost;
                            ProgramName = "Circuit Training";
                            break;
                        }
                    case 1:
                        {
                            BookingMessageBuilder = PilatesDescription;
                            ProgramPrice = PilatesCost;
                            ProgramName = "Pilates";
                            break;
                        }
                    case 2:
                        {
                            BookingMessageBuilder = HIITDescription;
                            ProgramPrice = HIITCost;
                            ProgramName = "High-Intensity Interval Training";
                            break;
                        }
                    case 3:
                        {
                            BookingMessageBuilder = AerobicsDescription;
                            ProgramPrice = AerobicsCost;
                            ProgramName = "Aerobics";
                            break;
                        }
                    case 4:
                        {
                            BookingMessageBuilder = FitnessDescription;
                            ProgramPrice = FitnessCost;
                            ProgramName = "Fitness Bootcamp";
                            break;
                        }
                    case 5:
                        {
                            BookingMessageBuilder = WeightDescription;
                            ProgramPrice = WeightCost;
                            ProgramName = "Weight Lifting";
                            break;
                        }
                    case 6:
                        {
                            BookingMessageBuilder = AgilityDescription;
                            ProgramPrice = AgilityCost;
                            ProgramName = "Agility";
                            break;
                        }
                    case 7:
                        {
                            BookingMessageBuilder = YogaDescription;
                            ProgramPrice = YogaCost;
                            ProgramName = "Yoga";
                            break;
                        }
                    case 8:
                        {
                            BookingMessageBuilder = SpeedDescription;
                            ProgramPrice = SpeedCost;
                            ProgramName = "Speed Training";
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }

                //Checking which session bundle has been selected, and prepping variables for Summary and Display messages
                switch (SessionListBox.SelectedIndex)
                {
                    case 0:
                        {
                            BundleDiscount = Bundle1Percent;
                            TotalSessions = 1;
                            break;
                        }
                    case 1:
                        {
                            BundleDiscount = Bundle3Percent;
                            TotalSessions = 3;
                            break;
                        }
                    case 2:
                        {
                            BundleDiscount = Bundle5Percent;
                            TotalSessions = 5;
                            break;
                        }
                    case 3:
                        {
                            BundleDiscount = Bundle7Percent;
                            TotalSessions = 7;
                            break;
                        }
                    case 4:
                        {
                            BundleDiscount = Bundle10Percent;
                            TotalSessions = 10;
                            break;
                        }
                    case 5:
                        {
                            BundleDiscount = Bundle12Percent;
                            TotalSessions = 12;
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }

                //if all the inputs have been validated, the ProceedFlag will have a value of true
                if (ProceedFlag)
                {
                    //If FinalDiscount, Upgrade and Bottle Customization is done
                    if (FinalDiscountFlag && UpgradeFlag && CustomBottleFlag)
                    {
                        TotalAmount = ((((ProgramPrice + UpgradePrice) * BundleDiscount * TotalSessions) + BottleCost) * TotalAttendees) * FinalDiscount;
                        TempTotalProgramValue = ProgramPrice * BundleDiscount * TotalSessions * TotalAttendees * FinalDiscount;
                        TempTotalOptionsValue = ((UpgradePrice * BundleDiscount * TotalSessions) + BottleCost) * TotalAttendees * FinalDiscount;
                        DisplayTextBox.Text = BookingMessageBuilder + Environment.NewLine + Environment.NewLine + "The " + ProgramName + " Program (at ₹" + ProgramPrice + " per attendee) will cost you " + TotalAmount.ToString("C2") + " after a Bundle Discount of " + (1 - BundleDiscount).ToString("P0") + " , " + UpgradeText + " (at ₹" + UpgradePrice + " per attendee) and an Overall Discount of 7.5%, with Customized Bottles (for ₹7.99), for a Duration of " + TotalSessions + " Sessions, for " + TotalAttendees + " Attendees.";
                        BookingStatement = "The " + ProgramName + " Program (at ₹" + ProgramPrice + " per attendee) will cost you " + TotalAmount.ToString("C2") + " after a Bundle Discount of " + (1 - BundleDiscount).ToString("P0") + " , " + UpgradeText + " (at ₹" + UpgradePrice + " per attendee) and an Overall Discount of 7.5%, with Customized Bottles (for ₹7.99), for a Duration of " + TotalSessions + " Sessions, for " + TotalAttendees + " Attendees."
                        + "\n\n\t\tProgram Name: " + ProgramName + "\n\t\tTotal Cost: " + TotalAmount.ToString("C2") + "\n\t\tDiscount(s): " + (1 - BundleDiscount).ToString("P0") + " Bundle + 7.5% Overall" + "\n\t\tSessions: " + TotalSessions + "\n\t\tAttendees: " + TotalAttendees + "\n\t\tCustom Bottle: Yes";
                    }
                    //If only FinalDiscount and Upgrade is done
                    else if (FinalDiscountFlag && UpgradeFlag)
                    {
                        TotalAmount = (((ProgramPrice + UpgradePrice) * BundleDiscount * TotalSessions) * TotalAttendees) * FinalDiscount;
                        TempTotalProgramValue = ProgramPrice * BundleDiscount * TotalSessions * TotalAttendees * FinalDiscount;
                        TempTotalOptionsValue = (UpgradePrice * BundleDiscount * TotalSessions) * TotalAttendees * FinalDiscount;
                        DisplayTextBox.Text = BookingMessageBuilder + Environment.NewLine + Environment.NewLine + "The " + ProgramName + " Program (at ₹" + ProgramPrice + " per attendee) will cost you " + TotalAmount.ToString("C2") + " after a Bundle Discount of " + (1 - BundleDiscount).ToString("P0") + " , " + UpgradeText + " (at ₹" + UpgradePrice + " per attendee) and an Overall Discount of 7.5% for a Duration of " + TotalSessions + " Sessions, for " + TotalAttendees + " Attendees.";
                        BookingStatement = "The " + ProgramName + " Program (at ₹" + ProgramPrice + " per attendee) will cost you " + TotalAmount.ToString("C2") + " after a Bundle Discount of " + (1 - BundleDiscount).ToString("P0") + " , " + UpgradeText + " (at ₹" + UpgradePrice + " per attendee) and an Overall Discount of 7.5% for a Duration of " + TotalSessions + " Sessions, for " + TotalAttendees + " Attendees."
                        + "\n\n\t\tProgram Name: " + ProgramName + "\n\t\tTotal Cost: " + TotalAmount.ToString("C2") + "\n\t\tDiscount(s): " + (1 - BundleDiscount).ToString("P0") + " Bundle + 7.5% Overall" + "\n\t\tSessions: " + TotalSessions + "\n\t\tAttendees: " + TotalAttendees + "\n\t\tCustom Bottle: Yes";
                    }
                    //If only Bottle Customization and Upgrade is done
                    else if (UpgradeFlag && CustomBottleFlag)
                    {
                        TotalAmount = ((((ProgramPrice + UpgradePrice) * BundleDiscount * TotalSessions) + BottleCost) * TotalAttendees);
                        TempTotalProgramValue = ProgramPrice * BundleDiscount * TotalSessions * TotalAttendees;
                        TempTotalOptionsValue = ((UpgradePrice * BundleDiscount * TotalSessions) + BottleCost) * TotalAttendees;
                        DisplayTextBox.Text = BookingMessageBuilder + Environment.NewLine + Environment.NewLine + "The " + ProgramName + " Program (at ₹" + ProgramPrice + " per attendee) will cost you " + TotalAmount.ToString("C2") + " after a Bundle Discount of " + (1 - BundleDiscount).ToString("P0") + " , " + UpgradeText + " (at ₹" + UpgradePrice + " per attendee) with Customized Bottles (for ₹7.99), for a Duration of " + TotalSessions + " Sessions, for " + TotalAttendees + " Attendees.";
                        BookingStatement = "The " + ProgramName + " Program (at ₹" + ProgramPrice + " per attendee) will cost you " + TotalAmount.ToString("C2") + " after a Bundle Discount of " + (1 - BundleDiscount).ToString("P0") + " , " + UpgradeText + " (at ₹" + UpgradePrice + " per attendee) with Customized Bottles (for ₹7.99), for a Duration of " + TotalSessions + " Sessions, for" + TotalAttendees + " Attendees."
                        + "\n\n\t\tProgram Name: " + ProgramName + "\n\t\tTotal Cost: " + TotalAmount.ToString("C2") + "\n\t\tDiscount(s): " + (1 - BundleDiscount).ToString("P0") + " Bundle" + "\n\t\tSessions: " + TotalSessions + "\n\t\tAttendees: " + TotalAttendees + "\n\t\tCustom Bottle: Yes";
                    }
                    //If only Bottle Customization is done
                    else if (CustomBottleFlag)
                    {
                        TotalAmount = (((ProgramPrice * BundleDiscount * TotalSessions) + BottleCost) * TotalAttendees);
                        TempTotalProgramValue = ProgramPrice * BundleDiscount * TotalSessions * TotalAttendees;
                        TempTotalOptionsValue = BottleCost * TotalAttendees;
                        DisplayTextBox.Text = BookingMessageBuilder + Environment.NewLine + Environment.NewLine + "The " + ProgramName + " Program (at ₹" + ProgramPrice + " per attendee) will cost you " + TotalAmount.ToString("C2") + " after a Bundle Discount of " + (1 - BundleDiscount).ToString("P0") + " for the Duration of " + TotalSessions + " Sessions , with Customized Bottles (for ₹7.99), for " + TotalAttendees + " Attendees.";
                        BookingStatement = "The " + ProgramName + " Program (at ₹" + ProgramPrice + " per attendee) will cost you " + TotalAmount.ToString("C2") + " after a Bundle Discount of " + (1 - BundleDiscount).ToString("P0") + " for the Duration of " + TotalSessions + " Sessions , with Customized Bottles (for ₹7.99), for a Total of " + TotalAttendees + " Attendees."
                        + "\n\n\t\tProgram Name: " + ProgramName + "\n\t\tTotal Cost: " + TotalAmount.ToString("C2") + "\n\t\tDiscount(s): " + (1 - BundleDiscount).ToString("P0") + " Bundle" + "\n\t\tSessions: " + TotalSessions + "\n\t\tAttendees: " + TotalAttendees + "\n\t\tCustom Bottle: Yes";
                    }
                    //If only Upgrade is done
                    else if (UpgradeFlag)
                    {
                        TotalAmount = (((ProgramPrice + UpgradePrice) * BundleDiscount * TotalSessions)) * TotalAttendees;
                        TempTotalProgramValue = ProgramPrice * BundleDiscount * TotalSessions * TotalAttendees;
                        TempTotalOptionsValue = UpgradePrice * BundleDiscount * TotalSessions * TotalAttendees;
                        DisplayTextBox.Text = BookingMessageBuilder + Environment.NewLine + Environment.NewLine + "The " + ProgramName + " Program (at ₹" + ProgramPrice + " per attendee) will cost you " + TotalAmount.ToString("C2") + " after a Bundle Discount of " + (1 - BundleDiscount).ToString("P0") + " , " + UpgradeText + " (at ₹" + UpgradePrice + " per attendee) for the Duration of " + TotalSessions + " Sessions, for " + TotalAttendees + " Attendees.";
                        BookingStatement = "The " + ProgramName + " Program (at ₹" + ProgramPrice + " per attendee) will cost you " + TotalAmount.ToString("C2") + " after a Bundle Discount of " + (1 - BundleDiscount).ToString("P0") + " , " + UpgradeText + " (at ₹" + UpgradePrice + " per attendee) for the Duration of " + TotalSessions + " Sessions, for " + TotalAttendees + " Attendees."
                        + "\n\n\t\tProgram Name: " + ProgramName + "\n\t\tTotal Cost: " + TotalAmount.ToString("C2") + "\n\t\tDiscount(s): " + (1 - BundleDiscount).ToString("P0") + " Bundle" + "\n\t\tSessions: " + TotalSessions + "\n\t\tAttendees: " + TotalAttendees + "\n\t\tCustom Bottle: No";
                    }
                    //If none of the options are chosen
                    else
                    {
                        TotalAmount = (((ProgramPrice * BundleDiscount * TotalSessions)) * TotalAttendees);
                        TempTotalProgramValue = (((ProgramPrice * BundleDiscount * TotalSessions)) * TotalAttendees);
                        DisplayTextBox.Text = BookingMessageBuilder + Environment.NewLine + Environment.NewLine + "The " + ProgramName + " Program (at ₹" + ProgramPrice + " per attendee) will cost you " + TotalAmount.ToString("C2") + " after a Bundle Discount of " + (1 - BundleDiscount).ToString("P0") + " , for the Duration of " + TotalSessions + " Sessions, for " + TotalAttendees + " Attendees.";
                        BookingStatement = "The " + ProgramName + " Program (at ₹" + ProgramPrice + " per attendee) will cost you " + TotalAmount.ToString("C2") + " after a Bundle Discount of " + (1 - BundleDiscount).ToString("P0") + " for the Duration of " + TotalSessions + " Sessions, for " + TotalAttendees + " Attendees."
                        + "\n\n\t\tProgram Name: " + ProgramName + "\n\t\tTotal Cost: " + TotalAmount.ToString("C2") + "\n\t\tDiscount(s): " + (1 - BundleDiscount).ToString("P0") + " Bundle" + "\n\t\tSessions: " + TotalSessions + "\n\t\tAttendees: " + TotalAttendees + "\n\t\tCustom Bottle: No";
                    }

                    //Control changes when the display button call is successfully executed
                    AttendeeTextBox.Enabled = false;
                    ProgramListBox.Enabled = false;
                    SessionListBox.Enabled = false;
                    UpgradeYesRadio.Enabled = false;
                    UpgradeNoRadio.Enabled = false;
                    CustomBottleCheckBox.Enabled = false;
                    OneToOneRadio.Enabled = false;
                    SmallGroupRadio.Enabled = false;
                    MediumGroupRadio.Enabled = false;
                    CustomTextBox.Enabled = false;
                    DisplayButton.Enabled = false;
                    BookButton.Enabled = true;
                    this.Text = "Displaying Options Chosen for Booking #" + UserCounterBox.Text;
                }
            }
            //Input Validation for when a non numerical value/ 0 is entered in the attendees field
            else
            {
                MessageBox.Show("Please Enter a Valid Non Zero Numerical Value in the Attendees Field!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AttendeeTextBox.Focus();
                AttendeeTextBox.SelectAll();
            }
        }

        /*The Book Button finalizes the selections validated by the Display button. It's the final step of the booking workflow
         *It also has a confirmation and a continue dialog box for confirming order and providing exit from the application respectively
         */
        private void BookButton_Click(object sender, EventArgs e)
        {
            this.Text = "Finalizing Options Chosen for Booking #" + UserCounterBox.Text;
            //ConfirmationResponse is used to consider whether we should proceed with the booking or not
            DialogResult ConfirmationResponse = MessageBox.Show("Please verify and confirm the following details:\n\n"+ BookingStatement + "\n\nDo you wish to proceed?", "Confirmation", MessageBoxButtons.YesNo);
            switch (ConfirmationResponse)
            {
                case DialogResult.Yes:
                    {
                        this.Text = "Booking Successful!";
                        //if yes, we display the Booking message, along with an option to exit or continue with another booking
                        DialogResult ExitResponse = MessageBox.Show(BookingStatement + "\n\nThanks for the subscription! Do you wish to make a new booking?", "Booking Successful!", MessageBoxButtons.YesNo);
                        switch (ExitResponse)
                        {
                            //if yes, we reset the form and increment global values for counter and summary values
                            case DialogResult.Yes:
                                {
                                    UserCounter++;
                                    UserCounterBox.Text = UserCounter.ToString("N0");

                                    TotalProgramValue += TempTotalProgramValue;
                                    TotalOptionsValue += TempTotalOptionsValue;
                                    if (TempTotalOptionsValue > 0)
                                        TotalBookingsWithOptions++;
                                    TotalBookings++;
                                    AverageRevenue = (TotalProgramValue + TotalOptionsValue) / TotalBookings;

                                    TempTotalProgramValue = TempTotalOptionsValue = 0;

                                    ProgramListBox.Enabled = true;
                                    SessionListBox.Enabled = true;
                                    ProgramListBox.SetSelected(0, true);
                                    SessionListBox.SetSelected(0, true);

                                    SummaryButton.Enabled = true;
                                    DisplayTextBox.Text = string.Empty;
                                    DisplayTextBox.Visible = true;
                                    DisplayTextBox.Enabled = true;
                                    AttendeeTextBox.Text = string.Empty;
                                    CustomTextBox.Enabled = true;
                                    CustomTextBox.Text = string.Empty;
                                    TotalValueProgramsTextBox.Visible = false;
                                    TotalValueOptionTextBox.Visible = false;
                                    TotalBookingsTextBox.Visible = false;
                                    AverageTextBox.Visible = false;
                                    CustomTextBox.Enabled = false;
                                    CustomTextBox.Text = string.Empty;
                                    AttendeeTextBox.Enabled = true;

                                    CustomBottleCheckBox.Enabled = true;
                                    CustomBottleCheckBox.Checked = false;
                                    UpgradeYesRadio.Enabled = true;
                                    UpgradeNoRadio.Checked = true;

                                    UpgradeNoRadio.Enabled = true;

                                    OneToOneRadio.Enabled = true;
                                    OneToOneRadio.Checked = false;
                                    SmallGroupRadio.Enabled = true;
                                    SmallGroupRadio.Checked = false;
                                    MediumGroupRadio.Enabled = true;
                                    MediumGroupRadio.Checked = false;

                                    OneToOneRadio.Enabled = false;
                                    OneToOneRadio.Checked = false;
                                    SmallGroupRadio.Enabled = false;
                                    SmallGroupRadio.Checked = false;
                                    MediumGroupRadio.Enabled = false;
                                    MediumGroupRadio.Checked = false;

                                    BookButton.Enabled = false;
                                    DisplayButton.Enabled = true;

                                    SummaryPanel.Visible = false;
                                    SummaryPanel.Enabled = false;
                                    SummaryInfoPanel.Visible = false;
                                    SummaryInfoPanel.Enabled = false;

                                    DisplayLabel.Visible = true;
                                    DisplayLabel.Enabled = true;
                                    TotalProgramLabel.Visible = false;
                                    TotalOptionsLabel.Visible = false;
                                    TotalBookingsLabel.Visible = false;
                                    AverageLabel.Visible = false;
                                    ClearButton.Enabled = false;

                                    this.Text = DefaultFormTitle;
                                    break;
                                }
                            case DialogResult.No:
                                {
                                    //if no, we exit the application
                                    this.Close();
                                    break;
                                }
                            default:
                                break;
                        }
                        break;
                    }
                case DialogResult.No:
                {
                    //if no, we clear the form, reset the options selected and invalidate the booking.
                    TempTotalProgramValue = TempTotalOptionsValue = 0;

                    ProgramListBox.Enabled = true;
                    SessionListBox.Enabled = true;
                    ProgramListBox.SetSelected(0, true);
                    SessionListBox.SetSelected(0, true);

                    DisplayTextBox.Text = string.Empty;
                    AttendeeTextBox.Text = string.Empty;
                    AttendeeTextBox.SelectAll();
                    CustomTextBox.Enabled = true;
                    CustomTextBox.Text = string.Empty;
                    DisplayTextBox.Visible = true;
                    DisplayTextBox.Enabled = true;
                    TotalValueProgramsTextBox.Visible = false;
                    TotalValueOptionTextBox.Visible = false;
                    TotalBookingsTextBox.Visible = false;
                    AverageTextBox.Visible = false;
                    AttendeeTextBox.Enabled = true;
                    CustomTextBox.Enabled = false;
                    CustomTextBox.Text = string.Empty;

                    CustomBottleCheckBox.Enabled = true;
                    CustomBottleCheckBox.Checked = false;
                    UpgradeYesRadio.Enabled = true;
                    UpgradeNoRadio.Checked = true;
                    UpgradeNoRadio.Enabled = true;
                    OneToOneRadio.Enabled = true;
                    OneToOneRadio.Checked = false;
                    SmallGroupRadio.Enabled = true;
                    SmallGroupRadio.Checked = false;
                    MediumGroupRadio.Enabled = true;
                    MediumGroupRadio.Checked = false;
                    OneToOneRadio.Enabled = false;
                    OneToOneRadio.Checked = false;
                    SmallGroupRadio.Enabled = false;
                    SmallGroupRadio.Checked = false;
                    MediumGroupRadio.Enabled = false;
                    MediumGroupRadio.Checked = false;

                    BookButton.Enabled = false;
                    SummaryButton.Enabled = true;
                    DisplayButton.Enabled = true;

                    SummaryPanel.Visible = false;
                    SummaryPanel.Enabled = false;
                    SummaryInfoPanel.Visible = false;
                    SummaryInfoPanel.Enabled = false;

                    DisplayLabel.Visible = true;
                    DisplayLabel.Enabled = true;
                    TotalProgramLabel.Visible = false;
                    TotalOptionsLabel.Visible = false;
                    TotalBookingsLabel.Visible = false;
                    AverageLabel.Visible = false;

                    ClearButton.Enabled = false;

                    this.Text = DefaultFormTitle;
                    break;
                }
                default:
                    break;
            }          
        }

        /*The Summary Button displays a panel with some cumulative statistics for the bookings done so far
         *It also can act as a reset/clear when you click on it during data entry 
         */
        private void SummaryButton_Click(object sender, EventArgs e)
        {
            //Dialog warning the user about clearing the form when choosing to view the cumulative Summary
            DialogResult SummaryViewConfirmationResponse = MessageBox.Show("Viewing Summary now will clear all the data you've entered. Do you still wish to proceed?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(SummaryViewConfirmationResponse == DialogResult.Yes)
            {
                //if yes, the global cumulative variables are called and displayed, and the Summary Panel is made visible
                this.Text = "Summary";
                ClearButton.Enabled = true;
                SummaryPanel.Visible = true;
                SummaryPanel.Enabled = true;
                SessionListBox.ClearSelected();
                ProgramListBox.ClearSelected();

                SummaryInfoPanel.Visible = true;
                SummaryInfoPanel.Enabled = true;

                DisplayLabel.Visible = false;
                DisplayLabel.Enabled = false;
                TotalProgramLabel.Visible = true;
                TotalOptionsLabel.Visible = true;
                TotalBookingsLabel.Visible = true;
                AverageLabel.Visible = true;

                DisplayTextBox.Visible = false;
                DisplayTextBox.Enabled = false;
                TotalValueProgramsTextBox.Visible = true;
                TotalValueOptionTextBox.Visible = true;
                TotalBookingsTextBox.Visible = true;
                AverageTextBox.Visible = true;
                TotalValueProgramsTextBox.Text = TotalProgramValue.ToString("C2");
                TotalValueOptionTextBox.Text = TotalOptionsValue.ToString("C2");
                TotalBookingsTextBox.Text = TotalBookingsWithOptions.ToString("N0");
                AverageTextBox.Text = AverageRevenue.ToString("C2");
                AttendeeTextBox.Enabled = false;
                AttendeeTextBox.Text = String.Empty;
                CustomTextBox.Enabled = false;
                CustomTextBox.Text = String.Empty;

                DisplayButton.Enabled = false;
                BookButton.Enabled = false;
                SummaryButton.Enabled = false;

                ProgramListBox.Enabled = false;
                SessionListBox.Enabled = false;

                CustomBottleCheckBox.Enabled = false;
                CustomBottleCheckBox.Checked = false;
                UpgradeYesRadio.Enabled = false;
                UpgradeNoRadio.Enabled = false;
                UpgradeNoRadio.Checked = true;
                OneToOneRadio.Enabled = false;
                OneToOneRadio.Checked = false;
                SmallGroupRadio.Enabled = false;
                SmallGroupRadio.Checked = false;
                MediumGroupRadio.Enabled = false;
                MediumGroupRadio.Checked = false;
            }
            else
            {
                //if no, the form title is reset to its default
                this.Text = DefaultFormTitle;
            }
        }

        //The Clear button is responsible for resetting the form, and is visible and enabled from the beginning
        private void ClearButton_Click(object sender, EventArgs e)
        {
            TempTotalProgramValue = TempTotalOptionsValue = 0;

            ProgramListBox.Enabled = true;
            SessionListBox.Enabled = true;
            ProgramListBox.SetSelected(0, true);
            SessionListBox.SetSelected(0, true);

            DisplayTextBox.Text = string.Empty;
            AttendeeTextBox.Text = string.Empty;
            AttendeeTextBox.SelectAll();
            CustomTextBox.Enabled = true;
            CustomTextBox.Text = string.Empty;
            DisplayTextBox.Visible = true;
            DisplayTextBox.Enabled = true;
            TotalValueProgramsTextBox.Visible = false;
            TotalValueOptionTextBox.Visible = false;
            TotalBookingsTextBox.Visible = false;
            AverageTextBox.Visible = false;
            AttendeeTextBox.Enabled = true;
            AttendeeTextBox.Focus();
            CustomTextBox.Enabled = false;
            CustomTextBox.Text = string.Empty;

            CustomBottleCheckBox.Enabled = true;
            CustomBottleCheckBox.Checked = false;
            UpgradeYesRadio.Enabled = true;
            UpgradeNoRadio.Checked = true;
            UpgradeNoRadio.Enabled = true;
            OneToOneRadio.Enabled = false;
            OneToOneRadio.Checked = false;
            SmallGroupRadio.Enabled = false;
            SmallGroupRadio.Checked = false;
            MediumGroupRadio.Enabled = false;
            MediumGroupRadio.Checked = false;

            BookButton.Enabled = false;
            DisplayButton.Enabled = true;

            SummaryPanel.Visible = false;
            SummaryPanel.Enabled = false;
            SummaryInfoPanel.Visible = false;
            SummaryInfoPanel.Enabled = false;

            DisplayLabel.Visible = true;
            DisplayLabel.Enabled = true;
            TotalProgramLabel.Visible = false;
            TotalOptionsLabel.Visible = false;
            TotalBookingsLabel.Visible = false;
            AverageLabel.Visible = false;

            ClearButton.Enabled = false;

            if (UserCounter > 1)
                SummaryButton.Enabled = true;
            else
                SummaryButton.Enabled = false;

            this.Text = DefaultFormTitle;
        }

        //The Exit button closes the application, and is visible and enabled all the time
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
