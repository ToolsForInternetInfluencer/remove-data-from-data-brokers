using DataBrokerCleaning.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DataBrokerCleaning
{
    public partial class CompanyIntroForm : Form
    {
        int id = 0;
        public CompanyIntroForm(int dataid)
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
            
            String CompanyDescription = "Company Description";
            String CompanyLogo = "Company Logo";
            String CompanyLegalName = "Company Legal Name";
            String CompanyFoundingYear = "Company Founded Year";
            String CompanyType = "Company Type";
            CompanyIntro companyIntro = new CompanyIntro();
            foreach (DataRow row in dt.Rows)
            {
                companyIntro.CompanyName = Convert.ToString(row[CompanyName]);
                companyIntro.CompanyDescription = Convert.ToString(row[CompanyDescription]);
                companyIntro.CompanyLogo = Convert.ToString(row[CompanyLogo]);
                companyIntro.CompanyLegalName = Convert.ToString(row[CompanyLegalName]);
                companyIntro.CompanyFoundingYear = Convert.ToString(row[CompanyFoundingYear]); 
                companyIntro.CompanyType = Convert.ToString(row[CompanyType]);


            }

            lblCompnayName.Text = companyIntro.CompanyName;
            imgCompanyLogo.Load(companyIntro.CompanyLogo);
            imgCompanyLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            lblCompanyLegalName.Text = companyIntro.CompanyLegalName == "" ? "Data not Present"  : companyIntro.CompanyLegalName;
            lblCompanyDescription.Text = companyIntro.CompanyDescription;
            lblCompanyFounded.Text = companyIntro.CompanyFoundingYear;
            lblCompanyType.Text = companyIntro.CompanyType;



        }

        private void btnContactDetails_Click(object sender, EventArgs e)
        {
            CompanyContactDetails form = new CompanyContactDetails(this.id);
            form.Show();
        }
    }
}
