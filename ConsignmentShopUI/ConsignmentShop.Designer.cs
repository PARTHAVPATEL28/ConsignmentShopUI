namespace ConsignmentShopUI
{
    partial class ConsignmentShop
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
            this.headerText = new System.Windows.Forms.Label();
            this.itemsListbox = new System.Windows.Forms.ListBox();
            this.itemsListboxLabels = new System.Windows.Forms.Label();
            this.addTocart = new System.Windows.Forms.Button();
            this.shopppingCartListboxLabel = new System.Windows.Forms.Label();
            this.shoppingCartListBox = new System.Windows.Forms.ListBox();
            this.makePurchase = new System.Windows.Forms.Button();
            this.vendorListboxLabel = new System.Windows.Forms.Label();
            this.vendorListbox = new System.Windows.Forms.ListBox();
            this.storePayoutLabel = new System.Windows.Forms.Label();
            this.storePaymentLabel = new System.Windows.Forms.Label();
            this.storePayment = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // headerText
            // 
            this.headerText.AutoSize = true;
            this.headerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerText.Location = new System.Drawing.Point(30, 34);
            this.headerText.Name = "headerText";
            this.headerText.Size = new System.Drawing.Size(597, 55);
            this.headerText.TabIndex = 0;
            this.headerText.Text = "Consignment Shop Demo";
            // 
            // itemsListbox
            // 
            this.itemsListbox.FormattingEnabled = true;
            this.itemsListbox.ItemHeight = 29;
            this.itemsListbox.Location = new System.Drawing.Point(40, 139);
            this.itemsListbox.Name = "itemsListbox";
            this.itemsListbox.Size = new System.Drawing.Size(300, 178);
            this.itemsListbox.TabIndex = 1;
            // 
            // itemsListboxLabels
            // 
            this.itemsListboxLabels.AutoSize = true;
            this.itemsListboxLabels.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemsListboxLabels.Location = new System.Drawing.Point(35, 107);
            this.itemsListboxLabels.Name = "itemsListboxLabels";
            this.itemsListboxLabels.Size = new System.Drawing.Size(146, 29);
            this.itemsListboxLabels.TabIndex = 2;
            this.itemsListboxLabels.Text = "Store Items";
            // 
            // addTocart
            // 
            this.addTocart.Location = new System.Drawing.Point(356, 189);
            this.addTocart.Name = "addTocart";
            this.addTocart.Size = new System.Drawing.Size(186, 60);
            this.addTocart.TabIndex = 3;
            this.addTocart.Text = "Add To Cart ->\r\n";
            this.addTocart.UseVisualStyleBackColor = true;
            this.addTocart.Click += new System.EventHandler(this.addTocart_Click);
            // 
            // shopppingCartListboxLabel
            // 
            this.shopppingCartListboxLabel.AutoSize = true;
            this.shopppingCartListboxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shopppingCartListboxLabel.Location = new System.Drawing.Point(560, 107);
            this.shopppingCartListboxLabel.Name = "shopppingCartListboxLabel";
            this.shopppingCartListboxLabel.Size = new System.Drawing.Size(180, 29);
            this.shopppingCartListboxLabel.TabIndex = 5;
            this.shopppingCartListboxLabel.Text = "Shopping Cart";
            // 
            // shoppingCartListBox
            // 
            this.shoppingCartListBox.FormattingEnabled = true;
            this.shoppingCartListBox.ItemHeight = 29;
            this.shoppingCartListBox.Location = new System.Drawing.Point(565, 139);
            this.shoppingCartListBox.Name = "shoppingCartListBox";
            this.shoppingCartListBox.Size = new System.Drawing.Size(305, 178);
            this.shoppingCartListBox.TabIndex = 4;
            // 
            // makePurchase
            // 
            this.makePurchase.Location = new System.Drawing.Point(740, 323);
            this.makePurchase.Name = "makePurchase";
            this.makePurchase.Size = new System.Drawing.Size(130, 51);
            this.makePurchase.TabIndex = 6;
            this.makePurchase.Text = "Purchase";
            this.makePurchase.UseVisualStyleBackColor = true;
            this.makePurchase.Click += new System.EventHandler(this.makePurchase_Click);
            // 
            // vendorListboxLabel
            // 
            this.vendorListboxLabel.AutoSize = true;
            this.vendorListboxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendorListboxLabel.Location = new System.Drawing.Point(35, 404);
            this.vendorListboxLabel.Name = "vendorListboxLabel";
            this.vendorListboxLabel.Size = new System.Drawing.Size(110, 29);
            this.vendorListboxLabel.TabIndex = 8;
            this.vendorListboxLabel.Text = "Vendors\r\n";
            // 
            // vendorListbox
            // 
            this.vendorListbox.FormattingEnabled = true;
            this.vendorListbox.ItemHeight = 29;
            this.vendorListbox.Location = new System.Drawing.Point(37, 436);
            this.vendorListbox.Name = "vendorListbox";
            this.vendorListbox.Size = new System.Drawing.Size(303, 207);
            this.vendorListbox.TabIndex = 7;
            // 
            // storePayoutLabel
            // 
            this.storePayoutLabel.AutoSize = true;
            this.storePayoutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storePayoutLabel.Location = new System.Drawing.Point(574, 502);
            this.storePayoutLabel.Name = "storePayoutLabel";
            this.storePayoutLabel.Size = new System.Drawing.Size(0, 29);
            this.storePayoutLabel.TabIndex = 10;
            // 
            // storePaymentLabel
            // 
            this.storePaymentLabel.AutoSize = true;
            this.storePaymentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storePaymentLabel.Location = new System.Drawing.Point(726, 502);
            this.storePaymentLabel.Name = "storePaymentLabel";
            this.storePaymentLabel.Size = new System.Drawing.Size(27, 29);
            this.storePaymentLabel.TabIndex = 11;
            this.storePaymentLabel.Text = "0";
            // 
            // storePayment
            // 
            this.storePayment.AutoSize = true;
            this.storePayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storePayment.Location = new System.Drawing.Point(542, 502);
            this.storePayment.Name = "storePayment";
            this.storePayment.Size = new System.Drawing.Size(187, 29);
            this.storePayment.TabIndex = 12;
            this.storePayment.Text = "Total Payment:";
            // 
            // ConsignmentShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 701);
            this.Controls.Add(this.storePayment);
            this.Controls.Add(this.storePaymentLabel);
            this.Controls.Add(this.storePayoutLabel);
            this.Controls.Add(this.vendorListboxLabel);
            this.Controls.Add(this.vendorListbox);
            this.Controls.Add(this.makePurchase);
            this.Controls.Add(this.shopppingCartListboxLabel);
            this.Controls.Add(this.shoppingCartListBox);
            this.Controls.Add(this.addTocart);
            this.Controls.Add(this.itemsListboxLabels);
            this.Controls.Add(this.itemsListbox);
            this.Controls.Add(this.headerText);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "ConsignmentShop";
            this.Text = "ConsignmentShop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerText;
        private System.Windows.Forms.ListBox itemsListbox;
        private System.Windows.Forms.Label itemsListboxLabels;
        private System.Windows.Forms.Button addTocart;
        private System.Windows.Forms.Label shopppingCartListboxLabel;
        private System.Windows.Forms.ListBox shoppingCartListBox;
        private System.Windows.Forms.Button makePurchase;
        private System.Windows.Forms.Label vendorListboxLabel;
        private System.Windows.Forms.ListBox vendorListbox;
        private System.Windows.Forms.Label storePayoutLabel;
        private System.Windows.Forms.Label storePaymentLabel;
        private System.Windows.Forms.Label storePayment;
    }
}

