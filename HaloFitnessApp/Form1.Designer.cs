namespace HaloFitnessApp
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.SessionListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SessionPanel = new System.Windows.Forms.Panel();
            this.AttendeeTextBox = new System.Windows.Forms.TextBox();
            this.AttendeesLabel = new System.Windows.Forms.Label();
            this.SessionHeaderPanel = new System.Windows.Forms.Panel();
            this.DisplayButton = new System.Windows.Forms.Button();
            this.BookButton = new System.Windows.Forms.Button();
            this.SummaryButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.ProgramListBox = new System.Windows.Forms.ListBox();
            this.ProgramsLabel = new System.Windows.Forms.Label();
            this.ProgramPanel = new System.Windows.Forms.Panel();
            this.ProgramHeaderPanel = new System.Windows.Forms.Panel();
            this.ControlPanel = new System.Windows.Forms.Panel();
            this.DisplayTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MediumGroupRadio = new System.Windows.Forms.RadioButton();
            this.SmallGroupRadio = new System.Windows.Forms.RadioButton();
            this.OneToOneRadio = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.UpgradeNoRadio = new System.Windows.Forms.RadioButton();
            this.UpgradeHeaderPanel = new System.Windows.Forms.Panel();
            this.UpgradeLabel = new System.Windows.Forms.Label();
            this.UpgradeYesRadio = new System.Windows.Forms.RadioButton();
            this.CustomTextBox = new System.Windows.Forms.TextBox();
            this.CustomTextLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.CustomBottleCheckBox = new System.Windows.Forms.CheckBox();
            this.CustomBottleHeaderPanel = new System.Windows.Forms.Panel();
            this.CustomizationLabel = new System.Windows.Forms.Label();
            this.LogoPicture = new System.Windows.Forms.PictureBox();
            this.DisplayPanel = new System.Windows.Forms.Panel();
            this.SummaryPanel = new System.Windows.Forms.Panel();
            this.SummaryLabel = new System.Windows.Forms.Label();
            this.SummaryInfoPanel = new System.Windows.Forms.Panel();
            this.TotalProgramLabel = new System.Windows.Forms.Label();
            this.TotalValueProgramsTextBox = new System.Windows.Forms.TextBox();
            this.TotalOptionsLabel = new System.Windows.Forms.Label();
            this.TotalBookingsLabel = new System.Windows.Forms.Label();
            this.TotalValueOptionTextBox = new System.Windows.Forms.TextBox();
            this.TotalBookingsTextBox = new System.Windows.Forms.TextBox();
            this.AverageTextBox = new System.Windows.Forms.TextBox();
            this.AverageLabel = new System.Windows.Forms.Label();
            this.DisplayLabel = new System.Windows.Forms.Label();
            this.BasePanel = new System.Windows.Forms.Panel();
            this.UserCounterBox = new System.Windows.Forms.TextBox();
            this.UserCounterPanel = new System.Windows.Forms.Panel();
            this.UserCounterLabel = new System.Windows.Forms.Label();
            this.InfoTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.SessionPanel.SuspendLayout();
            this.SessionHeaderPanel.SuspendLayout();
            this.ProgramPanel.SuspendLayout();
            this.ProgramHeaderPanel.SuspendLayout();
            this.ControlPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.UpgradeHeaderPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.CustomBottleHeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicture)).BeginInit();
            this.DisplayPanel.SuspendLayout();
            this.SummaryPanel.SuspendLayout();
            this.SummaryInfoPanel.SuspendLayout();
            this.BasePanel.SuspendLayout();
            this.UserCounterPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SessionListBox
            // 
            this.SessionListBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SessionListBox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.SessionListBox.ForeColor = System.Drawing.Color.Black;
            this.SessionListBox.FormattingEnabled = true;
            this.SessionListBox.ItemHeight = 20;
            this.SessionListBox.Items.AddRange(new object[] {
            "          1 \t\t           0%",
            "          3\t\t           5%",
            "          5\t\t          10%",
            "          7\t\t          15%",
            "         10\t\t          20%",
            "         12\t\t          30%"});
            this.SessionListBox.Location = new System.Drawing.Point(46, 76);
            this.SessionListBox.Name = "SessionListBox";
            this.SessionListBox.Size = new System.Drawing.Size(249, 124);
            this.SessionListBox.TabIndex = 2;
            this.InfoTooltip.SetToolTip(this.SessionListBox, "Please pick a Session Bundle in order to avail the corresponding Bundle Discount");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 40);
            this.label1.TabIndex = 14;
            this.label1.Text = "Number of\r\nSessions";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(160, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 40);
            this.label2.TabIndex = 15;
            this.label2.Text = "Bundle \r\nDiscount\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SessionPanel
            // 
            this.SessionPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SessionPanel.Controls.Add(this.AttendeeTextBox);
            this.SessionPanel.Controls.Add(this.AttendeesLabel);
            this.SessionPanel.Controls.Add(this.SessionListBox);
            this.SessionPanel.Controls.Add(this.SessionHeaderPanel);
            this.SessionPanel.Location = new System.Drawing.Point(402, 225);
            this.SessionPanel.Name = "SessionPanel";
            this.SessionPanel.Size = new System.Drawing.Size(334, 276);
            this.SessionPanel.TabIndex = 18;
            // 
            // AttendeeTextBox
            // 
            this.AttendeeTextBox.BackColor = System.Drawing.Color.White;
            this.AttendeeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AttendeeTextBox.Location = new System.Drawing.Point(187, 234);
            this.AttendeeTextBox.Name = "AttendeeTextBox";
            this.AttendeeTextBox.Size = new System.Drawing.Size(100, 26);
            this.AttendeeTextBox.TabIndex = 3;
            this.AttendeeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.InfoTooltip.SetToolTip(this.AttendeeTextBox, "Enter number of attendees for the plan picked");
            this.AttendeeTextBox.TextChanged += new System.EventHandler(this.AttendeeTextBox_TextChanged);
            // 
            // AttendeesLabel
            // 
            this.AttendeesLabel.AutoSize = true;
            this.AttendeesLabel.BackColor = System.Drawing.Color.Transparent;
            this.AttendeesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttendeesLabel.ForeColor = System.Drawing.Color.Black;
            this.AttendeesLabel.Location = new System.Drawing.Point(54, 237);
            this.AttendeesLabel.Name = "AttendeesLabel";
            this.AttendeesLabel.Size = new System.Drawing.Size(102, 20);
            this.AttendeesLabel.TabIndex = 16;
            this.AttendeesLabel.Text = "Attendees :";
            this.AttendeesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SessionHeaderPanel
            // 
            this.SessionHeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(193)))), ((int)(((byte)(197)))));
            this.SessionHeaderPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SessionHeaderPanel.Controls.Add(this.label1);
            this.SessionHeaderPanel.Controls.Add(this.label2);
            this.SessionHeaderPanel.Location = new System.Drawing.Point(46, 12);
            this.SessionHeaderPanel.Name = "SessionHeaderPanel";
            this.SessionHeaderPanel.Size = new System.Drawing.Size(249, 58);
            this.SessionHeaderPanel.TabIndex = 20;
            this.InfoTooltip.SetToolTip(this.SessionHeaderPanel, "Please pick a Session Bundle in order to avail the corresponding Bundle Discount");
            // 
            // DisplayButton
            // 
            this.DisplayButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(193)))), ((int)(((byte)(197)))));
            this.DisplayButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DisplayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayButton.Location = new System.Drawing.Point(20, 33);
            this.DisplayButton.Name = "DisplayButton";
            this.DisplayButton.Size = new System.Drawing.Size(100, 36);
            this.DisplayButton.TabIndex = 12;
            this.DisplayButton.Text = "&Display";
            this.InfoTooltip.SetToolTip(this.DisplayButton, "Click to view current overall price based on options \r\nchosen. A Conditional Disc" +
        "ount of 7.5% will be enabled \r\nif the booking is for 4 or more participants, and" +
        " if there \r\nis an upgrade purchased");
            this.DisplayButton.UseVisualStyleBackColor = false;
            this.DisplayButton.Click += new System.EventHandler(this.DisplayButton_Click);
            // 
            // BookButton
            // 
            this.BookButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(193)))), ((int)(((byte)(197)))));
            this.BookButton.Enabled = false;
            this.BookButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BookButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookButton.Location = new System.Drawing.Point(20, 75);
            this.BookButton.Name = "BookButton";
            this.BookButton.Size = new System.Drawing.Size(100, 36);
            this.BookButton.TabIndex = 13;
            this.BookButton.Text = "&Book";
            this.InfoTooltip.SetToolTip(this.BookButton, "Click to confirm booking of displayed options");
            this.BookButton.UseVisualStyleBackColor = false;
            this.BookButton.Click += new System.EventHandler(this.BookButton_Click);
            // 
            // SummaryButton
            // 
            this.SummaryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(193)))), ((int)(((byte)(197)))));
            this.SummaryButton.Enabled = false;
            this.SummaryButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SummaryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SummaryButton.Location = new System.Drawing.Point(20, 117);
            this.SummaryButton.Name = "SummaryButton";
            this.SummaryButton.Size = new System.Drawing.Size(100, 36);
            this.SummaryButton.TabIndex = 14;
            this.SummaryButton.Text = "&Summary";
            this.InfoTooltip.SetToolTip(this.SummaryButton, "Click to view an overall cumulative summary of all the bookings");
            this.SummaryButton.UseVisualStyleBackColor = false;
            this.SummaryButton.Click += new System.EventHandler(this.SummaryButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(193)))), ((int)(((byte)(197)))));
            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.Location = new System.Drawing.Point(20, 159);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(100, 36);
            this.ClearButton.TabIndex = 15;
            this.ClearButton.Text = "&Clear";
            this.InfoTooltip.SetToolTip(this.ClearButton, "Click to clear all selections for the current user");
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(193)))), ((int)(((byte)(197)))));
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(20, 201);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(100, 36);
            this.ExitButton.TabIndex = 16;
            this.ExitButton.Text = "&Exit";
            this.InfoTooltip.SetToolTip(this.ExitButton, "Click to Exit the Application");
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.BackColor = System.Drawing.Color.Transparent;
            this.PriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLabel.ForeColor = System.Drawing.Color.Black;
            this.PriceLabel.Location = new System.Drawing.Point(220, 8);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(81, 40);
            this.PriceLabel.TabIndex = 13;
            this.PriceLabel.Text = "Price Per\r\nSession";
            this.PriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProgramListBox
            // 
            this.ProgramListBox.BackColor = System.Drawing.SystemColors.Menu;
            this.ProgramListBox.ForeColor = System.Drawing.Color.Black;
            this.ProgramListBox.FormattingEnabled = true;
            this.ProgramListBox.ItemHeight = 20;
            this.ProgramListBox.Items.AddRange(new object[] {
            "Circuit Training\t\t        ₹25",
            "Pilates\t\t\t        ₹40",
            "High-Intensity Interval Training        ₹25",
            "Aerobics\t\t\t        ₹25",
            "Fitness Bootcamp\t\t        ₹20",
            "Weight Training\t               \t        ₹25",
            "Agility\t\t\t        ₹50",
            "Yoga\t\t\t        ₹35",
            "Speed Training\t                        ₹45"});
            this.ProgramListBox.Location = new System.Drawing.Point(21, 76);
            this.ProgramListBox.Name = "ProgramListBox";
            this.ProgramListBox.Size = new System.Drawing.Size(311, 184);
            this.ProgramListBox.TabIndex = 1;
            this.InfoTooltip.SetToolTip(this.ProgramListBox, "Please Pick a Program");
            // 
            // ProgramsLabel
            // 
            this.ProgramsLabel.AutoSize = true;
            this.ProgramsLabel.BackColor = System.Drawing.Color.Transparent;
            this.ProgramsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgramsLabel.ForeColor = System.Drawing.Color.Black;
            this.ProgramsLabel.Location = new System.Drawing.Point(4, 18);
            this.ProgramsLabel.Name = "ProgramsLabel";
            this.ProgramsLabel.Size = new System.Drawing.Size(85, 20);
            this.ProgramsLabel.TabIndex = 12;
            this.ProgramsLabel.Text = "Programs";
            this.ProgramsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProgramPanel
            // 
            this.ProgramPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ProgramPanel.Controls.Add(this.ProgramListBox);
            this.ProgramPanel.Controls.Add(this.ProgramHeaderPanel);
            this.ProgramPanel.Location = new System.Drawing.Point(32, 225);
            this.ProgramPanel.Name = "ProgramPanel";
            this.ProgramPanel.Size = new System.Drawing.Size(354, 276);
            this.ProgramPanel.TabIndex = 17;
            // 
            // ProgramHeaderPanel
            // 
            this.ProgramHeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(193)))), ((int)(((byte)(197)))));
            this.ProgramHeaderPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProgramHeaderPanel.Controls.Add(this.ProgramsLabel);
            this.ProgramHeaderPanel.Controls.Add(this.PriceLabel);
            this.ProgramHeaderPanel.Location = new System.Drawing.Point(21, 12);
            this.ProgramHeaderPanel.Name = "ProgramHeaderPanel";
            this.ProgramHeaderPanel.Size = new System.Drawing.Size(311, 58);
            this.ProgramHeaderPanel.TabIndex = 0;
            this.InfoTooltip.SetToolTip(this.ProgramHeaderPanel, "Please Pick a Program");
            // 
            // ControlPanel
            // 
            this.ControlPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ControlPanel.Controls.Add(this.BookButton);
            this.ControlPanel.Controls.Add(this.DisplayButton);
            this.ControlPanel.Controls.Add(this.ExitButton);
            this.ControlPanel.Controls.Add(this.ClearButton);
            this.ControlPanel.Controls.Add(this.SummaryButton);
            this.ControlPanel.Location = new System.Drawing.Point(599, 667);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(137, 270);
            this.ControlPanel.TabIndex = 25;
            // 
            // DisplayTextBox
            // 
            this.DisplayTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(230)))), ((int)(((byte)(226)))));
            this.DisplayTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayTextBox.Location = new System.Drawing.Point(12, 38);
            this.DisplayTextBox.Multiline = true;
            this.DisplayTextBox.Name = "DisplayTextBox";
            this.DisplayTextBox.Size = new System.Drawing.Size(523, 213);
            this.DisplayTextBox.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.MediumGroupRadio);
            this.panel2.Controls.Add(this.SmallGroupRadio);
            this.panel2.Controls.Add(this.OneToOneRadio);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(32, 519);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(354, 128);
            this.panel2.TabIndex = 27;
            // 
            // MediumGroupRadio
            // 
            this.MediumGroupRadio.AutoSize = true;
            this.MediumGroupRadio.Enabled = false;
            this.MediumGroupRadio.Location = new System.Drawing.Point(147, 80);
            this.MediumGroupRadio.Name = "MediumGroupRadio";
            this.MediumGroupRadio.Size = new System.Drawing.Size(199, 24);
            this.MediumGroupRadio.TabIndex = 8;
            this.MediumGroupRadio.Text = "Medium Group Training";
            this.MediumGroupRadio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.InfoTooltip.SetToolTip(this.MediumGroupRadio, "Choose this for Medium Group (upto 25 people) Sessions for all attendees in the c" +
        "hosen program");
            this.MediumGroupRadio.UseVisualStyleBackColor = true;
            // 
            // SmallGroupRadio
            // 
            this.SmallGroupRadio.AutoSize = true;
            this.SmallGroupRadio.Enabled = false;
            this.SmallGroupRadio.Location = new System.Drawing.Point(147, 50);
            this.SmallGroupRadio.Name = "SmallGroupRadio";
            this.SmallGroupRadio.Size = new System.Drawing.Size(182, 24);
            this.SmallGroupRadio.TabIndex = 7;
            this.SmallGroupRadio.Text = "Small Group Training";
            this.SmallGroupRadio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.InfoTooltip.SetToolTip(this.SmallGroupRadio, "Choose this for Small Group (upto 10 people) Sessions for all attendees in the ch" +
        "osen program");
            this.SmallGroupRadio.UseVisualStyleBackColor = true;
            // 
            // OneToOneRadio
            // 
            this.OneToOneRadio.AutoSize = true;
            this.OneToOneRadio.Enabled = false;
            this.OneToOneRadio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.OneToOneRadio.Location = new System.Drawing.Point(147, 20);
            this.OneToOneRadio.Name = "OneToOneRadio";
            this.OneToOneRadio.Size = new System.Drawing.Size(176, 24);
            this.OneToOneRadio.TabIndex = 6;
            this.OneToOneRadio.Text = "One to One Training";
            this.OneToOneRadio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.InfoTooltip.SetToolTip(this.OneToOneRadio, "Choose this for One to One Sessions for all attendees in the chosen program");
            this.OneToOneRadio.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.UpgradeNoRadio);
            this.panel1.Controls.Add(this.UpgradeHeaderPanel);
            this.panel1.Controls.Add(this.UpgradeYesRadio);
            this.panel1.Location = new System.Drawing.Point(-2, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(137, 128);
            this.panel1.TabIndex = 0;
            // 
            // UpgradeNoRadio
            // 
            this.UpgradeNoRadio.AutoSize = true;
            this.UpgradeNoRadio.Checked = true;
            this.UpgradeNoRadio.Location = new System.Drawing.Point(31, 82);
            this.UpgradeNoRadio.Name = "UpgradeNoRadio";
            this.UpgradeNoRadio.Size = new System.Drawing.Size(54, 24);
            this.UpgradeNoRadio.TabIndex = 5;
            this.UpgradeNoRadio.TabStop = true;
            this.UpgradeNoRadio.Text = "No";
            this.InfoTooltip.SetToolTip(this.UpgradeNoRadio, "Click to disable upgrades");
            this.UpgradeNoRadio.UseVisualStyleBackColor = true;
            this.UpgradeNoRadio.CheckedChanged += new System.EventHandler(this.UpgradeNoRadio_CheckedChanged);
            // 
            // UpgradeHeaderPanel
            // 
            this.UpgradeHeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(193)))), ((int)(((byte)(197)))));
            this.UpgradeHeaderPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UpgradeHeaderPanel.Controls.Add(this.UpgradeLabel);
            this.UpgradeHeaderPanel.Location = new System.Drawing.Point(13, 8);
            this.UpgradeHeaderPanel.Name = "UpgradeHeaderPanel";
            this.UpgradeHeaderPanel.Size = new System.Drawing.Size(111, 38);
            this.UpgradeHeaderPanel.TabIndex = 0;
            // 
            // UpgradeLabel
            // 
            this.UpgradeLabel.AutoSize = true;
            this.UpgradeLabel.BackColor = System.Drawing.Color.Transparent;
            this.UpgradeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpgradeLabel.ForeColor = System.Drawing.Color.Black;
            this.UpgradeLabel.Location = new System.Drawing.Point(6, 7);
            this.UpgradeLabel.Name = "UpgradeLabel";
            this.UpgradeLabel.Size = new System.Drawing.Size(97, 20);
            this.UpgradeLabel.TabIndex = 13;
            this.UpgradeLabel.Text = "Upgrades?";
            this.UpgradeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.InfoTooltip.SetToolTip(this.UpgradeLabel, "Please choose if you would like to upgrade to specialized training programs");
            // 
            // UpgradeYesRadio
            // 
            this.UpgradeYesRadio.AutoSize = true;
            this.UpgradeYesRadio.Location = new System.Drawing.Point(31, 52);
            this.UpgradeYesRadio.Name = "UpgradeYesRadio";
            this.UpgradeYesRadio.Size = new System.Drawing.Size(62, 24);
            this.UpgradeYesRadio.TabIndex = 4;
            this.UpgradeYesRadio.Text = "Yes";
            this.InfoTooltip.SetToolTip(this.UpgradeYesRadio, "Click to enable upgrades");
            this.UpgradeYesRadio.UseVisualStyleBackColor = true;
            this.UpgradeYesRadio.CheckedChanged += new System.EventHandler(this.UpgradeYesRadio_CheckedChanged);
            // 
            // CustomTextBox
            // 
            this.CustomTextBox.BackColor = System.Drawing.Color.White;
            this.CustomTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CustomTextBox.Enabled = false;
            this.CustomTextBox.Location = new System.Drawing.Point(153, 78);
            this.CustomTextBox.Name = "CustomTextBox";
            this.CustomTextBox.Size = new System.Drawing.Size(164, 26);
            this.CustomTextBox.TabIndex = 11;
            this.CustomTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.InfoTooltip.SetToolTip(this.CustomTextBox, "Enter Custom Text to be printed on your Halo Bottle");
            // 
            // CustomTextLabel
            // 
            this.CustomTextLabel.AutoSize = true;
            this.CustomTextLabel.BackColor = System.Drawing.Color.Transparent;
            this.CustomTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomTextLabel.ForeColor = System.Drawing.Color.Black;
            this.CustomTextLabel.Location = new System.Drawing.Point(149, 22);
            this.CustomTextLabel.Name = "CustomTextLabel";
            this.CustomTextLabel.Size = new System.Drawing.Size(168, 20);
            this.CustomTextLabel.TabIndex = 31;
            this.CustomTextLabel.Text = "Enter Custom Text :";
            this.CustomTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.InfoTooltip.SetToolTip(this.CustomTextLabel, "Enter Custom Text to be printed on your Halo Bottle");
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.CustomTextBox);
            this.panel3.Controls.Add(this.CustomTextLabel);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(402, 519);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(334, 128);
            this.panel3.TabIndex = 33;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.CustomBottleCheckBox);
            this.panel4.Controls.Add(this.CustomBottleHeaderPanel);
            this.panel4.Location = new System.Drawing.Point(-2, -2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(145, 128);
            this.panel4.TabIndex = 33;
            // 
            // CustomBottleCheckBox
            // 
            this.CustomBottleCheckBox.AutoSize = true;
            this.CustomBottleCheckBox.Location = new System.Drawing.Point(40, 79);
            this.CustomBottleCheckBox.Name = "CustomBottleCheckBox";
            this.CustomBottleCheckBox.Size = new System.Drawing.Size(63, 24);
            this.CustomBottleCheckBox.TabIndex = 38;
            this.CustomBottleCheckBox.Text = "Yes";
            this.InfoTooltip.SetToolTip(this.CustomBottleCheckBox, "Check this option if you would like to customize your Halo bottle");
            this.CustomBottleCheckBox.UseVisualStyleBackColor = true;
            this.CustomBottleCheckBox.CheckedChanged += new System.EventHandler(this.CustomBottleCheckBox_CheckedChanged);
            // 
            // CustomBottleHeaderPanel
            // 
            this.CustomBottleHeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(193)))), ((int)(((byte)(197)))));
            this.CustomBottleHeaderPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CustomBottleHeaderPanel.Controls.Add(this.CustomizationLabel);
            this.CustomBottleHeaderPanel.Location = new System.Drawing.Point(16, 8);
            this.CustomBottleHeaderPanel.Name = "CustomBottleHeaderPanel";
            this.CustomBottleHeaderPanel.Size = new System.Drawing.Size(110, 49);
            this.CustomBottleHeaderPanel.TabIndex = 15;
            // 
            // CustomizationLabel
            // 
            this.CustomizationLabel.AutoSize = true;
            this.CustomizationLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(193)))), ((int)(((byte)(197)))));
            this.CustomizationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomizationLabel.ForeColor = System.Drawing.Color.Black;
            this.CustomizationLabel.Location = new System.Drawing.Point(9, 5);
            this.CustomizationLabel.Name = "CustomizationLabel";
            this.CustomizationLabel.Size = new System.Drawing.Size(98, 40);
            this.CustomizationLabel.TabIndex = 28;
            this.CustomizationLabel.Text = "Customize \r\nBottle?";
            this.CustomizationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.InfoTooltip.SetToolTip(this.CustomizationLabel, "Check this option if you would like to customize your Halo bottle");
            // 
            // LogoPicture
            // 
            this.LogoPicture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LogoPicture.Image = ((System.Drawing.Image)(resources.GetObject("LogoPicture.Image")));
            this.LogoPicture.Location = new System.Drawing.Point(19, 19);
            this.LogoPicture.Name = "LogoPicture";
            this.LogoPicture.Size = new System.Drawing.Size(704, 176);
            this.LogoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoPicture.TabIndex = 34;
            this.LogoPicture.TabStop = false;
            // 
            // DisplayPanel
            // 
            this.DisplayPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DisplayPanel.Controls.Add(this.SummaryPanel);
            this.DisplayPanel.Controls.Add(this.SummaryInfoPanel);
            this.DisplayPanel.Controls.Add(this.DisplayLabel);
            this.DisplayPanel.Controls.Add(this.DisplayTextBox);
            this.DisplayPanel.Location = new System.Drawing.Point(32, 667);
            this.DisplayPanel.Name = "DisplayPanel";
            this.DisplayPanel.Size = new System.Drawing.Size(549, 270);
            this.DisplayPanel.TabIndex = 35;
            // 
            // SummaryPanel
            // 
            this.SummaryPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(193)))), ((int)(((byte)(197)))));
            this.SummaryPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SummaryPanel.Controls.Add(this.SummaryLabel);
            this.SummaryPanel.Location = new System.Drawing.Point(12, 11);
            this.SummaryPanel.Name = "SummaryPanel";
            this.SummaryPanel.Size = new System.Drawing.Size(523, 58);
            this.SummaryPanel.TabIndex = 34;
            this.SummaryPanel.Visible = false;
            // 
            // SummaryLabel
            // 
            this.SummaryLabel.AutoSize = true;
            this.SummaryLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(193)))), ((int)(((byte)(197)))));
            this.SummaryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SummaryLabel.ForeColor = System.Drawing.Color.Black;
            this.SummaryLabel.Location = new System.Drawing.Point(217, 13);
            this.SummaryLabel.Name = "SummaryLabel";
            this.SummaryLabel.Size = new System.Drawing.Size(103, 25);
            this.SummaryLabel.TabIndex = 32;
            this.SummaryLabel.Text = "Summary";
            this.SummaryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SummaryInfoPanel
            // 
            this.SummaryInfoPanel.BackColor = System.Drawing.SystemColors.MenuBar;
            this.SummaryInfoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SummaryInfoPanel.Controls.Add(this.TotalProgramLabel);
            this.SummaryInfoPanel.Controls.Add(this.TotalValueProgramsTextBox);
            this.SummaryInfoPanel.Controls.Add(this.TotalOptionsLabel);
            this.SummaryInfoPanel.Controls.Add(this.TotalBookingsLabel);
            this.SummaryInfoPanel.Controls.Add(this.TotalValueOptionTextBox);
            this.SummaryInfoPanel.Controls.Add(this.TotalBookingsTextBox);
            this.SummaryInfoPanel.Controls.Add(this.AverageTextBox);
            this.SummaryInfoPanel.Controls.Add(this.AverageLabel);
            this.SummaryInfoPanel.Location = new System.Drawing.Point(12, 75);
            this.SummaryInfoPanel.Name = "SummaryInfoPanel";
            this.SummaryInfoPanel.Size = new System.Drawing.Size(523, 183);
            this.SummaryInfoPanel.TabIndex = 33;
            this.SummaryInfoPanel.Visible = false;
            // 
            // TotalProgramLabel
            // 
            this.TotalProgramLabel.AutoSize = true;
            this.TotalProgramLabel.BackColor = System.Drawing.SystemColors.MenuBar;
            this.TotalProgramLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalProgramLabel.ForeColor = System.Drawing.Color.Black;
            this.TotalProgramLabel.Location = new System.Drawing.Point(89, 15);
            this.TotalProgramLabel.Name = "TotalProgramLabel";
            this.TotalProgramLabel.Size = new System.Drawing.Size(202, 20);
            this.TotalProgramLabel.TabIndex = 24;
            this.TotalProgramLabel.Text = "Total Value of Programs";
            this.TotalProgramLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TotalProgramLabel.Visible = false;
            // 
            // TotalValueProgramsTextBox
            // 
            this.TotalValueProgramsTextBox.Location = new System.Drawing.Point(322, 15);
            this.TotalValueProgramsTextBox.Name = "TotalValueProgramsTextBox";
            this.TotalValueProgramsTextBox.ReadOnly = true;
            this.TotalValueProgramsTextBox.Size = new System.Drawing.Size(125, 26);
            this.TotalValueProgramsTextBox.TabIndex = 25;
            this.TotalValueProgramsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TotalValueProgramsTextBox.Visible = false;
            // 
            // TotalOptionsLabel
            // 
            this.TotalOptionsLabel.AutoSize = true;
            this.TotalOptionsLabel.BackColor = System.Drawing.SystemColors.MenuBar;
            this.TotalOptionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalOptionsLabel.ForeColor = System.Drawing.Color.Black;
            this.TotalOptionsLabel.Location = new System.Drawing.Point(103, 57);
            this.TotalOptionsLabel.Name = "TotalOptionsLabel";
            this.TotalOptionsLabel.Size = new System.Drawing.Size(188, 20);
            this.TotalOptionsLabel.TabIndex = 26;
            this.TotalOptionsLabel.Text = "Total Value of Options";
            this.TotalOptionsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TotalOptionsLabel.Visible = false;
            // 
            // TotalBookingsLabel
            // 
            this.TotalBookingsLabel.AutoSize = true;
            this.TotalBookingsLabel.BackColor = System.Drawing.SystemColors.MenuBar;
            this.TotalBookingsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalBookingsLabel.ForeColor = System.Drawing.Color.Black;
            this.TotalBookingsLabel.Location = new System.Drawing.Point(59, 96);
            this.TotalBookingsLabel.Name = "TotalBookingsLabel";
            this.TotalBookingsLabel.Size = new System.Drawing.Size(232, 20);
            this.TotalBookingsLabel.TabIndex = 28;
            this.TotalBookingsLabel.Text = "Total Bookings with Options";
            this.TotalBookingsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TotalBookingsLabel.Visible = false;
            // 
            // TotalValueOptionTextBox
            // 
            this.TotalValueOptionTextBox.Location = new System.Drawing.Point(322, 57);
            this.TotalValueOptionTextBox.Name = "TotalValueOptionTextBox";
            this.TotalValueOptionTextBox.ReadOnly = true;
            this.TotalValueOptionTextBox.Size = new System.Drawing.Size(125, 26);
            this.TotalValueOptionTextBox.TabIndex = 27;
            this.TotalValueOptionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TotalValueOptionTextBox.Visible = false;
            // 
            // TotalBookingsTextBox
            // 
            this.TotalBookingsTextBox.Location = new System.Drawing.Point(323, 93);
            this.TotalBookingsTextBox.Name = "TotalBookingsTextBox";
            this.TotalBookingsTextBox.ReadOnly = true;
            this.TotalBookingsTextBox.Size = new System.Drawing.Size(125, 26);
            this.TotalBookingsTextBox.TabIndex = 29;
            this.TotalBookingsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TotalBookingsTextBox.Visible = false;
            // 
            // AverageTextBox
            // 
            this.AverageTextBox.Location = new System.Drawing.Point(323, 135);
            this.AverageTextBox.Name = "AverageTextBox";
            this.AverageTextBox.ReadOnly = true;
            this.AverageTextBox.Size = new System.Drawing.Size(125, 26);
            this.AverageTextBox.TabIndex = 31;
            this.AverageTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AverageTextBox.Visible = false;
            // 
            // AverageLabel
            // 
            this.AverageLabel.AutoSize = true;
            this.AverageLabel.BackColor = System.Drawing.SystemColors.MenuBar;
            this.AverageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AverageLabel.ForeColor = System.Drawing.Color.Black;
            this.AverageLabel.Location = new System.Drawing.Point(38, 138);
            this.AverageLabel.Name = "AverageLabel";
            this.AverageLabel.Size = new System.Drawing.Size(253, 20);
            this.AverageLabel.TabIndex = 30;
            this.AverageLabel.Text = "Average Revenue Per Booking";
            this.AverageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AverageLabel.Visible = false;
            // 
            // DisplayLabel
            // 
            this.DisplayLabel.AutoSize = true;
            this.DisplayLabel.BackColor = System.Drawing.Color.Transparent;
            this.DisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayLabel.ForeColor = System.Drawing.Color.Black;
            this.DisplayLabel.Location = new System.Drawing.Point(8, 11);
            this.DisplayLabel.Name = "DisplayLabel";
            this.DisplayLabel.Size = new System.Drawing.Size(67, 20);
            this.DisplayLabel.TabIndex = 14;
            this.DisplayLabel.Text = "Display";
            this.DisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BasePanel
            // 
            this.BasePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BasePanel.Controls.Add(this.UserCounterBox);
            this.BasePanel.Controls.Add(this.UserCounterPanel);
            this.BasePanel.Controls.Add(this.LogoPicture);
            this.BasePanel.Location = new System.Drawing.Point(12, 12);
            this.BasePanel.Name = "BasePanel";
            this.BasePanel.Size = new System.Drawing.Size(744, 940);
            this.BasePanel.TabIndex = 36;
            // 
            // UserCounterBox
            // 
            this.UserCounterBox.BackColor = System.Drawing.SystemColors.Control;
            this.UserCounterBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserCounterBox.Location = new System.Drawing.Point(621, 87);
            this.UserCounterBox.Name = "UserCounterBox";
            this.UserCounterBox.ReadOnly = true;
            this.UserCounterBox.Size = new System.Drawing.Size(102, 26);
            this.UserCounterBox.TabIndex = 37;
            this.UserCounterBox.Text = "1";
            this.UserCounterBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.InfoTooltip.SetToolTip(this.UserCounterBox, "Number of Users Processed");
            // 
            // UserCounterPanel
            // 
            this.UserCounterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(193)))), ((int)(((byte)(197)))));
            this.UserCounterPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserCounterPanel.Controls.Add(this.UserCounterLabel);
            this.UserCounterPanel.Location = new System.Drawing.Point(621, 19);
            this.UserCounterPanel.Name = "UserCounterPanel";
            this.UserCounterPanel.Size = new System.Drawing.Size(102, 62);
            this.UserCounterPanel.TabIndex = 37;
            // 
            // UserCounterLabel
            // 
            this.UserCounterLabel.AutoSize = true;
            this.UserCounterLabel.BackColor = System.Drawing.Color.Transparent;
            this.UserCounterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserCounterLabel.ForeColor = System.Drawing.Color.Black;
            this.UserCounterLabel.Location = new System.Drawing.Point(14, 9);
            this.UserCounterLabel.Name = "UserCounterLabel";
            this.UserCounterLabel.Size = new System.Drawing.Size(73, 40);
            this.UserCounterLabel.TabIndex = 15;
            this.UserCounterLabel.Text = "User\r\nCounter\r\n";
            this.UserCounterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.InfoTooltip.SetToolTip(this.UserCounterLabel, "Number of Users Processed");
            // 
            // InfoTooltip
            // 
            this.InfoTooltip.IsBalloon = true;
            this.InfoTooltip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.InfoTooltip.ToolTipTitle = "Info";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(230)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(768, 965);
            this.Controls.Add(this.DisplayPanel);
            this.Controls.Add(this.ProgramPanel);
            this.Controls.Add(this.SessionPanel);
            this.Controls.Add(this.ControlPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.BasePanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Welcome To Halo Fitness!";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.SessionPanel.ResumeLayout(false);
            this.SessionPanel.PerformLayout();
            this.SessionHeaderPanel.ResumeLayout(false);
            this.SessionHeaderPanel.PerformLayout();
            this.ProgramPanel.ResumeLayout(false);
            this.ProgramHeaderPanel.ResumeLayout(false);
            this.ProgramHeaderPanel.PerformLayout();
            this.ControlPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.UpgradeHeaderPanel.ResumeLayout(false);
            this.UpgradeHeaderPanel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.CustomBottleHeaderPanel.ResumeLayout(false);
            this.CustomBottleHeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicture)).EndInit();
            this.DisplayPanel.ResumeLayout(false);
            this.DisplayPanel.PerformLayout();
            this.SummaryPanel.ResumeLayout(false);
            this.SummaryPanel.PerformLayout();
            this.SummaryInfoPanel.ResumeLayout(false);
            this.SummaryInfoPanel.PerformLayout();
            this.BasePanel.ResumeLayout(false);
            this.BasePanel.PerformLayout();
            this.UserCounterPanel.ResumeLayout(false);
            this.UserCounterPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox SessionListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel SessionPanel;
        private System.Windows.Forms.TextBox AttendeeTextBox;
        private System.Windows.Forms.Label AttendeesLabel;
        private System.Windows.Forms.Button DisplayButton;
        private System.Windows.Forms.Button BookButton;
        private System.Windows.Forms.Button SummaryButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.ListBox ProgramListBox;
        private System.Windows.Forms.Label ProgramsLabel;
        private System.Windows.Forms.Panel ProgramPanel;
        private System.Windows.Forms.Panel ControlPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton MediumGroupRadio;
        private System.Windows.Forms.RadioButton SmallGroupRadio;
        private System.Windows.Forms.RadioButton OneToOneRadio;
        private System.Windows.Forms.RadioButton UpgradeNoRadio;
        private System.Windows.Forms.RadioButton UpgradeYesRadio;
        private System.Windows.Forms.TextBox CustomTextBox;
        private System.Windows.Forms.Label CustomTextLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox LogoPicture;
        private System.Windows.Forms.Panel DisplayPanel;
        private System.Windows.Forms.Panel BasePanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label DisplayLabel;
        private System.Windows.Forms.Panel SessionHeaderPanel;
        private System.Windows.Forms.Panel ProgramHeaderPanel;
        private System.Windows.Forms.Label CustomizationLabel;
        private System.Windows.Forms.Panel UpgradeHeaderPanel;
        private System.Windows.Forms.Label UpgradeLabel;
        private System.Windows.Forms.Panel CustomBottleHeaderPanel;
        private System.Windows.Forms.TextBox DisplayTextBox;
        private System.Windows.Forms.Panel SummaryPanel;
        private System.Windows.Forms.Label SummaryLabel;
        private System.Windows.Forms.Panel SummaryInfoPanel;
        private System.Windows.Forms.Label TotalProgramLabel;
        private System.Windows.Forms.TextBox TotalValueProgramsTextBox;
        private System.Windows.Forms.Label TotalOptionsLabel;
        private System.Windows.Forms.Label TotalBookingsLabel;
        private System.Windows.Forms.TextBox TotalValueOptionTextBox;
        private System.Windows.Forms.TextBox TotalBookingsTextBox;
        private System.Windows.Forms.TextBox AverageTextBox;
        private System.Windows.Forms.Label AverageLabel;
        private System.Windows.Forms.Panel UserCounterPanel;
        private System.Windows.Forms.Label UserCounterLabel;
        private System.Windows.Forms.TextBox UserCounterBox;
        private System.Windows.Forms.CheckBox CustomBottleCheckBox;
        private System.Windows.Forms.ToolTip InfoTooltip;
    }
}

