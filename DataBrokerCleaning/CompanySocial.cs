using DataBrokerCleaning.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBrokerCleaning
{
    public partial class CompanySocial : Form
    {
        int id = 0;
        public CompanySocial(int dataid)
        {
            InitializeComponent();
            this.id = dataid;
        }

        private void CompanySocial_Load(object sender, EventArgs e)
        {

            String CompanyFacebookHandle = "Company Facebook Handle";
            String CompanyLinkedinHandle = "Company Linkedin Handle";
            String CompanyTwitterHandle = "Company Twitter Handle";
            String CompanyTwitterId = "Company Twitter Id";
            String CompanyTwitterBio = "Company Twitter Bio";
            String CompanyTwitterLocation = "Company Twitter Location";
            String CompanyTwitterSite = "Company Twitter Site";
            String CompanyCrunchbaseHandle = "Company Crunchbase Handle";
            string cs = ConfigurationManager.ConnectionStrings["DataBrokerCleaning.Properties.Settings.DataBrokerDatabaseConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from DataBrokerDetails where Id = " + this.id;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            CompanySocialData csd = new CompanySocialData();
            foreach (DataRow row in dt.Rows)
            {
                csd.CompanyFacebookHandle = Convert.ToString(row[CompanyFacebookHandle]);
                csd.CompanyLinkedinHandle = Convert.ToString(row[CompanyLinkedinHandle]);
                csd.CompanyTwitterHandle = Convert.ToString(CompanyTwitterHandle);
                csd.CompanyTwitterId = Convert.ToString(row[CompanyTwitterId]);
                csd.CompanyTwitterBio = Convert.ToString(row[CompanyTwitterBio]);
                csd.CompanyTwitterLocation = Convert.ToString(row[CompanyTwitterLocation]);
                csd.CompanyTwitterSite = Convert.ToString(row[CompanyTwitterSite]);
                csd.CompanyCrunchbaseHandle = Convert.ToString(row[CompanyCrunchbaseHandle]);
            }

            lblCompanyFacebookHandle.Text = csd.CompanyFacebookHandle;
            lblCompanyLinkedinHandle.Text  = csd.CompanyLinkedinHandle;
            lblCompanyTwitterHandle.Text = csd.CompanyTwitterHandle;
            lblCompanyTwitterId.Text = csd.CompanyTwitterId;
            lblCompanyTwitterBio.Text = csd.CompanyTwitterBio;
            lblCompanyTwitterLocation.Text = csd.CompanyTwitterLocation;
            lblCompanyTwitterSite.Text = csd.CompanyTwitterSite;
            lblCompanyCrunchbaseHandle.Text= csd.CompanyCrunchbaseHandle;


        }
    }
}
