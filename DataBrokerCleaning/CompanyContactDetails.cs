using DataBrokerCleaning.Data;
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

namespace DataBrokerCleaning
{
    public partial class CompanyContactDetails : Form
    {
        int id;
        public CompanyContactDetails(int dataId)
        {
            InitializeComponent();
           this.id = dataId;
        }

        private void CompanyContactDetails_Load(object sender, EventArgs e)
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

            CompnayContactDetails companyContactDetails = new CompnayContactDetails();
            foreach (DataRow row in dt.Rows)
            {
                companyContactDetails.Email = Convert.ToString(row["Emails"]);
                companyContactDetails.PhoneNumber = Convert.ToString(row["Phone Numbers"]);
                companyContactDetails.Address = Convert.ToString(row["Address"]);
                companyContactDetails.CompanySitePhoneNumbers = Convert.ToString(row["Company Site Phone Numbers"]);
                companyContactDetails.CompanySiteEmailAddress = Convert.ToString(row["Company Site Email Addresses"]);
                companyContactDetails.CompanyLocation = Convert.ToString(row["Company Location"]);
            }
            lblEmail.Text = companyContactDetails.Email;
            lblAddress.Text = companyContactDetails.Address;
            lblCompanyLocation.Text = companyContactDetails.CompanyLocation;
            lblCompanysiteEmail.Text = companyContactDetails.CompanySiteEmailAddress;
            lblPhoneNumberDisplay.Text = companyContactDetails.CompanySitePhoneNumbers;



        }

        private void btnGeoLocation_Click(object sender, EventArgs e)
        {
            CompanyGeoDetails cgd = new CompanyGeoDetails(this.id);
            
            cgd.Show();
        }
    }
}
