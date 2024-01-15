using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBrokerCleaning.Data
{
   public  class CompanyGeoLocation
    {
        //Company Time Zone
        public  String CompanyTimeZone {get; set;}
        //Company Utc Offset
        public String CompanyUtcOffset { get; set; }
        //Company Geo Street Number
        public String CompanyGeoStreetNumber { get; set; }
        //Company Geo Street Name
        public String CompanyGeoStreetName { get; set; }
        //Company Geo Sub Premise
        public String CompanyGeoSubPremise { get; set; }
        //Company Geo City
        public String CompanyGeoCity { get; set; }
        //Company Geo Postal Code
        public String CompanyGeoPostalCode { get; set; }
        //Company Geo State
        public String CompanyGeoState { get; set; }
        //Company Geo State Code
        public String CompanyGeoStateCode { get; set; }
        //Company Geo Country
        public String CompanyGeoCountry { get; set; }
        //Company Geo Country Code
        public String CompanyGeoCountryCode { get; set; }
        //Company Geo Lat
        public String CompanyGeoLat { get; set; }
        //Company Geo Lng
        public  String CompanyGeoLng { get; set; }

        public String CompanyName { get;set; }  

        public String CompanyLogo { get;set; }



    }
}
