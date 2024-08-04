namespace Riot_EPOS
{
    partial class SalesReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesReportForm));
            this.DailySalesReportListbox = new System.Windows.Forms.ListBox();
            this.ReportLabel = new System.Windows.Forms.Label();
            this.LogoPicture = new System.Windows.Forms.PictureBox();
            this.BackToBillingButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.BackToAdminButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // DailySalesReportListbox
            // 
            this.DailySalesReportListbox.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DailySalesReportListbox.FormattingEnabled = true;
            this.DailySalesReportListbox.ItemHeight = 21;
            this.DailySalesReportListbox.Location = new System.Drawing.Point(12, 60);
            this.DailySalesReportListbox.Name = "DailySalesReportListbox";
            this.DailySalesReportListbox.Size = new System.Drawing.Size(803, 445);
            this.DailySalesReportListbox.TabIndex = 0;
            // 
            // ReportLabel
            // 
            this.ReportLabel.AutoSize = true;
            this.ReportLabel.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportLabel.Location = new System.Drawing.Point(336, 20);
            this.ReportLabel.Name = "ReportLabel";
            this.ReportLabel.Size = new System.Drawing.Size(137, 27);
            this.ReportLabel.TabIndex = 1;
            this.ReportLabel.Text = "Daily Report";
            // 
            // LogoPicture
            // 
            this.LogoPicture.Image = ((System.Drawing.Image)(resources.GetObject("LogoPicture.Image")));
            this.LogoPicture.Location = new System.Drawing.Point(12, 511);
            this.LogoPicture.Name = "LogoPicture";
            this.LogoPicture.Size = new System.Drawing.Size(129, 110);
            this.LogoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoPicture.TabIndex = 41;
            this.LogoPicture.TabStop = false;
            // 
            // BackToBillingButton
            // 
            this.BackToBillingButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(189)))));
            this.BackToBillingButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.BackToBillingButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BackToBillingButton.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackToBillingButton.ForeColor = System.Drawing.Color.Black;
            this.BackToBillingButton.Location = new System.Drawing.Point(559, 539);
            this.BackToBillingButton.Name = "BackToBillingButton";
            this.BackToBillingButton.Size = new System.Drawing.Size(129, 62);
            this.BackToBillingButton.TabIndex = 39;
            this.BackToBillingButton.Text = "&Back to \r\nBilling";
            this.BackToBillingButton.UseVisualStyleBackColor = false;
            this.BackToBillingButton.Click += new System.EventHandler(this.BackToBillingButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.Color.Black;
            this.ExitButton.Location = new System.Drawing.Point(698, 539);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(117, 62);
            this.ExitButton.TabIndex = 40;
            this.ExitButton.Text = "&Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(189)))));
            this.SaveButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SaveButton.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.ForeColor = System.Drawing.Color.Black;
            this.SaveButton.Location = new System.Drawing.Point(154, 539);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(129, 62);
            this.SaveButton.TabIndex = 42;
            this.SaveButton.Text = "&Save Report";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(189)))));
            this.ClearButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ClearButton.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.ForeColor = System.Drawing.Color.Black;
            this.ClearButton.Location = new System.Drawing.Point(289, 539);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(129, 62);
            this.ClearButton.TabIndex = 43;
            this.ClearButton.Text = "&Clear Report";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // BackToAdminButton
            // 
            this.BackToAdminButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(189)))));
            this.BackToAdminButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.BackToAdminButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BackToAdminButton.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackToAdminButton.ForeColor = System.Drawing.Color.Black;
            this.BackToAdminButton.Location = new System.Drawing.Point(424, 539);
            this.BackToAdminButton.Name = "BackToAdminButton";
            this.BackToAdminButton.Size = new System.Drawing.Size(129, 62);
            this.BackToAdminButton.TabIndex = 44;
            this.BackToAdminButton.Text = "&Back to Admin";
            this.BackToAdminButton.UseVisualStyleBackColor = false;
            this.BackToAdminButton.Click += new System.EventHandler(this.BackToAdminButton_Click);
            // 
            // SalesReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 630);
            this.Controls.Add(this.BackToAdminButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.LogoPicture);
            this.Controls.Add(this.BackToBillingButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ReportLabel);
            this.Controls.Add(this.DailySalesReportListbox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SalesReportForm";
            this.Text = "Sales Report";
            this.Load += new System.EventHandler(this.SalesReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox DailySalesReportListbox;
        private System.Windows.Forms.Label ReportLabel;
        private System.Windows.Forms.PictureBox LogoPicture;
        private System.Windows.Forms.Button BackToBillingButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button BackToAdminButton;
    }
}