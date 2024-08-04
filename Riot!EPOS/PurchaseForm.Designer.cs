namespace Riot_EPOS
{
    partial class PurchaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchaseForm));
            this.DateLabel = new System.Windows.Forms.Label();
            this.TransactionIDLabel = new System.Windows.Forms.Label();
            this.CartButtonPanel = new System.Windows.Forms.Panel();
            this.AddItemsButton = new System.Windows.Forms.Button();
            this.CouponStatusLabel = new System.Windows.Forms.Label();
            this.ApplyCouponButton = new System.Windows.Forms.Button();
            this.CouponTextbox = new System.Windows.Forms.TextBox();
            this.CouponLabel = new System.Windows.Forms.Label();
            this.AdminPanel = new System.Windows.Forms.Panel();
            this.TransactionListbox = new System.Windows.Forms.ListBox();
            this.CartLabel = new System.Windows.Forms.Label();
            this.PaymentPanel = new System.Windows.Forms.Panel();
            this.CancelButton = new System.Windows.Forms.Button();
            this.CashPaymentButton = new System.Windows.Forms.Button();
            this.CardPaymentButton = new System.Windows.Forms.Button();
            this.FinalAmountLabel = new System.Windows.Forms.Label();
            this.ItemCountLabel = new System.Windows.Forms.Label();
            this.TransactionInfoLabel = new System.Windows.Forms.Label();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.ExitButton = new System.Windows.Forms.Button();
            this.LogoPicture = new System.Windows.Forms.PictureBox();
            this.AdminButton = new System.Windows.Forms.Button();
            this.CartButtonPanel.SuspendLayout();
            this.AdminPanel.SuspendLayout();
            this.PaymentPanel.SuspendLayout();
            this.BottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(103)))), ((int)(((byte)(110)))));
            this.DateLabel.Location = new System.Drawing.Point(193, 74);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(58, 22);
            this.DateLabel.TabIndex = 1;
            this.DateLabel.Text = "Date: ";
            // 
            // TransactionIDLabel
            // 
            this.TransactionIDLabel.AutoSize = true;
            this.TransactionIDLabel.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransactionIDLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(103)))), ((int)(((byte)(110)))));
            this.TransactionIDLabel.Location = new System.Drawing.Point(114, 43);
            this.TransactionIDLabel.Name = "TransactionIDLabel";
            this.TransactionIDLabel.Size = new System.Drawing.Size(137, 22);
            this.TransactionIDLabel.TabIndex = 0;
            this.TransactionIDLabel.Text = "Transaction ID: ";
            // 
            // CartButtonPanel
            // 
            this.CartButtonPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CartButtonPanel.Controls.Add(this.AddItemsButton);
            this.CartButtonPanel.Controls.Add(this.CouponStatusLabel);
            this.CartButtonPanel.Controls.Add(this.ApplyCouponButton);
            this.CartButtonPanel.Controls.Add(this.CouponTextbox);
            this.CartButtonPanel.Controls.Add(this.CouponLabel);
            this.CartButtonPanel.Location = new System.Drawing.Point(986, 12);
            this.CartButtonPanel.Name = "CartButtonPanel";
            this.CartButtonPanel.Size = new System.Drawing.Size(168, 321);
            this.CartButtonPanel.TabIndex = 46;
            // 
            // AddItemsButton
            // 
            this.AddItemsButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddItemsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(189)))));
            this.AddItemsButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.AddItemsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddItemsButton.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddItemsButton.ForeColor = System.Drawing.Color.Black;
            this.AddItemsButton.Location = new System.Drawing.Point(20, 249);
            this.AddItemsButton.Name = "AddItemsButton";
            this.AddItemsButton.Size = new System.Drawing.Size(128, 56);
            this.AddItemsButton.TabIndex = 54;
            this.AddItemsButton.Text = "&Add More \r\nItems\r\n";
            this.AddItemsButton.UseVisualStyleBackColor = false;
            this.AddItemsButton.Click += new System.EventHandler(this.AddItemsButton_Click);
            // 
            // CouponStatusLabel
            // 
            this.CouponStatusLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CouponStatusLabel.AutoSize = true;
            this.CouponStatusLabel.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CouponStatusLabel.ForeColor = System.Drawing.Color.Red;
            this.CouponStatusLabel.Location = new System.Drawing.Point(31, 149);
            this.CouponStatusLabel.Name = "CouponStatusLabel";
            this.CouponStatusLabel.Size = new System.Drawing.Size(105, 42);
            this.CouponStatusLabel.TabIndex = 51;
            this.CouponStatusLabel.Text = "Applied \r\nSuccessfully!";
            this.CouponStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CouponStatusLabel.Visible = false;
            // 
            // ApplyCouponButton
            // 
            this.ApplyCouponButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ApplyCouponButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ApplyCouponButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.ApplyCouponButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ApplyCouponButton.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApplyCouponButton.ForeColor = System.Drawing.Color.Black;
            this.ApplyCouponButton.Location = new System.Drawing.Point(20, 91);
            this.ApplyCouponButton.Name = "ApplyCouponButton";
            this.ApplyCouponButton.Size = new System.Drawing.Size(128, 40);
            this.ApplyCouponButton.TabIndex = 52;
            this.ApplyCouponButton.Text = "&Apply";
            this.ApplyCouponButton.UseVisualStyleBackColor = false;
            // 
            // CouponTextbox
            // 
            this.CouponTextbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CouponTextbox.BackColor = System.Drawing.Color.White;
            this.CouponTextbox.Location = new System.Drawing.Point(19, 49);
            this.CouponTextbox.Name = "CouponTextbox";
            this.CouponTextbox.Size = new System.Drawing.Size(129, 26);
            this.CouponTextbox.TabIndex = 48;
            this.CouponTextbox.Text = "Zkasj1";
            this.CouponTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CouponTextbox.TextChanged += new System.EventHandler(this.CouponTextbox_TextChanged);
            // 
            // CouponLabel
            // 
            this.CouponLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CouponLabel.AutoSize = true;
            this.CouponLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CouponLabel.Location = new System.Drawing.Point(11, 26);
            this.CouponLabel.Name = "CouponLabel";
            this.CouponLabel.Size = new System.Drawing.Size(154, 20);
            this.CouponLabel.TabIndex = 49;
            this.CouponLabel.Text = "Enter Coupon Code:";
            this.CouponLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AdminPanel
            // 
            this.AdminPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AdminPanel.Controls.Add(this.TransactionListbox);
            this.AdminPanel.Controls.Add(this.CartLabel);
            this.AdminPanel.Location = new System.Drawing.Point(12, 12);
            this.AdminPanel.Name = "AdminPanel";
            this.AdminPanel.Size = new System.Drawing.Size(968, 321);
            this.AdminPanel.TabIndex = 47;
            // 
            // TransactionListbox
            // 
            this.TransactionListbox.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransactionListbox.FormattingEnabled = true;
            this.TransactionListbox.ItemHeight = 21;
            this.TransactionListbox.Location = new System.Drawing.Point(20, 36);
            this.TransactionListbox.Name = "TransactionListbox";
            this.TransactionListbox.Size = new System.Drawing.Size(919, 256);
            this.TransactionListbox.TabIndex = 40;
            // 
            // CartLabel
            // 
            this.CartLabel.AutoSize = true;
            this.CartLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CartLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CartLabel.Location = new System.Drawing.Point(15, 9);
            this.CartLabel.Name = "CartLabel";
            this.CartLabel.Size = new System.Drawing.Size(50, 24);
            this.CartLabel.TabIndex = 39;
            this.CartLabel.Text = "Cart:";
            this.CartLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PaymentPanel
            // 
            this.PaymentPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PaymentPanel.Controls.Add(this.CancelButton);
            this.PaymentPanel.Controls.Add(this.CashPaymentButton);
            this.PaymentPanel.Controls.Add(this.CardPaymentButton);
            this.PaymentPanel.Controls.Add(this.FinalAmountLabel);
            this.PaymentPanel.Controls.Add(this.ItemCountLabel);
            this.PaymentPanel.Controls.Add(this.TransactionInfoLabel);
            this.PaymentPanel.Controls.Add(this.DateLabel);
            this.PaymentPanel.Controls.Add(this.TransactionIDLabel);
            this.PaymentPanel.Location = new System.Drawing.Point(12, 339);
            this.PaymentPanel.Name = "PaymentPanel";
            this.PaymentPanel.Size = new System.Drawing.Size(968, 191);
            this.PaymentPanel.TabIndex = 31;
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CancelButton.BackColor = System.Drawing.Color.LightCoral;
            this.CancelButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CancelButton.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.ForeColor = System.Drawing.Color.Black;
            this.CancelButton.Location = new System.Drawing.Point(746, 125);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(204, 45);
            this.CancelButton.TabIndex = 55;
            this.CancelButton.Text = "&Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            // 
            // CashPaymentButton
            // 
            this.CashPaymentButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CashPaymentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(189)))));
            this.CashPaymentButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.CashPaymentButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CashPaymentButton.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashPaymentButton.ForeColor = System.Drawing.Color.Black;
            this.CashPaymentButton.Location = new System.Drawing.Point(746, 71);
            this.CashPaymentButton.Name = "CashPaymentButton";
            this.CashPaymentButton.Size = new System.Drawing.Size(204, 45);
            this.CashPaymentButton.TabIndex = 54;
            this.CashPaymentButton.Text = "&Pay with Cash";
            this.CashPaymentButton.UseVisualStyleBackColor = false;
            // 
            // CardPaymentButton
            // 
            this.CardPaymentButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CardPaymentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(189)))));
            this.CardPaymentButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.CardPaymentButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CardPaymentButton.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardPaymentButton.ForeColor = System.Drawing.Color.Black;
            this.CardPaymentButton.Location = new System.Drawing.Point(746, 20);
            this.CardPaymentButton.Name = "CardPaymentButton";
            this.CardPaymentButton.Size = new System.Drawing.Size(204, 45);
            this.CardPaymentButton.TabIndex = 53;
            this.CardPaymentButton.Text = "&Pay with Card";
            this.CardPaymentButton.UseVisualStyleBackColor = false;
            // 
            // FinalAmountLabel
            // 
            this.FinalAmountLabel.AutoSize = true;
            this.FinalAmountLabel.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinalAmountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(103)))), ((int)(((byte)(110)))));
            this.FinalAmountLabel.Location = new System.Drawing.Point(90, 139);
            this.FinalAmountLabel.Name = "FinalAmountLabel";
            this.FinalAmountLabel.Size = new System.Drawing.Size(161, 22);
            this.FinalAmountLabel.TabIndex = 45;
            this.FinalAmountLabel.Text = "Total (To Be Paid):";
            // 
            // ItemCountLabel
            // 
            this.ItemCountLabel.AutoSize = true;
            this.ItemCountLabel.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemCountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(103)))), ((int)(((byte)(110)))));
            this.ItemCountLabel.Location = new System.Drawing.Point(145, 107);
            this.ItemCountLabel.Name = "ItemCountLabel";
            this.ItemCountLabel.Size = new System.Drawing.Size(106, 22);
            this.ItemCountLabel.TabIndex = 43;
            this.ItemCountLabel.Text = "Item Count:";
            // 
            // TransactionInfoLabel
            // 
            this.TransactionInfoLabel.AutoSize = true;
            this.TransactionInfoLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransactionInfoLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TransactionInfoLabel.Location = new System.Drawing.Point(292, 9);
            this.TransactionInfoLabel.Name = "TransactionInfoLabel";
            this.TransactionInfoLabel.Size = new System.Drawing.Size(147, 24);
            this.TransactionInfoLabel.TabIndex = 40;
            this.TransactionInfoLabel.Text = "Transaction Info";
            this.TransactionInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BottomPanel
            // 
            this.BottomPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BottomPanel.Controls.Add(this.ExitButton);
            this.BottomPanel.Controls.Add(this.LogoPicture);
            this.BottomPanel.Controls.Add(this.AdminButton);
            this.BottomPanel.Location = new System.Drawing.Point(986, 339);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(168, 191);
            this.BottomPanel.TabIndex = 48;
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.Color.Black;
            this.ExitButton.Location = new System.Drawing.Point(17, 141);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(129, 33);
            this.ExitButton.TabIndex = 40;
            this.ExitButton.Text = "&Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // LogoPicture
            // 
            this.LogoPicture.Image = ((System.Drawing.Image)(resources.GetObject("LogoPicture.Image")));
            this.LogoPicture.Location = new System.Drawing.Point(17, 26);
            this.LogoPicture.Name = "LogoPicture";
            this.LogoPicture.Size = new System.Drawing.Size(131, 70);
            this.LogoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoPicture.TabIndex = 41;
            this.LogoPicture.TabStop = false;
            // 
            // AdminButton
            // 
            this.AdminButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(189)))));
            this.AdminButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.AdminButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AdminButton.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminButton.ForeColor = System.Drawing.Color.Black;
            this.AdminButton.Location = new System.Drawing.Point(17, 102);
            this.AdminButton.Name = "AdminButton";
            this.AdminButton.Size = new System.Drawing.Size(129, 33);
            this.AdminButton.TabIndex = 39;
            this.AdminButton.Text = "&Admin Tools";
            this.AdminButton.UseVisualStyleBackColor = false;
            this.AdminButton.Click += new System.EventHandler(this.AdminButton_Click);
            // 
            // PurchaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 541);
            this.Controls.Add(this.BottomPanel);
            this.Controls.Add(this.PaymentPanel);
            this.Controls.Add(this.CartButtonPanel);
            this.Controls.Add(this.AdminPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PurchaseForm";
            this.Text = "Purchase";
            this.Load += new System.EventHandler(this.PurchaseForm_Load);
            this.CartButtonPanel.ResumeLayout(false);
            this.CartButtonPanel.PerformLayout();
            this.AdminPanel.ResumeLayout(false);
            this.AdminPanel.PerformLayout();
            this.PaymentPanel.ResumeLayout(false);
            this.PaymentPanel.PerformLayout();
            this.BottomPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label TransactionIDLabel;
        private System.Windows.Forms.Panel CartButtonPanel;
        private System.Windows.Forms.Label CouponStatusLabel;
        private System.Windows.Forms.Button ApplyCouponButton;
        private System.Windows.Forms.TextBox CouponTextbox;
        private System.Windows.Forms.Label CouponLabel;
        private System.Windows.Forms.Panel AdminPanel;
        private System.Windows.Forms.ListBox TransactionListbox;
        private System.Windows.Forms.Label CartLabel;
        private System.Windows.Forms.Panel PaymentPanel;
        private System.Windows.Forms.Label TransactionInfoLabel;
        private System.Windows.Forms.Label FinalAmountLabel;
        private System.Windows.Forms.Label ItemCountLabel;
        private System.Windows.Forms.Button AddItemsButton;
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.PictureBox LogoPicture;
        private System.Windows.Forms.Button AdminButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button CashPaymentButton;
        private System.Windows.Forms.Button CardPaymentButton;
    }
}