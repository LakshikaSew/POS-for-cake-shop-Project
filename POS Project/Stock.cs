using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace POS_Project
{
    public partial class Stock : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Welcome\OneDrive\Documents\PoS.mdf;Integrated Security=True;Connect Timeout=30");

        public Stock()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnStockValue_Click(object sender, EventArgs e)
        {

        }

        private void btnPurchasingSummary_Click(object sender, EventArgs e)
        {
            Purchasing_Summery purchasing_Summery = new Purchasing_Summery();
            purchasing_Summery.Show();
        }

        private void removeItemToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fullScreenVeiwToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stock_View stock_View = new Stock_View();
            stock_View.Show();
        }

        private void lowStockValueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Low_Stock_Value_Reminder low_Stock_Value_Reminder = new Low_Stock_Value_Reminder();
            low_Stock_Value_Reminder.Show();
        }

        private void txtPurchasingQuantity_TextChanged(object sender, EventArgs e)
        {
            //accept numbers only
            if (string.IsNullOrEmpty(txtPurchasingQuantity.Text))
            {
                //clear the text when it's null or empty
                txtPurchasingQuantity.Text = "";
                txtPurchasingPrice.Text = "";
            }
            else 
            {
                float qty;
                if (float.TryParse(txtPurchasingQuantity.Text, out qty))
                {

                }
                else 
                {
                    txtPurchasingQuantity.Text = "";
                    txtPurchasingPrice.Text = "";
                }
            }
        }

        private void txtPurchasingPrice_TextChanged(object sender, EventArgs e)
        {
            //accept numbers only
            if (string.IsNullOrEmpty(txtPurchasingPrice.Text))
            {
                //clear the text when it's null or empty
                txtPurchasingPrice.Text = "";
                txtPurchaseValue.Text = "";

            }
            else
            {
                float PurchasingPrice;
                if (float.TryParse(txtPurchasingPrice.Text, out PurchasingPrice))
                {
                    //when customer enter nunber need to find purchasing value
                    double Purchasing_Value = Convert.ToDouble(txtPurchasingQuantity.Text) * Convert.ToDouble(txtPurchasingPrice.Text);

                    //display the purchasing value on the textbox(purchasing price)
                    txtPurchaseValue.Text = Convert.ToString(Purchasing_Value);
                }
                else
                {
                    txtPurchasingPrice.Text = "";
                    txtPurchaseValue.Text = "";
                }
            }

        }

        private void txtPurchaseValue_TextChanged(object sender, EventArgs e)
        {
            //accept numbers only
            if (string.IsNullOrEmpty(txtPurchaseValue.Text))
            {
                //clear the text when it's null or empty
                txtPurchaseValue.Text = "";
            }
            else
            {
                float PurchasingValue;
                if (float.TryParse(txtPurchaseValue.Text, out PurchasingValue))
                {

                }
                else
                {
                    txtPurchaseValue.Text = "";
                }
            }
        }

        private void txtMRP_TextChanged(object sender, EventArgs e)
        {
            //accept numbers only
            if (string.IsNullOrEmpty(txtMRP.Text))
            {
                //clear the text when it's null or empty
                txtMRP.Text = "";
            }
            else
            {
                float qty;
                if (float.TryParse(txtMRP.Text, out qty))
                {

                }
                else
                {
                    txtMRP.Text = "";
                }
            }

        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtItemCode.Text))
            {
                MessageBox.Show("Item Code can't be null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtItemCode.Focus();
                this.ActiveControl = txtItemCode;
            }
            else
            {
                if (string.IsNullOrEmpty(txtDescription.Text))
                {
                    MessageBox.Show("Description can't be null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDescription.Focus();
                    this.ActiveControl = txtDescription;
                }
                else
                {
                    if (string.IsNullOrEmpty(txtPurchasingQuantity.Text))
                    {
                        MessageBox.Show("Purchasing Quantity can't be null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtPurchasingQuantity.Focus();
                        this.ActiveControl = txtPurchasingQuantity;

                    }
                    else
                    {
                        if (string.IsNullOrEmpty(txtPurchasingPrice.Text))
                        {
                            MessageBox.Show("Purchasing Price can't be null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtPurchasingPrice.Focus();
                            this.ActiveControl = txtPurchasingPrice;

                        }
                        else
                        {
                            if (string.IsNullOrEmpty(txtMRP.Text))
                            {
                                MessageBox.Show("`MRP can't be null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtMRP.Focus();
                                this.ActiveControl = txtMRP;

                            }
                            else
                            {
                                if (string.IsNullOrEmpty(txtPurchasingOrderNo.Text))
                                {
                                    MessageBox.Show("Purchasing Order No can't be null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    txtPurchasingOrderNo.Focus();
                                    this.ActiveControl = txtPurchasingOrderNo;

                                }
                                else
                                {
                                    if (string.IsNullOrEmpty(cmbSupplier.Text))
                                    {
                                        MessageBox.Show("Supplier can't be null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        cmbSupplier.Focus();
                                        this.ActiveControl = cmbSupplier;

                                    }
                                    else
                                    {
                                        con.Open();
                                        SqlCommand StockUpdate = new SqlCommand("Insert into Stock([ItemCode],[Description],[Prch_Qty],[Prch_Price],[Prch_Value],[MRP],[Supplier]) values ('" + txtItemCode.Text + "','" + txtDescription.Text + "','" + Convert.ToDouble(txtPurchasingQuantity.Text) + "','" + Convert.ToDouble(txtPurchasingPrice.Text) + "','" + Convert.ToDouble(txtPurchaseValue.Text) + "','" + Convert.ToDouble(txtMRP.Text) + "','" + cmbSupplier.Text + "')", con);
                                        StockUpdate.ExecuteNonQuery();
                                        con.Close();

                                        txtItemCode.Text = "";
                                        txtDescription.Text = "";
                                        txtPurchasingQuantity.Text = "";
                                        txtPurchasingPrice.Text = "";
                                        txtPurchaseValue.Text = "";
                                        txtMRP.Text = "";
                                        txtPurchasingOrderNo.Text = "";
                                        cmbSupplier.Text = "";



                                    }
                                }



                            }

                        }
                    }






                }

            }

        }
    }
}
