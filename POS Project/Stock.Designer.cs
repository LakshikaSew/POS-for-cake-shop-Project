namespace POS_Project
{
    partial class Stock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stock));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClearEntries = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.cmbSupplier = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPurchasingOrderNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMRP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPurchaseValue = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPurchasingPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPurchasingQuantity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtItemCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fullScreenVeiwToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lowStockValueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewLowStockItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblStockCount = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblStockValue = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.btnPurchasingSummary = new System.Windows.Forms.Button();
            this.btnPrintStock = new System.Windows.Forms.Button();
            this.btnViewStock = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.btnClearEntries);
            this.panel1.Controls.Add(this.btnAddItem);
            this.panel1.Controls.Add(this.cmbSupplier);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtPurchasingOrderNo);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtMRP);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtPurchaseValue);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtPurchasingPrice);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtPurchasingQuantity);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtDescription);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtItemCode);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(367, 666);
            this.panel1.TabIndex = 0;
            // 
            // btnClearEntries
            // 
            this.btnClearEntries.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnClearEntries.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearEntries.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearEntries.ForeColor = System.Drawing.Color.White;
            this.btnClearEntries.Image = global::POS_Project.Properties.Resources.clear;
            this.btnClearEntries.Location = new System.Drawing.Point(187, 539);
            this.btnClearEntries.Name = "btnClearEntries";
            this.btnClearEntries.Size = new System.Drawing.Size(162, 53);
            this.btnClearEntries.TabIndex = 10;
            this.btnClearEntries.Text = "Clear";
            this.btnClearEntries.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClearEntries.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClearEntries.UseVisualStyleBackColor = false;
            // 
            // btnAddItem
            // 
            this.btnAddItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItem.ForeColor = System.Drawing.Color.White;
            this.btnAddItem.Image = global::POS_Project.Properties.Resources.sign;
            this.btnAddItem.Location = new System.Drawing.Point(18, 539);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(150, 53);
            this.btnAddItem.TabIndex = 9;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddItem.UseVisualStyleBackColor = false;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // cmbSupplier
            // 
            this.cmbSupplier.FormattingEnabled = true;
            this.cmbSupplier.Location = new System.Drawing.Point(18, 493);
            this.cmbSupplier.Name = "cmbSupplier";
            this.cmbSupplier.Size = new System.Drawing.Size(331, 24);
            this.cmbSupplier.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(18, 464);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Supplier";
            // 
            // txtPurchasingOrderNo
            // 
            this.txtPurchasingOrderNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPurchasingOrderNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPurchasingOrderNo.Location = new System.Drawing.Point(18, 428);
            this.txtPurchasingOrderNo.Name = "txtPurchasingOrderNo";
            this.txtPurchasingOrderNo.Size = new System.Drawing.Size(333, 27);
            this.txtPurchasingOrderNo.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 399);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(205, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Purchasing Order Number";
            // 
            // txtMRP
            // 
            this.txtMRP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMRP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMRP.Location = new System.Drawing.Point(18, 363);
            this.txtMRP.Name = "txtMRP";
            this.txtMRP.Size = new System.Drawing.Size(336, 27);
            this.txtMRP.TabIndex = 6;
            this.txtMRP.TextChanged += new System.EventHandler(this.txtMRP_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 334);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "MRP/ Selling Price";
            // 
            // txtPurchaseValue
            // 
            this.txtPurchaseValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPurchaseValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPurchaseValue.Location = new System.Drawing.Point(18, 298);
            this.txtPurchaseValue.Name = "txtPurchaseValue";
            this.txtPurchaseValue.ReadOnly = true;
            this.txtPurchaseValue.Size = new System.Drawing.Size(336, 27);
            this.txtPurchaseValue.TabIndex = 5;
            this.txtPurchaseValue.TextChanged += new System.EventHandler(this.txtPurchaseValue_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Purchase Value";
            // 
            // txtPurchasingPrice
            // 
            this.txtPurchasingPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPurchasingPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPurchasingPrice.Location = new System.Drawing.Point(18, 233);
            this.txtPurchasingPrice.Name = "txtPurchasingPrice";
            this.txtPurchasingPrice.Size = new System.Drawing.Size(336, 27);
            this.txtPurchasingPrice.TabIndex = 4;
            this.txtPurchasingPrice.TextChanged += new System.EventHandler(this.txtPurchasingPrice_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Purchasing Price";
            // 
            // txtPurchasingQuantity
            // 
            this.txtPurchasingQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPurchasingQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPurchasingQuantity.Location = new System.Drawing.Point(18, 168);
            this.txtPurchasingQuantity.Name = "txtPurchasingQuantity";
            this.txtPurchasingQuantity.Size = new System.Drawing.Size(336, 27);
            this.txtPurchasingQuantity.TabIndex = 3;
            this.txtPurchasingQuantity.TextChanged += new System.EventHandler(this.txtPurchasingQuantity_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Purchasing Quantity";
            // 
            // txtDescription
            // 
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(18, 103);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(336, 27);
            this.txtDescription.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description";
            // 
            // txtItemCode
            // 
            this.txtItemCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtItemCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemCode.Location = new System.Drawing.Point(18, 38);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Size = new System.Drawing.Size(336, 27);
            this.txtItemCode.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item Code";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(218)))), ((int)(((byte)(239)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(376, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(884, 503);
            this.dataGridView1.TabIndex = 14;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeItemToolStripMenuItem,
            this.fullScreenVeiwToolStripMenuItem,
            this.lowStockValueToolStripMenuItem,
            this.viewLowStockItemsToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(254, 100);
            // 
            // removeItemToolStripMenuItem
            // 
            this.removeItemToolStripMenuItem.Name = "removeItemToolStripMenuItem";
            this.removeItemToolStripMenuItem.Size = new System.Drawing.Size(253, 24);
            this.removeItemToolStripMenuItem.Text = "Remove Item";
            this.removeItemToolStripMenuItem.Click += new System.EventHandler(this.removeItemToolStripMenuItem_Click);
            // 
            // fullScreenVeiwToolStripMenuItem
            // 
            this.fullScreenVeiwToolStripMenuItem.Name = "fullScreenVeiwToolStripMenuItem";
            this.fullScreenVeiwToolStripMenuItem.Size = new System.Drawing.Size(253, 24);
            this.fullScreenVeiwToolStripMenuItem.Text = "Stock Full Screen Veiw";
            this.fullScreenVeiwToolStripMenuItem.Click += new System.EventHandler(this.fullScreenVeiwToolStripMenuItem_Click);
            // 
            // lowStockValueToolStripMenuItem
            // 
            this.lowStockValueToolStripMenuItem.Name = "lowStockValueToolStripMenuItem";
            this.lowStockValueToolStripMenuItem.Size = new System.Drawing.Size(253, 24);
            this.lowStockValueToolStripMenuItem.Text = "Low Stock Value Reminder";
            this.lowStockValueToolStripMenuItem.Click += new System.EventHandler(this.lowStockValueToolStripMenuItem_Click);
            // 
            // viewLowStockItemsToolStripMenuItem
            // 
            this.viewLowStockItemsToolStripMenuItem.Name = "viewLowStockItemsToolStripMenuItem";
            this.viewLowStockItemsToolStripMenuItem.Size = new System.Drawing.Size(253, 24);
            this.viewLowStockItemsToolStripMenuItem.Text = "View Low Stock Items";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.lblStockCount);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(849, 546);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 101);
            this.panel2.TabIndex = 5;
            // 
            // lblStockCount
            // 
            this.lblStockCount.AutoSize = true;
            this.lblStockCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockCount.Location = new System.Drawing.Point(3, 58);
            this.lblStockCount.Name = "lblStockCount";
            this.lblStockCount.Size = new System.Drawing.Size(39, 29);
            this.lblStockCount.TabIndex = 1;
            this.lblStockCount.Text = "00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(173, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "Stock Item Count :";
            // 
            // lblStockValue
            // 
            this.lblStockValue.AutoSize = true;
            this.lblStockValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockValue.Location = new System.Drawing.Point(3, 58);
            this.lblStockValue.Name = "lblStockValue";
            this.lblStockValue.Size = new System.Drawing.Size(112, 29);
            this.lblStockValue.TabIndex = 1;
            this.lblStockValue.Text = "Rs. 00.00";
            this.lblStockValue.Click += new System.EventHandler(this.btnStockValue_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.lblStockValue);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Location = new System.Drawing.Point(1055, 546);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(205, 101);
            this.panel3.TabIndex = 6;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(3, 11);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(177, 25);
            this.label12.TabIndex = 0;
            this.label12.Text = "Purchasing Value :";
            // 
            // btnPurchasingSummary
            // 
            this.btnPurchasingSummary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPurchasingSummary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnPurchasingSummary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPurchasingSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPurchasingSummary.ForeColor = System.Drawing.Color.White;
            this.btnPurchasingSummary.Image = global::POS_Project.Properties.Resources.contract;
            this.btnPurchasingSummary.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPurchasingSummary.Location = new System.Drawing.Point(604, 546);
            this.btnPurchasingSummary.Name = "btnPurchasingSummary";
            this.btnPurchasingSummary.Size = new System.Drawing.Size(132, 109);
            this.btnPurchasingSummary.TabIndex = 13;
            this.btnPurchasingSummary.Text = "Purchasing Summary";
            this.btnPurchasingSummary.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPurchasingSummary.UseVisualStyleBackColor = false;
            this.btnPurchasingSummary.Click += new System.EventHandler(this.btnPurchasingSummary_Click);
            // 
            // btnPrintStock
            // 
            this.btnPrintStock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrintStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnPrintStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintStock.ForeColor = System.Drawing.Color.White;
            this.btnPrintStock.Image = global::POS_Project.Properties.Resources.printer;
            this.btnPrintStock.Location = new System.Drawing.Point(490, 546);
            this.btnPrintStock.Name = "btnPrintStock";
            this.btnPrintStock.Size = new System.Drawing.Size(108, 109);
            this.btnPrintStock.TabIndex = 12;
            this.btnPrintStock.Text = "Print Stock Balance";
            this.btnPrintStock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPrintStock.UseVisualStyleBackColor = false;
            // 
            // btnViewStock
            // 
            this.btnViewStock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnViewStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnViewStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewStock.ForeColor = System.Drawing.Color.White;
            this.btnViewStock.Image = ((System.Drawing.Image)(resources.GetObject("btnViewStock.Image")));
            this.btnViewStock.Location = new System.Drawing.Point(376, 546);
            this.btnViewStock.Name = "btnViewStock";
            this.btnViewStock.Size = new System.Drawing.Size(108, 109);
            this.btnViewStock.TabIndex = 11;
            this.btnViewStock.Text = "View All Items";
            this.btnViewStock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnViewStock.UseVisualStyleBackColor = false;
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1272, 667);
            this.Controls.Add(this.btnPurchasingSummary);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnPrintStock);
            this.Controls.Add(this.btnViewStock);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "Stock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtItemCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSupplier;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPurchasingOrderNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMRP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPurchaseValue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPurchasingPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPurchasingQuantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnClearEntries;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnViewStock;
        private System.Windows.Forms.Button btnPrintStock;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem removeItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fullScreenVeiwToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblStockCount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblStockValue;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnPurchasingSummary;
        private System.Windows.Forms.ToolStripMenuItem lowStockValueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewLowStockItemsToolStripMenuItem;
    }
}