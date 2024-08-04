namespace Riot_EPOS
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
            this.ItemListbox = new System.Windows.Forms.ListBox();
            this.SizeListbox = new System.Windows.Forms.ListBox();
            this.ItemLabel = new System.Windows.Forms.Label();
            this.SizeLabel = new System.Windows.Forms.Label();
            this.ItemPanel = new System.Windows.Forms.Panel();
            this.StockWarningLabel = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SubtractButton = new System.Windows.Forms.Button();
            this.PricePanel = new System.Windows.Forms.Panel();
            this.OriginalPriceLabel = new System.Windows.Forms.Label();
            this.OriginalPriceValueLabel = new System.Windows.Forms.Label();
            this.SavingsValueLabel = new System.Windows.Forms.Label();
            this.SavingsLabel = new System.Windows.Forms.Label();
            this.UnitPriceValueLabel = new System.Windows.Forms.Label();
            this.UnitPriceLabel = new System.Windows.Forms.Label();
            this.TotalPriceValueLabel = new System.Windows.Forms.Label();
            this.TotalPriceLabel = new System.Windows.Forms.Label();
            this.TaxValueLabel = new System.Windows.Forms.Label();
            this.TaxLabel = new System.Windows.Forms.Label();
            this.AddItemButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.QuantityTextbox = new System.Windows.Forms.TextBox();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.LogoPicture = new System.Windows.Forms.PictureBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.AdminButton = new System.Windows.Forms.Button();
            this.MainItemsPanel = new System.Windows.Forms.Panel();
            this.AvailabilityDisclaimerLabel = new System.Windows.Forms.Label();
            this.ColourListbox = new System.Windows.Forms.ListBox();
            this.ColourLabel = new System.Windows.Forms.Label();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.AdminPanel = new System.Windows.Forms.Panel();
            this.TransactionListbox = new System.Windows.Forms.ListBox();
            this.CartLabel = new System.Windows.Forms.Label();
            this.CartButtonPanel = new System.Windows.Forms.Panel();
            this.CartSavingsValueLabel = new System.Windows.Forms.Label();
            this.CartSavingsLabel = new System.Windows.Forms.Label();
            this.CartTaxValueLabel = new System.Windows.Forms.Label();
            this.CartTaxLabel = new System.Windows.Forms.Label();
            this.CartValueLabel = new System.Windows.Forms.Label();
            this.CartPriceLabel = new System.Windows.Forms.Label();
            this.ClearCartButton = new System.Windows.Forms.Button();
            this.ProceedButton = new System.Windows.Forms.Button();
            this.MainToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ItemPanel.SuspendLayout();
            this.PricePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicture)).BeginInit();
            this.MainItemsPanel.SuspendLayout();
            this.BottomPanel.SuspendLayout();
            this.AdminPanel.SuspendLayout();
            this.CartButtonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ItemListbox
            // 
            this.ItemListbox.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemListbox.FormattingEnabled = true;
            this.ItemListbox.ItemHeight = 21;
            this.ItemListbox.Location = new System.Drawing.Point(233, 46);
            this.ItemListbox.Name = "ItemListbox";
            this.ItemListbox.Size = new System.Drawing.Size(483, 214);
            this.ItemListbox.TabIndex = 1;
            this.ItemListbox.SelectedIndexChanged += new System.EventHandler(this.ItemListbox_SelectedIndexChanged);
            // 
            // SizeListbox
            // 
            this.SizeListbox.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SizeListbox.FormattingEnabled = true;
            this.SizeListbox.ItemHeight = 21;
            this.SizeListbox.Location = new System.Drawing.Point(21, 46);
            this.SizeListbox.Name = "SizeListbox";
            this.SizeListbox.Size = new System.Drawing.Size(80, 214);
            this.SizeListbox.TabIndex = 2;
            this.SizeListbox.SelectedIndexChanged += new System.EventHandler(this.SizeListbox_SelectedIndexChanged);
            // 
            // ItemLabel
            // 
            this.ItemLabel.AutoSize = true;
            this.ItemLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ItemLabel.Location = new System.Drawing.Point(228, 16);
            this.ItemLabel.Name = "ItemLabel";
            this.ItemLabel.Size = new System.Drawing.Size(174, 24);
            this.ItemLabel.TabIndex = 36;
            this.ItemLabel.Text = "Choose Your Items:";
            this.ItemLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SizeLabel
            // 
            this.SizeLabel.AutoSize = true;
            this.SizeLabel.BackColor = System.Drawing.Color.Transparent;
            this.SizeLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SizeLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SizeLabel.Location = new System.Drawing.Point(16, 16);
            this.SizeLabel.Name = "SizeLabel";
            this.SizeLabel.Size = new System.Drawing.Size(48, 24);
            this.SizeLabel.TabIndex = 37;
            this.SizeLabel.Text = "Size:";
            this.SizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ItemPanel
            // 
            this.ItemPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ItemPanel.Controls.Add(this.StockWarningLabel);
            this.ItemPanel.Controls.Add(this.ClearButton);
            this.ItemPanel.Controls.Add(this.SubtractButton);
            this.ItemPanel.Controls.Add(this.PricePanel);
            this.ItemPanel.Controls.Add(this.AddItemButton);
            this.ItemPanel.Controls.Add(this.AddButton);
            this.ItemPanel.Controls.Add(this.QuantityTextbox);
            this.ItemPanel.Location = new System.Drawing.Point(752, 12);
            this.ItemPanel.Name = "ItemPanel";
            this.ItemPanel.Size = new System.Drawing.Size(402, 425);
            this.ItemPanel.TabIndex = 1;
            // 
            // StockWarningLabel
            // 
            this.StockWarningLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StockWarningLabel.AutoSize = true;
            this.StockWarningLabel.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockWarningLabel.ForeColor = System.Drawing.Color.Red;
            this.StockWarningLabel.Location = new System.Drawing.Point(262, 134);
            this.StockWarningLabel.Name = "StockWarningLabel";
            this.StockWarningLabel.Size = new System.Drawing.Size(112, 21);
            this.StockWarningLabel.TabIndex = 60;
            this.StockWarningLabel.Text = "Out of Stock!";
            this.StockWarningLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.StockWarningLabel.Visible = false;
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ClearButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ClearButton.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.ForeColor = System.Drawing.Color.Black;
            this.ClearButton.Location = new System.Drawing.Point(249, 355);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(129, 40);
            this.ClearButton.TabIndex = 58;
            this.ClearButton.Text = "&Clear";
            this.MainToolTip.SetToolTip(this.ClearButton, "Clear Selection");
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // SubtractButton
            // 
            this.SubtractButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.SubtractButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubtractButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SubtractButton.Location = new System.Drawing.Point(331, 69);
            this.SubtractButton.Name = "SubtractButton";
            this.SubtractButton.Size = new System.Drawing.Size(50, 50);
            this.SubtractButton.TabIndex = 57;
            this.SubtractButton.Text = "-";
            this.MainToolTip.SetToolTip(this.SubtractButton, "Reduce Quantity");
            this.SubtractButton.UseVisualStyleBackColor = false;
            this.SubtractButton.Click += new System.EventHandler(this.SubtractButton_Click);
            // 
            // PricePanel
            // 
            this.PricePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PricePanel.Controls.Add(this.OriginalPriceLabel);
            this.PricePanel.Controls.Add(this.OriginalPriceValueLabel);
            this.PricePanel.Controls.Add(this.SavingsValueLabel);
            this.PricePanel.Controls.Add(this.SavingsLabel);
            this.PricePanel.Controls.Add(this.UnitPriceValueLabel);
            this.PricePanel.Controls.Add(this.UnitPriceLabel);
            this.PricePanel.Controls.Add(this.TotalPriceValueLabel);
            this.PricePanel.Controls.Add(this.TotalPriceLabel);
            this.PricePanel.Controls.Add(this.TaxValueLabel);
            this.PricePanel.Controls.Add(this.TaxLabel);
            this.PricePanel.Location = new System.Drawing.Point(16, 3);
            this.PricePanel.Name = "PricePanel";
            this.PricePanel.Size = new System.Drawing.Size(225, 408);
            this.PricePanel.TabIndex = 64;
            // 
            // OriginalPriceLabel
            // 
            this.OriginalPriceLabel.AutoSize = true;
            this.OriginalPriceLabel.BackColor = System.Drawing.Color.Transparent;
            this.OriginalPriceLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OriginalPriceLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.OriginalPriceLabel.Location = new System.Drawing.Point(45, 325);
            this.OriginalPriceLabel.Name = "OriginalPriceLabel";
            this.OriginalPriceLabel.Size = new System.Drawing.Size(131, 24);
            this.OriginalPriceLabel.TabIndex = 68;
            this.OriginalPriceLabel.Text = "Original Price:";
            this.OriginalPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OriginalPriceValueLabel
            // 
            this.OriginalPriceValueLabel.AutoSize = true;
            this.OriginalPriceValueLabel.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OriginalPriceValueLabel.Location = new System.Drawing.Point(60, 351);
            this.OriginalPriceValueLabel.Name = "OriginalPriceValueLabel";
            this.OriginalPriceValueLabel.Size = new System.Drawing.Size(101, 27);
            this.OriginalPriceValueLabel.TabIndex = 69;
            this.OriginalPriceValueLabel.Text = "0.00 EUR";
            this.OriginalPriceValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SavingsValueLabel
            // 
            this.SavingsValueLabel.AutoSize = true;
            this.SavingsValueLabel.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SavingsValueLabel.Location = new System.Drawing.Point(60, 272);
            this.SavingsValueLabel.Name = "SavingsValueLabel";
            this.SavingsValueLabel.Size = new System.Drawing.Size(101, 27);
            this.SavingsValueLabel.TabIndex = 67;
            this.SavingsValueLabel.Text = "0.00 EUR";
            this.SavingsValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SavingsLabel
            // 
            this.SavingsLabel.AutoSize = true;
            this.SavingsLabel.BackColor = System.Drawing.Color.Transparent;
            this.SavingsLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SavingsLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SavingsLabel.Location = new System.Drawing.Point(67, 248);
            this.SavingsLabel.Name = "SavingsLabel";
            this.SavingsLabel.Size = new System.Drawing.Size(79, 24);
            this.SavingsLabel.TabIndex = 66;
            this.SavingsLabel.Text = "Savings:";
            this.SavingsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UnitPriceValueLabel
            // 
            this.UnitPriceValueLabel.AutoSize = true;
            this.UnitPriceValueLabel.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnitPriceValueLabel.Location = new System.Drawing.Point(60, 140);
            this.UnitPriceValueLabel.Name = "UnitPriceValueLabel";
            this.UnitPriceValueLabel.Size = new System.Drawing.Size(101, 27);
            this.UnitPriceValueLabel.TabIndex = 63;
            this.UnitPriceValueLabel.Text = "0.00 EUR";
            // 
            // UnitPriceLabel
            // 
            this.UnitPriceLabel.AutoSize = true;
            this.UnitPriceLabel.BackColor = System.Drawing.Color.Transparent;
            this.UnitPriceLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnitPriceLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UnitPriceLabel.Location = new System.Drawing.Point(18, 99);
            this.UnitPriceLabel.Name = "UnitPriceLabel";
            this.UnitPriceLabel.Size = new System.Drawing.Size(189, 24);
            this.UnitPriceLabel.TabIndex = 46;
            this.UnitPriceLabel.Text = "Unit Price (With Tax):";
            this.UnitPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TotalPriceValueLabel
            // 
            this.TotalPriceValueLabel.AutoSize = true;
            this.TotalPriceValueLabel.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPriceValueLabel.Location = new System.Drawing.Point(60, 60);
            this.TotalPriceValueLabel.Name = "TotalPriceValueLabel";
            this.TotalPriceValueLabel.Size = new System.Drawing.Size(101, 27);
            this.TotalPriceValueLabel.TabIndex = 62;
            this.TotalPriceValueLabel.Text = "0.00 EUR";
            // 
            // TotalPriceLabel
            // 
            this.TotalPriceLabel.AutoSize = true;
            this.TotalPriceLabel.BackColor = System.Drawing.Color.Transparent;
            this.TotalPriceLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPriceLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TotalPriceLabel.Location = new System.Drawing.Point(11, 19);
            this.TotalPriceLabel.Name = "TotalPriceLabel";
            this.TotalPriceLabel.Size = new System.Drawing.Size(196, 24);
            this.TotalPriceLabel.TabIndex = 47;
            this.TotalPriceLabel.Text = "Total Price (With Tax):";
            this.TotalPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TaxValueLabel
            // 
            this.TaxValueLabel.AutoSize = true;
            this.TaxValueLabel.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaxValueLabel.Location = new System.Drawing.Point(60, 207);
            this.TaxValueLabel.Name = "TaxValueLabel";
            this.TaxValueLabel.Size = new System.Drawing.Size(101, 27);
            this.TaxValueLabel.TabIndex = 65;
            this.TaxValueLabel.Text = "0.00 EUR";
            this.TaxValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TaxLabel
            // 
            this.TaxLabel.AutoSize = true;
            this.TaxLabel.BackColor = System.Drawing.Color.Transparent;
            this.TaxLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaxLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TaxLabel.Location = new System.Drawing.Point(83, 183);
            this.TaxLabel.Name = "TaxLabel";
            this.TaxLabel.Size = new System.Drawing.Size(43, 24);
            this.TaxLabel.TabIndex = 64;
            this.TaxLabel.Text = "Tax:";
            this.TaxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddItemButton
            // 
            this.AddItemButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(189)))));
            this.AddItemButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.AddItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddItemButton.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddItemButton.ForeColor = System.Drawing.Color.Black;
            this.AddItemButton.Location = new System.Drawing.Point(250, 309);
            this.AddItemButton.Name = "AddItemButton";
            this.AddItemButton.Size = new System.Drawing.Size(128, 40);
            this.AddItemButton.TabIndex = 56;
            this.AddItemButton.Text = "&Add";
            this.MainToolTip.SetToolTip(this.AddItemButton, "Add Product to Cart");
            this.AddItemButton.UseVisualStyleBackColor = false;
            this.AddItemButton.Click += new System.EventHandler(this.AddItemButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(189)))));
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddButton.Location = new System.Drawing.Point(247, 69);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(50, 50);
            this.AddButton.TabIndex = 55;
            this.AddButton.Text = "+";
            this.MainToolTip.SetToolTip(this.AddButton, "Increase Quantity");
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // QuantityTextbox
            // 
            this.QuantityTextbox.Location = new System.Drawing.Point(247, 28);
            this.QuantityTextbox.Name = "QuantityTextbox";
            this.QuantityTextbox.Size = new System.Drawing.Size(134, 26);
            this.QuantityTextbox.TabIndex = 54;
            this.QuantityTextbox.Text = "1";
            this.QuantityTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.QuantityTextbox.TextChanged += new System.EventHandler(this.QuantityTextbox_TextChanged);
            // 
            // RemoveButton
            // 
            this.RemoveButton.BackColor = System.Drawing.Color.LightCoral;
            this.RemoveButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.RemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RemoveButton.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveButton.ForeColor = System.Drawing.Color.Black;
            this.RemoveButton.Location = new System.Drawing.Point(64, 65);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(129, 40);
            this.RemoveButton.TabIndex = 59;
            this.RemoveButton.Text = "&Remove";
            this.MainToolTip.SetToolTip(this.RemoveButton, "Remove Selected Item from Cart");
            this.RemoveButton.UseVisualStyleBackColor = false;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // LogoPicture
            // 
            this.LogoPicture.Image = ((System.Drawing.Image)(resources.GetObject("LogoPicture.Image")));
            this.LogoPicture.Location = new System.Drawing.Point(19, 13);
            this.LogoPicture.Name = "LogoPicture";
            this.LogoPicture.Size = new System.Drawing.Size(946, 70);
            this.LogoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoPicture.TabIndex = 38;
            this.LogoPicture.TabStop = false;
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.Color.Black;
            this.ExitButton.Location = new System.Drawing.Point(993, 50);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(129, 33);
            this.ExitButton.TabIndex = 37;
            this.ExitButton.Text = "&Exit";
            this.MainToolTip.SetToolTip(this.ExitButton, "Exit the Application");
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // AdminButton
            // 
            this.AdminButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(189)))));
            this.AdminButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.AdminButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AdminButton.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminButton.ForeColor = System.Drawing.Color.Black;
            this.AdminButton.Location = new System.Drawing.Point(993, 11);
            this.AdminButton.Name = "AdminButton";
            this.AdminButton.Size = new System.Drawing.Size(129, 33);
            this.AdminButton.TabIndex = 36;
            this.AdminButton.Text = "&Admin Tools";
            this.MainToolTip.SetToolTip(this.AdminButton, "Use to Access Admin Tools such as Reports and Search");
            this.AdminButton.UseVisualStyleBackColor = false;
            this.AdminButton.Click += new System.EventHandler(this.AdminButton_Click);
            // 
            // MainItemsPanel
            // 
            this.MainItemsPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MainItemsPanel.Controls.Add(this.AvailabilityDisclaimerLabel);
            this.MainItemsPanel.Controls.Add(this.ColourListbox);
            this.MainItemsPanel.Controls.Add(this.ColourLabel);
            this.MainItemsPanel.Controls.Add(this.SizeListbox);
            this.MainItemsPanel.Controls.Add(this.SizeLabel);
            this.MainItemsPanel.Controls.Add(this.ItemListbox);
            this.MainItemsPanel.Controls.Add(this.ItemLabel);
            this.MainItemsPanel.Location = new System.Drawing.Point(12, 12);
            this.MainItemsPanel.Name = "MainItemsPanel";
            this.MainItemsPanel.Size = new System.Drawing.Size(734, 425);
            this.MainItemsPanel.TabIndex = 43;
            // 
            // AvailabilityDisclaimerLabel
            // 
            this.AvailabilityDisclaimerLabel.AutoSize = true;
            this.AvailabilityDisclaimerLabel.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvailabilityDisclaimerLabel.ForeColor = System.Drawing.Color.Red;
            this.AvailabilityDisclaimerLabel.Location = new System.Drawing.Point(144, 318);
            this.AvailabilityDisclaimerLabel.Name = "AvailabilityDisclaimerLabel";
            this.AvailabilityDisclaimerLabel.Size = new System.Drawing.Size(445, 54);
            this.AvailabilityDisclaimerLabel.TabIndex = 63;
            this.AvailabilityDisclaimerLabel.Text = "The Product You\'ve Chosen Is Unavailable!\r\nPlease Choose Something Else!\r\n";
            this.AvailabilityDisclaimerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AvailabilityDisclaimerLabel.Visible = false;
            // 
            // ColourListbox
            // 
            this.ColourListbox.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColourListbox.FormattingEnabled = true;
            this.ColourListbox.ItemHeight = 21;
            this.ColourListbox.Location = new System.Drawing.Point(127, 46);
            this.ColourListbox.Name = "ColourListbox";
            this.ColourListbox.Size = new System.Drawing.Size(80, 130);
            this.ColourListbox.TabIndex = 38;
            this.ColourListbox.SelectedIndexChanged += new System.EventHandler(this.ColourListbox_SelectedIndexChanged);
            // 
            // ColourLabel
            // 
            this.ColourLabel.AutoSize = true;
            this.ColourLabel.BackColor = System.Drawing.Color.Transparent;
            this.ColourLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColourLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ColourLabel.Location = new System.Drawing.Point(122, 16);
            this.ColourLabel.Name = "ColourLabel";
            this.ColourLabel.Size = new System.Drawing.Size(71, 24);
            this.ColourLabel.TabIndex = 39;
            this.ColourLabel.Text = "Colour:";
            this.ColourLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BottomPanel
            // 
            this.BottomPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BottomPanel.Controls.Add(this.ExitButton);
            this.BottomPanel.Controls.Add(this.LogoPicture);
            this.BottomPanel.Controls.Add(this.AdminButton);
            this.BottomPanel.Location = new System.Drawing.Point(12, 825);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(1142, 97);
            this.BottomPanel.TabIndex = 44;
            // 
            // AdminPanel
            // 
            this.AdminPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AdminPanel.Controls.Add(this.TransactionListbox);
            this.AdminPanel.Controls.Add(this.CartLabel);
            this.AdminPanel.Location = new System.Drawing.Point(12, 443);
            this.AdminPanel.Name = "AdminPanel";
            this.AdminPanel.Size = new System.Drawing.Size(888, 376);
            this.AdminPanel.TabIndex = 45;
            // 
            // TransactionListbox
            // 
            this.TransactionListbox.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransactionListbox.FormattingEnabled = true;
            this.TransactionListbox.ItemHeight = 21;
            this.TransactionListbox.Location = new System.Drawing.Point(20, 36);
            this.TransactionListbox.Name = "TransactionListbox";
            this.TransactionListbox.Size = new System.Drawing.Size(853, 319);
            this.TransactionListbox.TabIndex = 40;
            // 
            // CartLabel
            // 
            this.CartLabel.AutoSize = true;
            this.CartLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CartLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CartLabel.Location = new System.Drawing.Point(15, 9);
            this.CartLabel.Name = "CartLabel";
            this.CartLabel.Size = new System.Drawing.Size(121, 24);
            this.CartLabel.TabIndex = 39;
            this.CartLabel.Text = "Cart Preview:";
            this.CartLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CartButtonPanel
            // 
            this.CartButtonPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CartButtonPanel.Controls.Add(this.CartSavingsValueLabel);
            this.CartButtonPanel.Controls.Add(this.CartSavingsLabel);
            this.CartButtonPanel.Controls.Add(this.CartTaxValueLabel);
            this.CartButtonPanel.Controls.Add(this.CartTaxLabel);
            this.CartButtonPanel.Controls.Add(this.CartValueLabel);
            this.CartButtonPanel.Controls.Add(this.CartPriceLabel);
            this.CartButtonPanel.Controls.Add(this.ClearCartButton);
            this.CartButtonPanel.Controls.Add(this.ProceedButton);
            this.CartButtonPanel.Controls.Add(this.RemoveButton);
            this.CartButtonPanel.Location = new System.Drawing.Point(906, 443);
            this.CartButtonPanel.Name = "CartButtonPanel";
            this.CartButtonPanel.Size = new System.Drawing.Size(248, 376);
            this.CartButtonPanel.TabIndex = 41;
            // 
            // CartSavingsValueLabel
            // 
            this.CartSavingsValueLabel.AutoSize = true;
            this.CartSavingsValueLabel.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CartSavingsValueLabel.Location = new System.Drawing.Point(79, 267);
            this.CartSavingsValueLabel.Name = "CartSavingsValueLabel";
            this.CartSavingsValueLabel.Size = new System.Drawing.Size(101, 27);
            this.CartSavingsValueLabel.TabIndex = 69;
            this.CartSavingsValueLabel.Text = "0.00 EUR";
            // 
            // CartSavingsLabel
            // 
            this.CartSavingsLabel.AutoSize = true;
            this.CartSavingsLabel.BackColor = System.Drawing.Color.Transparent;
            this.CartSavingsLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CartSavingsLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CartSavingsLabel.Location = new System.Drawing.Point(91, 243);
            this.CartSavingsLabel.Name = "CartSavingsLabel";
            this.CartSavingsLabel.Size = new System.Drawing.Size(79, 24);
            this.CartSavingsLabel.TabIndex = 68;
            this.CartSavingsLabel.Text = "Savings:";
            this.CartSavingsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CartTaxValueLabel
            // 
            this.CartTaxValueLabel.AutoSize = true;
            this.CartTaxValueLabel.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CartTaxValueLabel.Location = new System.Drawing.Point(79, 205);
            this.CartTaxValueLabel.Name = "CartTaxValueLabel";
            this.CartTaxValueLabel.Size = new System.Drawing.Size(101, 27);
            this.CartTaxValueLabel.TabIndex = 67;
            this.CartTaxValueLabel.Text = "0.00 EUR";
            // 
            // CartTaxLabel
            // 
            this.CartTaxLabel.AutoSize = true;
            this.CartTaxLabel.BackColor = System.Drawing.Color.Transparent;
            this.CartTaxLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CartTaxLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CartTaxLabel.Location = new System.Drawing.Point(100, 181);
            this.CartTaxLabel.Name = "CartTaxLabel";
            this.CartTaxLabel.Size = new System.Drawing.Size(43, 24);
            this.CartTaxLabel.TabIndex = 66;
            this.CartTaxLabel.Text = "Tax:";
            this.CartTaxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CartValueLabel
            // 
            this.CartValueLabel.AutoSize = true;
            this.CartValueLabel.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CartValueLabel.Location = new System.Drawing.Point(79, 145);
            this.CartValueLabel.Name = "CartValueLabel";
            this.CartValueLabel.Size = new System.Drawing.Size(101, 27);
            this.CartValueLabel.TabIndex = 64;
            this.CartValueLabel.Text = "0.00 EUR";
            // 
            // CartPriceLabel
            // 
            this.CartPriceLabel.AutoSize = true;
            this.CartPriceLabel.BackColor = System.Drawing.Color.Transparent;
            this.CartPriceLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CartPriceLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CartPriceLabel.Location = new System.Drawing.Point(31, 121);
            this.CartPriceLabel.Name = "CartPriceLabel";
            this.CartPriceLabel.Size = new System.Drawing.Size(196, 24);
            this.CartPriceLabel.TabIndex = 63;
            this.CartPriceLabel.Text = "Total Price (With Tax):";
            this.CartPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClearCartButton
            // 
            this.ClearCartButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ClearCartButton.BackColor = System.Drawing.Color.LightCoral;
            this.ClearCartButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.ClearCartButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ClearCartButton.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearCartButton.ForeColor = System.Drawing.Color.Black;
            this.ClearCartButton.Location = new System.Drawing.Point(64, 19);
            this.ClearCartButton.Name = "ClearCartButton";
            this.ClearCartButton.Size = new System.Drawing.Size(128, 40);
            this.ClearCartButton.TabIndex = 53;
            this.ClearCartButton.Text = "&Clear Cart";
            this.MainToolTip.SetToolTip(this.ClearCartButton, "Clear Cart of Previous Selections");
            this.ClearCartButton.UseVisualStyleBackColor = false;
            this.ClearCartButton.Click += new System.EventHandler(this.ClearCartButton_Click);
            // 
            // ProceedButton
            // 
            this.ProceedButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ProceedButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(189)))));
            this.ProceedButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.ProceedButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ProceedButton.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProceedButton.ForeColor = System.Drawing.Color.Black;
            this.ProceedButton.Location = new System.Drawing.Point(65, 315);
            this.ProceedButton.Name = "ProceedButton";
            this.ProceedButton.Size = new System.Drawing.Size(128, 40);
            this.ProceedButton.TabIndex = 47;
            this.ProceedButton.Text = "&Proceed";
            this.MainToolTip.SetToolTip(this.ProceedButton, "Proceed to Pay");
            this.ProceedButton.UseVisualStyleBackColor = false;
            this.ProceedButton.Click += new System.EventHandler(this.ProceedButton_Click);
            // 
            // MainToolTip
            // 
            this.MainToolTip.IsBalloon = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1166, 932);
            this.Controls.Add(this.CartButtonPanel);
            this.Controls.Add(this.AdminPanel);
            this.Controls.Add(this.BottomPanel);
            this.Controls.Add(this.ItemPanel);
            this.Controls.Add(this.MainItemsPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Welcome to Riot, Guest!";
            this.ItemPanel.ResumeLayout(false);
            this.ItemPanel.PerformLayout();
            this.PricePanel.ResumeLayout(false);
            this.PricePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicture)).EndInit();
            this.MainItemsPanel.ResumeLayout(false);
            this.MainItemsPanel.PerformLayout();
            this.BottomPanel.ResumeLayout(false);
            this.AdminPanel.ResumeLayout(false);
            this.AdminPanel.PerformLayout();
            this.CartButtonPanel.ResumeLayout(false);
            this.CartButtonPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox ItemListbox;
        private System.Windows.Forms.ListBox SizeListbox;
        private System.Windows.Forms.Label ItemLabel;
        private System.Windows.Forms.Label SizeLabel;
        private System.Windows.Forms.Panel ItemPanel;
        private System.Windows.Forms.PictureBox LogoPicture;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button AdminButton;
        private System.Windows.Forms.Panel MainItemsPanel;
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.Panel AdminPanel;
        private System.Windows.Forms.ListBox TransactionListbox;
        private System.Windows.Forms.Label CartLabel;
        private System.Windows.Forms.Panel CartButtonPanel;
        private System.Windows.Forms.Button ClearCartButton;
        private System.Windows.Forms.Button ProceedButton;
        private System.Windows.Forms.ListBox ColourListbox;
        private System.Windows.Forms.Label ColourLabel;
        private System.Windows.Forms.Label TotalPriceValueLabel;
        private System.Windows.Forms.Label TotalPriceLabel;
        private System.Windows.Forms.Label UnitPriceLabel;
        private System.Windows.Forms.Label StockWarningLabel;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button SubtractButton;
        private System.Windows.Forms.Button AddItemButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox QuantityTextbox;
        private System.Windows.Forms.Label UnitPriceValueLabel;
        private System.Windows.Forms.Label CartValueLabel;
        private System.Windows.Forms.Label CartPriceLabel;
        private System.Windows.Forms.Label CartTaxValueLabel;
        private System.Windows.Forms.Label CartTaxLabel;
        private System.Windows.Forms.Label AvailabilityDisclaimerLabel;
        private System.Windows.Forms.Label TaxValueLabel;
        private System.Windows.Forms.Label TaxLabel;
        private System.Windows.Forms.Label OriginalPriceValueLabel;
        private System.Windows.Forms.Label OriginalPriceLabel;
        private System.Windows.Forms.Panel PricePanel;
        private System.Windows.Forms.Label SavingsValueLabel;
        private System.Windows.Forms.Label SavingsLabel;
        private System.Windows.Forms.Label CartSavingsValueLabel;
        private System.Windows.Forms.Label CartSavingsLabel;
        private System.Windows.Forms.ToolTip MainToolTip;
    }
}

