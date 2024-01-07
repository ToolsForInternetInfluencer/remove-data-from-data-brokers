using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBrokerCleaning
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataBrokerDatabaseDataSet.DataBrokerDetails' table. You can move, or remove it, as needed.
            this.dataBrokerDetailsTableAdapter.Fill(this.dataBrokerDatabaseDataSet.DataBrokerDetails);

        }

        private void Search_Click(object sender, EventArgs e)
        {

            // (dataGridViewData.DataSource as DataTable).DefaultView.RowFilter = string.Format("Domain like '{0}%' OR 'Company Name' like '{1}%' OR Address like '{2}%' ", 
            //  txtDomain.Text, txtCompanyName.Text, txtAddress.Text );
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridViewData.DataSource;
            String filter = "";
            if (!string.IsNullOrEmpty(txtDomain.Text))
            {
                filter += string.Format("Domain like '{0}%'   ", txtDomain.Text);
            }
            if (!string.IsNullOrEmpty(txtCompanyName.Text))
            {
                if (filter.Length > 0) filter += "OR ";
                filter += string.Format("[Company Name] like '{0}%'   ", txtCompanyName.Text);
            }
            if (!string.IsNullOrEmpty(txtAddress.Text))
            {
                if (filter.Length > 0) filter += "OR ";
                filter += string.Format(" Address like '{0}%'   ", txtAddress.Text);
            }

            bs.Filter = filter;
            dataGridViewData.DataSource = bs;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDomain.Text = "";
            txtCompanyName.Text = "";
            txtAddress.Text = "";
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridViewData.DataSource;
            bs.Filter = "";
            dataGridViewData.DataSource = bs;

        }
    }
}
