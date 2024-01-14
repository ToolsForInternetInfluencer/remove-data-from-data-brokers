﻿using DataBrokerCleaning.Data;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace DataBrokerCleaning
{
    public partial class CompanyGeoDetails : Form
    {
        int id = 0;
        public CompanyGeoDetails(int dataid)
        {
            InitializeComponent();
            this.id = dataid;
        }

        private void CompanyGeoDetails_Load(object sender, EventArgs e)
        {

            //Company Time Zone
            String CompanyTimeZone = "Company Time Zone";
            //Company Utc Offset
            String CompanyUtcOffset = "CompanyUtcOffset";
            //Company Geo Street Number
            String CompanyGeoStreetNumber = "Company Geo Street Number";
            //Company Geo Street Name
            String CompanyGeoStreetName = "Company Geo Street Name";
            //Company Geo Sub Premise
            String CompanyGeoSubPremise = "Company Geo Sub Premise";
            //Company Geo City
            String CompanyGeoCity = "Company Geo City";
            //Company Geo Postal Code
            String CompanyGeoPostalCode = "Company Geo Postal Code";
            //Company Geo State
            String CompanyGeoState = "Company Geo State";
            //Company Geo State Code
            String CompanyGeoStateCode = "Company Geo State Code";
            //Company Geo Country
            String CompanyGeoCountry = "Company Geo Country";
            //Company Geo Country Code
            String CompanyGeoCountryCode = "Company Geo Country Code";
            //Company Geo Lat
            String CompanyGeoLat = "Company Geo Lat";
            //Company Geo Lng
            String CompanyGeoLng = "Company Geo Lng";





            string cs = ConfigurationManager.ConnectionStrings["DataBrokerCleaning.Properties.Settings.DataBrokerDatabaseConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from DataBrokerDetails where Id = " + this.id;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CompanyGeoLocation geoLocation = new CompanyGeoLocation();


            foreach (DataRow row in dt.Rows)
            {
                geoLocation.CompanyTimeZone = Convert.ToString(row[CompanyTimeZone]);
                geoLocation.CompanyUtcOffset = Convert.ToString(row[CompanyUtcOffset]);
                geoLocation.CompanyGeoStreetNumber = Convert.ToString(row[CompanyGeoStreetNumber]);
                geoLocation.CompanyGeoStreetName = Convert.ToString(row[CompanyGeoStreetName]);
                geoLocation.CompanyGeoSubPremise = Convert.ToString(row[CompanyGeoSubPremise]);
                geoLocation.CompanyGeoCity = Convert.ToString(row[CompanyGeoCity]);
                geoLocation.CompanyGeoPostalCode = Convert.ToString(row[CompanyGeoPostalCode]);
                geoLocation.CompanyGeoState = Convert.ToString(row[CompanyGeoState]);
                geoLocation.CompanyGeoStateCode = Convert.ToString(row[CompanyGeoStateCode]);
                geoLocation.CompanyGeoCountry = Convert.ToString(row[CompanyGeoCountry]);
                geoLocation.CompanyGeoCountryCode = Convert.ToString(row[CompanyGeoCountryCode]);
                geoLocation.CompanyGeoLat = Convert.ToString(row[CompanyGeoLat]);
                geoLocation.CompanyGeoLng = Convert.ToString(row[CompanyGeoLng]);
            }




        }
    }
}
