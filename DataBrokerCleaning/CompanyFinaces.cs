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
    public partial class CompanyFinaces : Form
    {
        int id;
        public CompanyFinaces(int dataid)
        {
            InitializeComponent();
            this.id = dataid;
        }

        private void CompanyFinaces_Load(object sender, EventArgs e)
        {
            //Health
            String Health = "Health";
            //Company Url
            String CompanyUrl = "Company Url";
            //Company Category Sector
            String CompanyCategorySector = "Company Category Sector";
            //Company Category Industry Group
            String CompanyCategoryIndustryGroup = "Company Category Industry Group";
            //Company Category Industry
            String CompanyCategoryIndustry = "Company Category Industry";
            //Company Category Sub Industry
            String CompanyCategorySubIndustry = "Company Category Sub Industry";
            //Company Category Sic Code
            String CompanyCategorySicCode = "Company Category Sic Code";
            //Company Category Naics Code
            String CompanyCategoryNaicsCode = "Company Category Naics Code";
            //Company Tags
            String CompanyTags = "Company Tags";
            //Company Type
            String CompanyType = "Company Type";
            //Company Ticker
            String CompanyTicker = "Company Ticker";
            //Company Metrics Employees
            String CompanyMetricsEmployees = "Company Metrics Employees";
            //Company Metrics Employees Range
            String CompanyMetricsEmployeesRange = "Company Metrics Employees Range";
            //Company Metrics Market Cap
            String CompanyMetricsMarketCap = "Company Metrics Market Cap";
            //Company Metrics Raised
            String CompanyMetricsRaised = "Company Metrics Raised";
            //Company Metrics Annual Revenue
            String CompanyMetricsAnnualRevenue = "Company Metrics Annual Revenue";
            //Company Metrics Estimated Annual Revenue
            String CompanyMetricsEstimatedAnnualRevenue = "Company Metrics Estimated Annual Revenue";
            //Company Metrics Fiscal Year End
            String CompanyMetricsFiscalYearEnd = "Company Metrics Fiscal Year End";
            //Company Tech
            String CompanyTech = "Company Tech";


            string cs = ConfigurationManager.ConnectionStrings["DataBrokerCleaning.Properties.Settings.DataBrokerDatabaseConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from DataBrokerDetails where Id = " + this.id;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CompanyFinances cf = new CompanyFinances();
            foreach (DataRow row in dt.Rows)
            {
                cf.Health = Convert.ToString(row[Health]);
                cf.CompanyUrl = Convert.ToString(row[CompanyUrl]);
                cf.CompanyCategorySector = Convert.ToString(row[CompanyCategorySector]);
                cf.CompanyCategoryIndustryGroup = Convert.ToString(row[CompanyCategoryIndustryGroup]);
                cf.CompanyCategoryIndustry = Convert.ToString(row[CompanyCategoryIndustry]);
                cf.CompanyCategorySubIndustry = Convert.ToString(row[CompanyCategorySubIndustry]);
                cf.CompanyCategorySicCode = Convert.ToString(row[CompanyCategorySicCode]);
                cf.CompanyCategoryNaicsCode = Convert.ToString(row[CompanyCategoryNaicsCode]);
                cf.CompanyTags = Convert.ToString(row[CompanyTags]);
                cf.CompanyType = Convert.ToString(row[CompanyType]);
                cf.CompanyTicker = Convert.ToString(row[CompanyTicker]);
                cf.CompanyMetricsEmployees = Convert.ToString(row[CompanyMetricsEmployees]);
                cf.CompanyMetricsEmployeesRange = Convert.ToString(row[CompanyMetricsEmployeesRange]);
                cf.CompanyMetricsMarketCap = Convert.ToString(row[CompanyMetricsMarketCap]);
                cf.CompanyMetricsRaised = Convert.ToString(row[CompanyMetricsRaised]);
                cf.CompanyMetricsAnnualRevenue = Convert.ToString(row[CompanyMetricsAnnualRevenue]);
                cf.CompanyMetricsEstimatedAnnualRevenue = Convert.ToString(row[CompanyMetricsEstimatedAnnualRevenue]);
                cf.CompanyMetricsFiscalYearEnd = Convert.ToString(row[CompanyMetricsFiscalYearEnd]);
                cf.CompanyTech = Convert.ToString(row[CompanyTech]);
            }















            }
    }
}
