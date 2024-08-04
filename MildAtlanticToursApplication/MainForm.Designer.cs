namespace MildAtlanticToursApplication
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
            this.DriverEntryPanel = new System.Windows.Forms.Panel();
            this.ProceedButton = new System.Windows.Forms.Button();
            this.BusIDBox = new System.Windows.Forms.TextBox();
            this.DriverNameBox = new System.Windows.Forms.TextBox();
            this.BusIDLabel = new System.Windows.Forms.Label();
            this.DriverName = new System.Windows.Forms.Label();
            this.LogoPicture = new System.Windows.Forms.PictureBox();
            this.ControlPanel = new System.Windows.Forms.Panel();
            this.SummaryButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ProcessButton = new System.Windows.Forms.Button();
            this.DriverDailyPassengerGroup = new System.Windows.Forms.GroupBox();
            this.ChildFareBox = new System.Windows.Forms.TextBox();
            this.StudentFareBox = new System.Windows.Forms.TextBox();
            this.FullFareBox = new System.Windows.Forms.TextBox();
            this.ChildFareLabel = new System.Windows.Forms.Label();
            this.StudentFareLabel = new System.Windows.Forms.Label();
            this.FullFareLabel = new System.Windows.Forms.Label();
            this.DriverSummaryGroup = new System.Windows.Forms.GroupBox();
            this.ChildFarePercentBox = new System.Windows.Forms.TextBox();
            this.StudentFarePercentBox = new System.Windows.Forms.TextBox();
            this.FullFarePercentBox = new System.Windows.Forms.TextBox();
            this.ChildReceiptsBox = new System.Windows.Forms.TextBox();
            this.StudentReceiptsBox = new System.Windows.Forms.TextBox();
            this.FullReceiptsBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TotalReceiptsBox = new System.Windows.Forms.TextBox();
            this.TotalPassengersBox = new System.Windows.Forms.TextBox();
            this.TotalDriversBox = new System.Windows.Forms.TextBox();
            this.TotalReceiptsLabel = new System.Windows.Forms.Label();
            this.TotalPassengersLabel = new System.Windows.Forms.Label();
            this.TotalDriversLabel = new System.Windows.Forms.Label();
            this.Info = new System.Windows.Forms.ToolTip(this.components);
            this.DriverEntryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicture)).BeginInit();
            this.ControlPanel.SuspendLayout();
            this.DriverDailyPassengerGroup.SuspendLayout();
            this.DriverSummaryGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // DriverEntryPanel
            // 
            this.DriverEntryPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DriverEntryPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.DriverEntryPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DriverEntryPanel.Controls.Add(this.ProceedButton);
            this.DriverEntryPanel.Controls.Add(this.BusIDBox);
            this.DriverEntryPanel.Controls.Add(this.DriverNameBox);
            this.DriverEntryPanel.Controls.Add(this.BusIDLabel);
            this.DriverEntryPanel.Controls.Add(this.DriverName);
            this.DriverEntryPanel.Location = new System.Drawing.Point(50, 40);
            this.DriverEntryPanel.Name = "DriverEntryPanel";
            this.DriverEntryPanel.Size = new System.Drawing.Size(723, 87);
            this.DriverEntryPanel.TabIndex = 0;
            // 
            // ProceedButton
            // 
            this.ProceedButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ProceedButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ProceedButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ProceedButton.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProceedButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ProceedButton.Location = new System.Drawing.Point(590, 23);
            this.ProceedButton.Name = "ProceedButton";
            this.ProceedButton.Size = new System.Drawing.Size(103, 38);
            this.ProceedButton.TabIndex = 4;
            this.ProceedButton.Text = "&Proceed";
            this.Info.SetToolTip(this.ProceedButton, "Click to Proceed");
            this.ProceedButton.UseVisualStyleBackColor = false;
            this.ProceedButton.Click += new System.EventHandler(this.ProceedButton_Click);
            // 
            // BusIDBox
            // 
            this.BusIDBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BusIDBox.CausesValidation = false;
            this.BusIDBox.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BusIDBox.Location = new System.Drawing.Point(451, 28);
            this.BusIDBox.Name = "BusIDBox";
            this.BusIDBox.Size = new System.Drawing.Size(100, 28);
            this.BusIDBox.TabIndex = 3;
            this.BusIDBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Info.SetToolTip(this.BusIDBox, "Enter Bus ID");
            this.BusIDBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BusIDBox_MouseDown);
            // 
            // DriverNameBox
            // 
            this.DriverNameBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DriverNameBox.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DriverNameBox.Location = new System.Drawing.Point(134, 28);
            this.DriverNameBox.Name = "DriverNameBox";
            this.DriverNameBox.Size = new System.Drawing.Size(232, 28);
            this.DriverNameBox.TabIndex = 2;
            this.DriverNameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Info.SetToolTip(this.DriverNameBox, "Enter Driver Name");
            this.DriverNameBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DriverNameBox_MouseDown);
            // 
            // BusIDLabel
            // 
            this.BusIDLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BusIDLabel.AutoSize = true;
            this.BusIDLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BusIDLabel.Location = new System.Drawing.Point(383, 32);
            this.BusIDLabel.Name = "BusIDLabel";
            this.BusIDLabel.Size = new System.Drawing.Size(62, 21);
            this.BusIDLabel.TabIndex = 1;
            this.BusIDLabel.Text = "Bus ID:";
            this.BusIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Info.SetToolTip(this.BusIDLabel, "Enter Bus ID");
            // 
            // DriverName
            // 
            this.DriverName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DriverName.AutoSize = true;
            this.DriverName.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DriverName.Location = new System.Drawing.Point(17, 32);
            this.DriverName.Name = "DriverName";
            this.DriverName.Size = new System.Drawing.Size(111, 21);
            this.DriverName.TabIndex = 0;
            this.DriverName.Text = "Driver Name:";
            this.DriverName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Info.SetToolTip(this.DriverName, "Enter Driver Name");
            // 
            // LogoPicture
            // 
            this.LogoPicture.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LogoPicture.Image = ((System.Drawing.Image)(resources.GetObject("LogoPicture.Image")));
            this.LogoPicture.Location = new System.Drawing.Point(50, 700);
            this.LogoPicture.Name = "LogoPicture";
            this.LogoPicture.Size = new System.Drawing.Size(723, 194);
            this.LogoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoPicture.TabIndex = 1;
            this.LogoPicture.TabStop = false;
            // 
            // ControlPanel
            // 
            this.ControlPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ControlPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ControlPanel.Controls.Add(this.SummaryButton);
            this.ControlPanel.Controls.Add(this.ExitButton);
            this.ControlPanel.Controls.Add(this.ClearButton);
            this.ControlPanel.Controls.Add(this.ProcessButton);
            this.ControlPanel.Location = new System.Drawing.Point(50, 240);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(722, 68);
            this.ControlPanel.TabIndex = 2;
            // 
            // SummaryButton
            // 
            this.SummaryButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SummaryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.SummaryButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SummaryButton.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SummaryButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SummaryButton.Location = new System.Drawing.Point(412, 16);
            this.SummaryButton.Name = "SummaryButton";
            this.SummaryButton.Size = new System.Drawing.Size(103, 38);
            this.SummaryButton.TabIndex = 7;
            this.SummaryButton.Text = "&Summary";
            this.Info.SetToolTip(this.SummaryButton, "View Company Summary");
            this.SummaryButton.UseVisualStyleBackColor = false;
            this.SummaryButton.Click += new System.EventHandler(this.SummaryButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ExitButton.Location = new System.Drawing.Point(595, 16);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(103, 38);
            this.ExitButton.TabIndex = 6;
            this.ExitButton.Text = "&Exit";
            this.Info.SetToolTip(this.ExitButton, "Exit Program");
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ClearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ClearButton.Location = new System.Drawing.Point(218, 16);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(103, 38);
            this.ClearButton.TabIndex = 5;
            this.ClearButton.Text = "&Clear";
            this.Info.SetToolTip(this.ClearButton, "Press Clear to Enter Next Driver\'s Details");
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ProcessButton
            // 
            this.ProcessButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ProcessButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ProcessButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ProcessButton.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProcessButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ProcessButton.Location = new System.Drawing.Point(26, 16);
            this.ProcessButton.Name = "ProcessButton";
            this.ProcessButton.Size = new System.Drawing.Size(103, 38);
            this.ProcessButton.TabIndex = 4;
            this.ProcessButton.Text = "P&rocess";
            this.Info.SetToolTip(this.ProcessButton, "Press Process to Enter ");
            this.ProcessButton.UseVisualStyleBackColor = false;
            this.ProcessButton.Click += new System.EventHandler(this.ProcessButton_Click);
            // 
            // DriverDailyPassengerGroup
            // 
            this.DriverDailyPassengerGroup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DriverDailyPassengerGroup.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.DriverDailyPassengerGroup.Controls.Add(this.ChildFareBox);
            this.DriverDailyPassengerGroup.Controls.Add(this.StudentFareBox);
            this.DriverDailyPassengerGroup.Controls.Add(this.FullFareBox);
            this.DriverDailyPassengerGroup.Controls.Add(this.ChildFareLabel);
            this.DriverDailyPassengerGroup.Controls.Add(this.StudentFareLabel);
            this.DriverDailyPassengerGroup.Controls.Add(this.FullFareLabel);
            this.DriverDailyPassengerGroup.Location = new System.Drawing.Point(50, 40);
            this.DriverDailyPassengerGroup.Name = "DriverDailyPassengerGroup";
            this.DriverDailyPassengerGroup.Size = new System.Drawing.Size(722, 172);
            this.DriverDailyPassengerGroup.TabIndex = 3;
            this.DriverDailyPassengerGroup.TabStop = false;
            this.DriverDailyPassengerGroup.Text = "Driver Daily Passengers";
            // 
            // ChildFareBox
            // 
            this.ChildFareBox.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChildFareBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ChildFareBox.Location = new System.Drawing.Point(474, 112);
            this.ChildFareBox.Name = "ChildFareBox";
            this.ChildFareBox.Size = new System.Drawing.Size(100, 28);
            this.ChildFareBox.TabIndex = 6;
            this.ChildFareBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Info.SetToolTip(this.ChildFareBox, "Enter Number of Child Fare Passengers");
            this.ChildFareBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ChildFareBox_MouseDown);
            // 
            // StudentFareBox
            // 
            this.StudentFareBox.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentFareBox.Location = new System.Drawing.Point(474, 74);
            this.StudentFareBox.Name = "StudentFareBox";
            this.StudentFareBox.Size = new System.Drawing.Size(100, 28);
            this.StudentFareBox.TabIndex = 5;
            this.StudentFareBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Info.SetToolTip(this.StudentFareBox, "Enter Number of Student Fare Passengers");
            this.StudentFareBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StudentFareBox_MouseDown);
            // 
            // FullFareBox
            // 
            this.FullFareBox.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullFareBox.Location = new System.Drawing.Point(474, 38);
            this.FullFareBox.Name = "FullFareBox";
            this.FullFareBox.Size = new System.Drawing.Size(100, 28);
            this.FullFareBox.TabIndex = 4;
            this.FullFareBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Info.SetToolTip(this.FullFareBox, "Enter Number of Full Fare Passengers");
            this.FullFareBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FullFareBox_MouseDown);
            // 
            // ChildFareLabel
            // 
            this.ChildFareLabel.AutoSize = true;
            this.ChildFareLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChildFareLabel.Location = new System.Drawing.Point(203, 119);
            this.ChildFareLabel.Name = "ChildFareLabel";
            this.ChildFareLabel.Size = new System.Drawing.Size(86, 21);
            this.ChildFareLabel.TabIndex = 3;
            this.ChildFareLabel.Text = "Child Fare";
            this.ChildFareLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Info.SetToolTip(this.ChildFareLabel, "Enter Number of Child Fare Tickets");
            // 
            // StudentFareLabel
            // 
            this.StudentFareLabel.AutoSize = true;
            this.StudentFareLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentFareLabel.Location = new System.Drawing.Point(203, 81);
            this.StudentFareLabel.Name = "StudentFareLabel";
            this.StudentFareLabel.Size = new System.Drawing.Size(106, 21);
            this.StudentFareLabel.TabIndex = 2;
            this.StudentFareLabel.Text = "Student Fare";
            this.StudentFareLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Info.SetToolTip(this.StudentFareLabel, "Enter Number of Student Fare Tickets");
            // 
            // FullFareLabel
            // 
            this.FullFareLabel.AutoSize = true;
            this.FullFareLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullFareLabel.Location = new System.Drawing.Point(203, 45);
            this.FullFareLabel.Name = "FullFareLabel";
            this.FullFareLabel.Size = new System.Drawing.Size(74, 21);
            this.FullFareLabel.TabIndex = 1;
            this.FullFareLabel.Text = "Full Fare";
            this.FullFareLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Info.SetToolTip(this.FullFareLabel, "Enter Number of Full Fare Tickets");
            // 
            // DriverSummaryGroup
            // 
            this.DriverSummaryGroup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DriverSummaryGroup.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.DriverSummaryGroup.Controls.Add(this.ChildFarePercentBox);
            this.DriverSummaryGroup.Controls.Add(this.StudentFarePercentBox);
            this.DriverSummaryGroup.Controls.Add(this.FullFarePercentBox);
            this.DriverSummaryGroup.Controls.Add(this.ChildReceiptsBox);
            this.DriverSummaryGroup.Controls.Add(this.StudentReceiptsBox);
            this.DriverSummaryGroup.Controls.Add(this.FullReceiptsBox);
            this.DriverSummaryGroup.Controls.Add(this.label1);
            this.DriverSummaryGroup.Controls.Add(this.label2);
            this.DriverSummaryGroup.Controls.Add(this.label3);
            this.DriverSummaryGroup.Controls.Add(this.TotalReceiptsBox);
            this.DriverSummaryGroup.Controls.Add(this.TotalPassengersBox);
            this.DriverSummaryGroup.Controls.Add(this.TotalDriversBox);
            this.DriverSummaryGroup.Controls.Add(this.TotalReceiptsLabel);
            this.DriverSummaryGroup.Controls.Add(this.TotalPassengersLabel);
            this.DriverSummaryGroup.Controls.Add(this.TotalDriversLabel);
            this.DriverSummaryGroup.Location = new System.Drawing.Point(50, 350);
            this.DriverSummaryGroup.Name = "DriverSummaryGroup";
            this.DriverSummaryGroup.Size = new System.Drawing.Size(722, 310);
            this.DriverSummaryGroup.TabIndex = 4;
            this.DriverSummaryGroup.TabStop = false;
            this.DriverSummaryGroup.Text = "Driver Summary";
            // 
            // ChildFarePercentBox
            // 
            this.ChildFarePercentBox.Location = new System.Drawing.Point(543, 236);
            this.ChildFarePercentBox.Name = "ChildFarePercentBox";
            this.ChildFarePercentBox.ReadOnly = true;
            this.ChildFarePercentBox.Size = new System.Drawing.Size(84, 26);
            this.ChildFarePercentBox.TabIndex = 15;
            this.ChildFarePercentBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // StudentFarePercentBox
            // 
            this.StudentFarePercentBox.Location = new System.Drawing.Point(543, 198);
            this.StudentFarePercentBox.Name = "StudentFarePercentBox";
            this.StudentFarePercentBox.ReadOnly = true;
            this.StudentFarePercentBox.Size = new System.Drawing.Size(84, 26);
            this.StudentFarePercentBox.TabIndex = 14;
            this.StudentFarePercentBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FullFarePercentBox
            // 
            this.FullFarePercentBox.Location = new System.Drawing.Point(543, 162);
            this.FullFarePercentBox.Name = "FullFarePercentBox";
            this.FullFarePercentBox.ReadOnly = true;
            this.FullFarePercentBox.Size = new System.Drawing.Size(84, 26);
            this.FullFarePercentBox.TabIndex = 13;
            this.FullFarePercentBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ChildReceiptsBox
            // 
            this.ChildReceiptsBox.Location = new System.Drawing.Point(412, 236);
            this.ChildReceiptsBox.Name = "ChildReceiptsBox";
            this.ChildReceiptsBox.ReadOnly = true;
            this.ChildReceiptsBox.Size = new System.Drawing.Size(125, 26);
            this.ChildReceiptsBox.TabIndex = 12;
            this.ChildReceiptsBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // StudentReceiptsBox
            // 
            this.StudentReceiptsBox.Location = new System.Drawing.Point(412, 198);
            this.StudentReceiptsBox.Name = "StudentReceiptsBox";
            this.StudentReceiptsBox.ReadOnly = true;
            this.StudentReceiptsBox.Size = new System.Drawing.Size(125, 26);
            this.StudentReceiptsBox.TabIndex = 11;
            this.StudentReceiptsBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FullReceiptsBox
            // 
            this.FullReceiptsBox.Location = new System.Drawing.Point(412, 162);
            this.FullReceiptsBox.Name = "FullReceiptsBox";
            this.FullReceiptsBox.ReadOnly = true;
            this.FullReceiptsBox.Size = new System.Drawing.Size(125, 26);
            this.FullReceiptsBox.TabIndex = 10;
            this.FullReceiptsBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(203, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Child Fare Receipts";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(203, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Student Fare Receipts";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(203, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Full Fare Receipts";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TotalReceiptsBox
            // 
            this.TotalReceiptsBox.Location = new System.Drawing.Point(412, 119);
            this.TotalReceiptsBox.Name = "TotalReceiptsBox";
            this.TotalReceiptsBox.ReadOnly = true;
            this.TotalReceiptsBox.Size = new System.Drawing.Size(215, 26);
            this.TotalReceiptsBox.TabIndex = 6;
            this.TotalReceiptsBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TotalPassengersBox
            // 
            this.TotalPassengersBox.Location = new System.Drawing.Point(412, 81);
            this.TotalPassengersBox.Name = "TotalPassengersBox";
            this.TotalPassengersBox.ReadOnly = true;
            this.TotalPassengersBox.Size = new System.Drawing.Size(215, 26);
            this.TotalPassengersBox.TabIndex = 5;
            this.TotalPassengersBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TotalDriversBox
            // 
            this.TotalDriversBox.Location = new System.Drawing.Point(412, 45);
            this.TotalDriversBox.Name = "TotalDriversBox";
            this.TotalDriversBox.ReadOnly = true;
            this.TotalDriversBox.Size = new System.Drawing.Size(215, 26);
            this.TotalDriversBox.TabIndex = 4;
            this.TotalDriversBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TotalDriversBox.Visible = false;
            // 
            // TotalReceiptsLabel
            // 
            this.TotalReceiptsLabel.AutoSize = true;
            this.TotalReceiptsLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalReceiptsLabel.Location = new System.Drawing.Point(151, 123);
            this.TotalReceiptsLabel.Name = "TotalReceiptsLabel";
            this.TotalReceiptsLabel.Size = new System.Drawing.Size(194, 21);
            this.TotalReceiptsLabel.TabIndex = 3;
            this.TotalReceiptsLabel.Text = "Total Company Receipts";
            this.TotalReceiptsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TotalPassengersLabel
            // 
            this.TotalPassengersLabel.AutoSize = true;
            this.TotalPassengersLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPassengersLabel.Location = new System.Drawing.Point(151, 85);
            this.TotalPassengersLabel.Name = "TotalPassengersLabel";
            this.TotalPassengersLabel.Size = new System.Drawing.Size(224, 21);
            this.TotalPassengersLabel.TabIndex = 2;
            this.TotalPassengersLabel.Text = "Total Number of Passengers";
            this.TotalPassengersLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TotalDriversLabel
            // 
            this.TotalDriversLabel.AutoSize = true;
            this.TotalDriversLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalDriversLabel.Location = new System.Drawing.Point(151, 49);
            this.TotalDriversLabel.Name = "TotalDriversLabel";
            this.TotalDriversLabel.Size = new System.Drawing.Size(194, 21);
            this.TotalDriversLabel.TabIndex = 1;
            this.TotalDriversLabel.Text = "Total Number of Drivers";
            this.TotalDriversLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TotalDriversLabel.Visible = false;
            // 
            // Info
            // 
            this.Info.IsBalloon = true;
            this.Info.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.Info.ToolTipTitle = "Info";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 944);
            this.Controls.Add(this.DriverSummaryGroup);
            this.Controls.Add(this.ControlPanel);
            this.Controls.Add(this.LogoPicture);
            this.Controls.Add(this.DriverEntryPanel);
            this.Controls.Add(this.DriverDailyPassengerGroup);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Welcome to MAT Drivers Portal";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.DriverEntryPanel.ResumeLayout(false);
            this.DriverEntryPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicture)).EndInit();
            this.ControlPanel.ResumeLayout(false);
            this.DriverDailyPassengerGroup.ResumeLayout(false);
            this.DriverDailyPassengerGroup.PerformLayout();
            this.DriverSummaryGroup.ResumeLayout(false);
            this.DriverSummaryGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel DriverEntryPanel;
        private System.Windows.Forms.Label DriverName;
        private System.Windows.Forms.Label BusIDLabel;
        private System.Windows.Forms.Button ProceedButton;
        private System.Windows.Forms.TextBox BusIDBox;
        private System.Windows.Forms.TextBox DriverNameBox;
        private System.Windows.Forms.PictureBox LogoPicture;
        private System.Windows.Forms.Panel ControlPanel;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button ProcessButton;
        private System.Windows.Forms.GroupBox DriverDailyPassengerGroup;
        private System.Windows.Forms.TextBox ChildFareBox;
        private System.Windows.Forms.TextBox StudentFareBox;
        private System.Windows.Forms.TextBox FullFareBox;
        private System.Windows.Forms.Label ChildFareLabel;
        private System.Windows.Forms.Label StudentFareLabel;
        private System.Windows.Forms.Label FullFareLabel;
        private System.Windows.Forms.GroupBox DriverSummaryGroup;
        private System.Windows.Forms.TextBox ChildFarePercentBox;
        private System.Windows.Forms.TextBox StudentFarePercentBox;
        private System.Windows.Forms.TextBox FullFarePercentBox;
        private System.Windows.Forms.TextBox ChildReceiptsBox;
        private System.Windows.Forms.TextBox StudentReceiptsBox;
        private System.Windows.Forms.TextBox FullReceiptsBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TotalReceiptsBox;
        private System.Windows.Forms.TextBox TotalPassengersBox;
        private System.Windows.Forms.TextBox TotalDriversBox;
        private System.Windows.Forms.Label TotalReceiptsLabel;
        private System.Windows.Forms.Label TotalPassengersLabel;
        private System.Windows.Forms.Label TotalDriversLabel;
        private System.Windows.Forms.ToolTip Info;
        private System.Windows.Forms.Button SummaryButton;
    }
}

