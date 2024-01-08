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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DataBrokerCleaning
{
    public partial class ShowDetailsForm : Form
    {
        int id = 0;
        public ShowDetailsForm(int dataid)
        {
            this.id = dataid;

            InitializeComponent();

        }

        private void ShowDetailsForm_Load(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["DataBrokerCleaning.Properties.Settings.DataBrokerDatabaseConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from DataBrokerDetails where Id = " + this.id;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            
            System.Text.StringBuilder sbs = new System.Text.StringBuilder();
            String CompanyName = "Company Name";
            String Domain = "Domain";
            foreach (DataRow row in dt.Rows)
            {
                sbs.Append(row[Domain].ToString());
                sbs.Append(Environment.NewLine);
                sbs.Append(row[CompanyName].ToString());
            }

            MessageBox.Show(sbs.ToString() , "Data got");


        }
    }
}
