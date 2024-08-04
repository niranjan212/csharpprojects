namespace Riot_EPOS
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.LoginButton = new System.Windows.Forms.Button();
            this.GenerateStockButton = new System.Windows.Forms.Button();
            this.GenerateDailySalesButton = new System.Windows.Forms.Button();
            this.LogoPicture = new System.Windows.Forms.PictureBox();
            this.StockCloseButton = new System.Windows.Forms.Button();
            this.StockOpenButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SearchPanel = new System.Windows.Forms.Panel();
            this.SearchPanelLabel = new System.Windows.Forms.Label();
            this.TransactionIDSearchTextBox = new System.Windows.Forms.TextBox();
            this.ResultInfoLabel = new System.Windows.Forms.Label();
            this.TransactionIDSearchLabel = new System.Windows.Forms.Label();
            this.DateSearchLabel = new System.Windows.Forms.Label();
            this.ClearSearchButton = new System.Windows.Forms.Button();
            this.DateSearchTextBox = new System.Windows.Forms.TextBox();
            this.SearchListBox = new System.Windows.Forms.ListBox();
            this.SearchInfoButton = new System.Windows.Forms.Button();
            this.BottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicture)).BeginInit();
            this.SearchPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BottomPanel
            // 
            this.BottomPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BottomPanel.Controls.Add(this.LoginButton);
            this.BottomPanel.Controls.Add(this.GenerateStockButton);
            this.BottomPanel.Controls.Add(this.GenerateDailySalesButton);
            this.BottomPanel.Controls.Add(this.LogoPicture);
            this.BottomPanel.Controls.Add(this.StockCloseButton);
            this.BottomPanel.Controls.Add(this.StockOpenButton);
            this.BottomPanel.Controls.Add(this.BackButton);
            this.BottomPanel.Controls.Add(this.ExitButton);
            this.BottomPanel.Location = new System.Drawing.Point(1001, 12);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(166, 645);
            this.BottomPanel.TabIndex = 45;
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(189)))));
            this.LoginButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LoginButton.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.Color.Black;
            this.LoginButton.Location = new System.Drawing.Point(18, 21);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(129, 62);
            this.LoginButton.TabIndex = 42;
            this.LoginButton.Text = "&Login";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // GenerateStockButton
            // 
            this.GenerateStockButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(189)))));
            this.GenerateStockButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.GenerateStockButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GenerateStockButton.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerateStockButton.ForeColor = System.Drawing.Color.Black;
            this.GenerateStockButton.Location = new System.Drawing.Point(17, 350);
            this.GenerateStockButton.Name = "GenerateStockButton";
            this.GenerateStockButton.Size = new System.Drawing.Size(129, 62);
            this.GenerateStockButton.TabIndex = 41;
            this.GenerateStockButton.Text = "&Generate Stock Report";
            this.GenerateStockButton.UseVisualStyleBackColor = false;
            this.GenerateStockButton.Click += new System.EventHandler(this.GenerateStockButton_Click);
            // 
            // GenerateDailySalesButton
            // 
            this.GenerateDailySalesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(189)))));
            this.GenerateDailySalesButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.GenerateDailySalesButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GenerateDailySalesButton.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerateDailySalesButton.ForeColor = System.Drawing.Color.Black;
            this.GenerateDailySalesButton.Location = new System.Drawing.Point(18, 278);
            this.GenerateDailySalesButton.Name = "GenerateDailySalesButton";
            this.GenerateDailySalesButton.Size = new System.Drawing.Size(129, 62);
            this.GenerateDailySalesButton.TabIndex = 40;
            this.GenerateDailySalesButton.Text = "&Generate Daily Report";
            this.GenerateDailySalesButton.UseVisualStyleBackColor = false;
            this.GenerateDailySalesButton.Click += new System.EventHandler(this.GenerateDailySalesButton_Click);
            // 
            // LogoPicture
            // 
            this.LogoPicture.Image = ((System.Drawing.Image)(resources.GetObject("LogoPicture.Image")));
            this.LogoPicture.Location = new System.Drawing.Point(18, 530);
            this.LogoPicture.Name = "LogoPicture";
            this.LogoPicture.Size = new System.Drawing.Size(129, 101);
            this.LogoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoPicture.TabIndex = 38;
            this.LogoPicture.TabStop = false;
            // 
            // StockCloseButton
            // 
            this.StockCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(189)))));
            this.StockCloseButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.StockCloseButton.Enabled = false;
            this.StockCloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.StockCloseButton.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockCloseButton.ForeColor = System.Drawing.Color.Black;
            this.StockCloseButton.Location = new System.Drawing.Point(18, 181);
            this.StockCloseButton.Name = "StockCloseButton";
            this.StockCloseButton.Size = new System.Drawing.Size(129, 62);
            this.StockCloseButton.TabIndex = 39;
            this.StockCloseButton.Text = "&Close Stock Records";
            this.StockCloseButton.UseVisualStyleBackColor = false;
            this.StockCloseButton.Click += new System.EventHandler(this.StockCloseButton_Click);
            // 
            // StockOpenButton
            // 
            this.StockOpenButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(189)))));
            this.StockOpenButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.StockOpenButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.StockOpenButton.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockOpenButton.ForeColor = System.Drawing.Color.Black;
            this.StockOpenButton.Location = new System.Drawing.Point(18, 113);
            this.StockOpenButton.Name = "StockOpenButton";
            this.StockOpenButton.Size = new System.Drawing.Size(129, 62);
            this.StockOpenButton.TabIndex = 38;
            this.StockOpenButton.Text = "&Open Stock Records";
            this.StockOpenButton.UseVisualStyleBackColor = false;
            this.StockOpenButton.Click += new System.EventHandler(this.StockOpenButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(189)))));
            this.BackButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BackButton.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.ForeColor = System.Drawing.Color.Black;
            this.BackButton.Location = new System.Drawing.Point(18, 423);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(129, 62);
            this.BackButton.TabIndex = 36;
            this.BackButton.Text = "&Back to \r\nBilling";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.Color.Black;
            this.ExitButton.Location = new System.Drawing.Point(18, 491);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(129, 33);
            this.ExitButton.TabIndex = 37;
            this.ExitButton.Text = "&Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            // 
            // SearchPanel
            // 
            this.SearchPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SearchPanel.Controls.Add(this.SearchPanelLabel);
            this.SearchPanel.Controls.Add(this.TransactionIDSearchTextBox);
            this.SearchPanel.Controls.Add(this.ResultInfoLabel);
            this.SearchPanel.Controls.Add(this.TransactionIDSearchLabel);
            this.SearchPanel.Controls.Add(this.DateSearchLabel);
            this.SearchPanel.Controls.Add(this.ClearSearchButton);
            this.SearchPanel.Controls.Add(this.DateSearchTextBox);
            this.SearchPanel.Controls.Add(this.SearchListBox);
            this.SearchPanel.Controls.Add(this.SearchInfoButton);
            this.SearchPanel.Location = new System.Drawing.Point(12, 12);
            this.SearchPanel.Name = "SearchPanel";
            this.SearchPanel.Size = new System.Drawing.Size(983, 645);
            this.SearchPanel.TabIndex = 46;
            // 
            // SearchPanelLabel
            // 
            this.SearchPanelLabel.AutoSize = true;
            this.SearchPanelLabel.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchPanelLabel.Location = new System.Drawing.Point(411, 37);
            this.SearchPanelLabel.Name = "SearchPanelLabel";
            this.SearchPanelLabel.Size = new System.Drawing.Size(213, 27);
            this.SearchPanelLabel.TabIndex = 47;
            this.SearchPanelLabel.Text = "Search Transactions";
            // 
            // TransactionIDSearchTextBox
            // 
            this.TransactionIDSearchTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransactionIDSearchTextBox.Location = new System.Drawing.Point(416, 484);
            this.TransactionIDSearchTextBox.Name = "TransactionIDSearchTextBox";
            this.TransactionIDSearchTextBox.Size = new System.Drawing.Size(195, 29);
            this.TransactionIDSearchTextBox.TabIndex = 14;
            this.TransactionIDSearchTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ResultInfoLabel
            // 
            this.ResultInfoLabel.AutoSize = true;
            this.ResultInfoLabel.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultInfoLabel.ForeColor = System.Drawing.Color.Red;
            this.ResultInfoLabel.Location = new System.Drawing.Point(333, 411);
            this.ResultInfoLabel.Name = "ResultInfoLabel";
            this.ResultInfoLabel.Size = new System.Drawing.Size(345, 22);
            this.ResultInfoLabel.TabIndex = 35;
            this.ResultInfoLabel.Text = "We Found Results for the Txn ID Entered!";
            this.ResultInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TransactionIDSearchLabel
            // 
            this.TransactionIDSearchLabel.AutoSize = true;
            this.TransactionIDSearchLabel.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransactionIDSearchLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(103)))), ((int)(((byte)(110)))));
            this.TransactionIDSearchLabel.Location = new System.Drawing.Point(278, 484);
            this.TransactionIDSearchLabel.Name = "TransactionIDSearchLabel";
            this.TransactionIDSearchLabel.Size = new System.Drawing.Size(132, 22);
            this.TransactionIDSearchLabel.TabIndex = 31;
            this.TransactionIDSearchLabel.Text = "Transaction ID:";
            this.TransactionIDSearchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DateSearchLabel
            // 
            this.DateSearchLabel.AutoSize = true;
            this.DateSearchLabel.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateSearchLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(103)))), ((int)(((byte)(110)))));
            this.DateSearchLabel.Location = new System.Drawing.Point(357, 450);
            this.DateSearchLabel.Name = "DateSearchLabel";
            this.DateSearchLabel.Size = new System.Drawing.Size(53, 22);
            this.DateSearchLabel.TabIndex = 30;
            this.DateSearchLabel.Text = "Date:";
            this.DateSearchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClearSearchButton
            // 
            this.ClearSearchButton.BackColor = System.Drawing.Color.Transparent;
            this.ClearSearchButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.ClearSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ClearSearchButton.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearSearchButton.ForeColor = System.Drawing.Color.Black;
            this.ClearSearchButton.Location = new System.Drawing.Point(416, 576);
            this.ClearSearchButton.Name = "ClearSearchButton";
            this.ClearSearchButton.Size = new System.Drawing.Size(195, 40);
            this.ClearSearchButton.TabIndex = 16;
            this.ClearSearchButton.Text = "&Clear";
            this.ClearSearchButton.UseVisualStyleBackColor = false;
            // 
            // DateSearchTextBox
            // 
            this.DateSearchTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateSearchTextBox.Location = new System.Drawing.Point(416, 450);
            this.DateSearchTextBox.Name = "DateSearchTextBox";
            this.DateSearchTextBox.Size = new System.Drawing.Size(195, 29);
            this.DateSearchTextBox.TabIndex = 13;
            this.DateSearchTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SearchListBox
            // 
            this.SearchListBox.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchListBox.FormattingEnabled = true;
            this.SearchListBox.HorizontalScrollbar = true;
            this.SearchListBox.ItemHeight = 21;
            this.SearchListBox.Items.AddRange(new object[] {
            "kkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkk" +
                "kkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkk"});
            this.SearchListBox.Location = new System.Drawing.Point(223, 91);
            this.SearchListBox.Name = "SearchListBox";
            this.SearchListBox.ScrollAlwaysVisible = true;
            this.SearchListBox.Size = new System.Drawing.Size(557, 298);
            this.SearchListBox.TabIndex = 21;
            // 
            // SearchInfoButton
            // 
            this.SearchInfoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(189)))));
            this.SearchInfoButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.SearchInfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SearchInfoButton.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchInfoButton.ForeColor = System.Drawing.Color.Black;
            this.SearchInfoButton.Location = new System.Drawing.Point(416, 530);
            this.SearchInfoButton.Name = "SearchInfoButton";
            this.SearchInfoButton.Size = new System.Drawing.Size(195, 40);
            this.SearchInfoButton.TabIndex = 15;
            this.SearchInfoButton.Text = "&Search";
            this.SearchInfoButton.UseVisualStyleBackColor = false;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 669);
            this.Controls.Add(this.SearchPanel);
            this.Controls.Add(this.BottomPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminForm";
            this.Text = "Hello, Admin!";
            this.BottomPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicture)).EndInit();
            this.SearchPanel.ResumeLayout(false);
            this.SearchPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.PictureBox LogoPicture;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button StockCloseButton;
        private System.Windows.Forms.Button StockOpenButton;
        private System.Windows.Forms.Button GenerateStockButton;
        private System.Windows.Forms.Button GenerateDailySalesButton;
        private System.Windows.Forms.Panel SearchPanel;
        private System.Windows.Forms.TextBox TransactionIDSearchTextBox;
        private System.Windows.Forms.Label ResultInfoLabel;
        private System.Windows.Forms.Label TransactionIDSearchLabel;
        private System.Windows.Forms.Label DateSearchLabel;
        private System.Windows.Forms.Button ClearSearchButton;
        private System.Windows.Forms.TextBox DateSearchTextBox;
        private System.Windows.Forms.ListBox SearchListBox;
        private System.Windows.Forms.Button SearchInfoButton;
        private System.Windows.Forms.Label SearchPanelLabel;
        private System.Windows.Forms.Button LoginButton;
    }
}