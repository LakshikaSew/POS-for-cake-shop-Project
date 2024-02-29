namespace POS_Project
{
    partial class Work_Station
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblSalesTodayCredit = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblSalesTodayCash = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.blSalesToday = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbleSalesCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnBusinessDetails = new System.Windows.Forms.Button();
            this.btnInvoice = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnPayments = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(952, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(454, 649);
            this.panel1.TabIndex = 7;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.lblSalesTodayCredit);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Location = new System.Drawing.Point(91, 467);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(255, 120);
            this.panel5.TabIndex = 8;
            // 
            // lblSalesTodayCredit
            // 
            this.lblSalesTodayCredit.AutoSize = true;
            this.lblSalesTodayCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesTodayCredit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSalesTodayCredit.Location = new System.Drawing.Point(3, 55);
            this.lblSalesTodayCredit.MinimumSize = new System.Drawing.Size(935, 948);
            this.lblSalesTodayCredit.Name = "lblSalesTodayCredit";
            this.lblSalesTodayCredit.Size = new System.Drawing.Size(935, 948);
            this.lblSalesTodayCredit.TabIndex = 4;
            this.lblSalesTodayCredit.Text = "Rs. 00.00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(4, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(193, 25);
            this.label7.TabIndex = 4;
            this.label7.Text = "Total Sales : (Credit)";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.lblSalesTodayCash);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(91, 314);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(255, 129);
            this.panel4.TabIndex = 1;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // lblSalesTodayCash
            // 
            this.lblSalesTodayCash.AutoSize = true;
            this.lblSalesTodayCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesTodayCash.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSalesTodayCash.Location = new System.Drawing.Point(12, 65);
            this.lblSalesTodayCash.Name = "lblSalesTodayCash";
            this.lblSalesTodayCash.Size = new System.Drawing.Size(135, 32);
            this.lblSalesTodayCash.TabIndex = 3;
            this.lblSalesTodayCash.Text = "Rs. 00.00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(3, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Total Sales : (Cash)";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.blSalesToday);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(91, 165);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(255, 125);
            this.panel3.TabIndex = 1;
            // 
            // blSalesToday
            // 
            this.blSalesToday.AutoSize = true;
            this.blSalesToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blSalesToday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.blSalesToday.Location = new System.Drawing.Point(12, 59);
            this.blSalesToday.Name = "blSalesToday";
            this.blSalesToday.Size = new System.Drawing.Size(135, 32);
            this.blSalesToday.TabIndex = 2;
            this.blSalesToday.Text = "Rs. 00.00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(3, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total Sales : (Today)";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lbleSalesCount);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(91, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(255, 121);
            this.panel2.TabIndex = 0;
            // 
            // lbleSalesCount
            // 
            this.lbleSalesCount.AutoSize = true;
            this.lbleSalesCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbleSalesCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbleSalesCount.Location = new System.Drawing.Point(3, 62);
            this.lbleSalesCount.Name = "lbleSalesCount";
            this.lbleSalesCount.Size = new System.Drawing.Size(135, 32);
            this.lbleSalesCount.TabIndex = 1;
            this.lbleSalesCount.Text = "Rs. 00.00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sales Count : (Today)";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.Image = global::POS_Project.Properties.Resources.button1;
            this.btnExit.Location = new System.Drawing.Point(818, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(110, 110);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.White;
            this.btnRefresh.Image = global::POS_Project.Properties.Resources.circular_arrow;
            this.btnRefresh.Location = new System.Drawing.Point(688, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(110, 110);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // btnBusinessDetails
            // 
            this.btnBusinessDetails.BackColor = System.Drawing.Color.White;
            this.btnBusinessDetails.Image = global::POS_Project.Properties.Resources.business_report;
            this.btnBusinessDetails.Location = new System.Drawing.Point(558, 12);
            this.btnBusinessDetails.Name = "btnBusinessDetails";
            this.btnBusinessDetails.Size = new System.Drawing.Size(110, 110);
            this.btnBusinessDetails.TabIndex = 4;
            this.btnBusinessDetails.Text = "Business Details";
            this.btnBusinessDetails.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBusinessDetails.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBusinessDetails.UseVisualStyleBackColor = false;
            // 
            // btnInvoice
            // 
            this.btnInvoice.BackColor = System.Drawing.Color.White;
            this.btnInvoice.Image = global::POS_Project.Properties.Resources.invoice;
            this.btnInvoice.Location = new System.Drawing.Point(168, 12);
            this.btnInvoice.Name = "btnInvoice";
            this.btnInvoice.Size = new System.Drawing.Size(110, 110);
            this.btnInvoice.TabIndex = 1;
            this.btnInvoice.Text = "Invoice";
            this.btnInvoice.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnInvoice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnInvoice.UseVisualStyleBackColor = false;
            // 
            // btnCustomer
            // 
            this.btnCustomer.BackColor = System.Drawing.Color.White;
            this.btnCustomer.Image = global::POS_Project.Properties.Resources.customer_review;
            this.btnCustomer.Location = new System.Drawing.Point(298, 12);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(110, 110);
            this.btnCustomer.TabIndex = 2;
            this.btnCustomer.Text = "Customers";
            this.btnCustomer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCustomer.UseVisualStyleBackColor = false;
            // 
            // btnPayments
            // 
            this.btnPayments.BackColor = System.Drawing.Color.White;
            this.btnPayments.Image = global::POS_Project.Properties.Resources.payment_method;
            this.btnPayments.Location = new System.Drawing.Point(428, 12);
            this.btnPayments.Name = "btnPayments";
            this.btnPayments.Size = new System.Drawing.Size(110, 110);
            this.btnPayments.TabIndex = 3;
            this.btnPayments.Text = "Payments";
            this.btnPayments.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPayments.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPayments.UseVisualStyleBackColor = false;
            // 
            // btnStock
            // 
            this.btnStock.BackColor = System.Drawing.Color.White;
            this.btnStock.Image = global::POS_Project.Properties.Resources.ready_stock;
            this.btnStock.Location = new System.Drawing.Point(38, 12);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(110, 110);
            this.btnStock.TabIndex = 0;
            this.btnStock.Text = "Stock";
            this.btnStock.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnStock.UseVisualStyleBackColor = false;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // Work_Station
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1396, 644);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnBusinessDetails);
            this.Controls.Add(this.btnInvoice);
            this.Controls.Add(this.btnCustomer);
            this.Controls.Add(this.btnPayments);
            this.Controls.Add(this.btnStock);
            this.Name = "Work_Station";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Workstation";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Button btnPayments;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnInvoice;
        private System.Windows.Forms.Button btnBusinessDetails;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbleSalesCount;
        private System.Windows.Forms.Label lblSalesTodayCash;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label blSalesToday;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSalesTodayCredit;
        private System.Windows.Forms.Label label7;
    }
}