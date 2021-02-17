using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SalesOrder
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
            showData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Visible = true;
            this.Visible = false;
        }

        private void invoiceBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.invoiceBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet_Invoice);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet_Invoice.Invoice' table. You can move, or remove it, as needed.
            this.invoiceTableAdapter.Fill(this.dataSet_Invoice.Invoice);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.invoiceTableAdapter.FillBy(this.dataSet_Invoice.Invoice);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
        private void showData()
        {
            string mainconn = ConfigurationManager.ConnectionStrings["SalesOrder.Properties.Settings.masterConnectionString"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            sqlconn.Open();

            string sqlquery = "select * from [dbo].[Invoice]";
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
            SqlDataAdapter sda = new SqlDataAdapter(sqlcomm);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);

            dataGridView1.DataSource = dtbl;

            sqlcomm.ExecuteNonQuery();
            sqlconn.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            Form1 f1 = new Form1(dataGridView1.CurrentRow.Cells[0].Value.ToString()) ;
            f1.Visible = true;

            this.Visible = false;
        }


        private void genReport_Click(object sender, EventArgs e)
        {
            
        }
    }
}
