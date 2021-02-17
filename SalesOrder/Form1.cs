using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace SalesOrder
{
    public partial class Form1 : Form
    {

        string invNum;

        ComboBox combo;
        public Form1()
        {
            InitializeComponent();
        }

        public Form1(string inv)
        {
            this.invNum = inv;
            InitializeComponent();

            string mainconn = ConfigurationManager.ConnectionStrings["SalesOrder.Properties.Settings.masterConnectionString"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = "select * from [dbo].[Invoice] where InvoiceNumber = '"+invNum+"'";
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
            SqlDataAdapter sda = new SqlDataAdapter(sqlcomm);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            this.comboBox1.DataSource = dt;
            this.comboBox1.DisplayMember = "CustomerName";
            this.comboBox1.ValueMember = "CustomerName";
            
            foreach (DataRow dr in dt.Rows)
            {

                txtBoxInvoiceNo.Text = dr["InvoiceNumber"].ToString();
                txtBoxTotExcl.Text = dr["ExclAmount"].ToString();
                txtBoxTotTax.Text = dr["TaxAmount"].ToString();
                txtBoxTotIncl.Text = dr["InclAmount"].ToString();

                //DateTime dd = Convert.ToDateTime(dr["InvoiceDate"].ToString());
                //string s2 = dd.ToString("dd-MM-yyyy");
                //DateTime dtnew = Convert.ToDateTime(s2);
                //dateTimePicker1 = dr["InvoiceDate"].ToString();

            }


        }

        private void clientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet_CustInfo);

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet_CustList.Client' table. You can move, or remove it, as needed.
            this.clientTableAdapter1.Fill(this.dataSet_CustList.Client);

            string mainconn = ConfigurationManager.ConnectionStrings["SalesOrder.Properties.Settings.masterConnectionString"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = "select Code, Description_1, StockLink from [dbo].[StkItem]";
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
            SqlDataAdapter sda = new SqlDataAdapter(sqlcomm);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            this.itemCode.DisplayMember = "Code";
            this.itemCode.ValueMember = "StockLink";
            this.itemCode.DataSource = dt;

            //this.desc.DisplayMember = "Description_1";
            //this.desc.ValueMember = "StockLink";
            //this.desc.DataSource = dt;

            
           
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.clientTableAdapter.Fill(this.dataSet_CustInfo.Client, ((int)(System.Convert.ChangeType(comboBox1.SelectedValue, typeof(int)))));
            }
            catch (System.Exception ex)       
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            } 
        }

        private void combo_SelectedIndexChanged(object sender, EventArgs e)
        {

            combo.SelectedIndexChanged -= new EventHandler(combo_SelectedIndexChanged);

            combo.SelectedIndexChanged += combo_SelectedIndexChanged;
            int stocklinkval = (int) this.combo.SelectedValue;

            string mainconn = ConfigurationManager.ConnectionStrings["SalesOrder.Properties.Settings.masterConnectionString"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = "select Description_1, StockLink  from [dbo].[StkItem] where StockLink = '"+stocklinkval+"' ";
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
            SqlDataAdapter sda = new SqlDataAdapter(sqlcomm);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
               
                Console.WriteLine(dr["Description_1"].ToString());
            }

            this.desc.DisplayMember = "Description_1";
            this.desc.ValueMember = "StockLink";
            this.desc.DataSource = dt;



        }

        private void dataGridView1_EditingControlShowing_1(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            combo = e.Control as ComboBox;
            if (combo != null)
            {

                combo.SelectedIndexChanged -= new EventHandler(combo_SelectedIndexChanged);
                
                combo.SelectedIndexChanged += new EventHandler(combo_SelectedIndexChanged);
            }


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;
                string note = dataGridView1.Rows[e.RowIndex].Cells["not"].FormattedValue.ToString();
                int quantitiy = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["quan"].FormattedValue.ToString());
                int price = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["pri"].FormattedValue.ToString());
                float tax = float.Parse(dataGridView1.Rows[e.RowIndex].Cells["tax"].FormattedValue.ToString());

                double exclAmount = quantitiy* price;
                double taxAmount = exclAmount * tax / 100;
                double inclAmount = exclAmount + taxAmount;


                dataGridView1.Rows[e.RowIndex].Cells["exclAmount"].Value = exclAmount;
                dataGridView1.Rows[e.RowIndex].Cells["taxAmount"].Value = taxAmount;
                dataGridView1.Rows[e.RowIndex].Cells["inclAmount"].Value = inclAmount;

            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            txtBoxTotExcl.Text = (from DataGridViewRow row in dataGridView1.Rows where row.Cells[6].FormattedValue.ToString() != string.Empty select Convert.ToInt32(row.Cells[6].FormattedValue)).Sum().ToString();
            txtBoxTotTax.Text = (from DataGridViewRow row in dataGridView1.Rows where row.Cells[7].FormattedValue.ToString() != string.Empty select Convert.ToInt32(row.Cells[7].FormattedValue)).Sum().ToString();
            txtBoxTotIncl.Text = (from DataGridViewRow row in dataGridView1.Rows where row.Cells[8].FormattedValue.ToString() != string.Empty select Convert.ToInt32(row.Cells[8].FormattedValue)).Sum().ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["SalesOrder.Properties.Settings.masterConnectionString"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);

            sqlconn.Open();

            string sqlquery = "insert into [dbo].[Invoice] values('" + Convert.ToInt32(txtBoxInvoiceNo.Text) + "','" + comboBox1.Text.ToString() + "', '"+ dateTimePicker1.Value.Date + "','"+ float.Parse(txtBoxTotExcl.Text) + "','"+ float.Parse(txtBoxTotTax.Text) + "','"+ float.Parse(txtBoxTotIncl.Text)+"')";
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
            SqlDataAdapter sda = new SqlDataAdapter(sqlcomm);

            sqlcomm.ExecuteNonQuery();
            MessageBox.Show("Saved");
            
            sqlconn.Close();
            this.Visible = false;
            Form2 f2 = new Form2();
            f2.Visible = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["SalesOrder.Properties.Settings.masterConnectionString"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);

            sqlconn.Open();

            string sqlquery = "update [dbo].[Invoice] set InvoiceNumber = '"+Convert.ToInt32(txtBoxInvoiceNo.Text)+"', CustomerName = '" + comboBox1.Text.ToString() + "', InvoiceDate = '" + dateTimePicker1.Value.Date + "', ExclAmount = '" + float.Parse(txtBoxTotExcl.Text) + "', TaxAMount = '" + float.Parse(txtBoxTotTax.Text) + "', InclAmount = '" + float.Parse(txtBoxTotIncl.Text) + "' where InvoiceNumber = '"+ Convert.ToInt32(txtBoxInvoiceNo.Text) + "'";
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
            SqlDataAdapter sda = new SqlDataAdapter(sqlcomm);

            sqlcomm.ExecuteNonQuery();
            MessageBox.Show("Updated");

            sqlconn.Close();
            this.Visible = false;
            Form2 f2 = new Form2();
            f2.Visible = true;
        }
    }
}
