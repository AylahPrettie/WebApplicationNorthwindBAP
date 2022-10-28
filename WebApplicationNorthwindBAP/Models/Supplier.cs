//aylah prettie

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplicationNorthwindBAP.Models
{
    public class Supplier
    {
        private int supplierId = -1;
        private string companyName = "n/a";
        private string contactName = "n/a";
        private string contactTitle = "n/a";
        private string address = "n/a";
        private string city = "n/a";
        private string region = "n/a";
        private string postalCode = "n/a";
        private string country = "n/a";
        private string phone = "n/a";
        private string fax = "n/a";
        private string homePage = "n/a";

        public int SupplierId
        {
            get { return this.supplierId; }
            set
            {
                if (value > -1)
                {
                    this.supplierId = value;
                }
            }
        }


        public string CompanyName
        {
            get { return this.companyName; }
            set { this.companyName = value; }
        }
        public string ContactName
        {
            get { return this.contactName; }
            set { this.contactName = value; }
        }
        public string ContactTitle
        {
            get { return this.contactTitle; }
            set { this.contactTitle = value; }
        }
        public string Address
        {
            get { return this.address; }
            set { this.address = value; }
        }
        public string City
        {
            get { return this.city; }
            set { this.city = value; }
        }
        public string Region
        {
            get { return this.region; }
            set { this.region = value; }
        }
        public string PostalCode
        {
            get { return this.postalCode; }
            set { this.postalCode = value; }
        }
        public string Country
        {
            get { return this.country; }
            set { this.country = value; }
        }
        public string Phone
        {
            get { return this.phone; }
            set { this.phone = value; }
        }
        public string Fax
        {
            get { return this.fax; }
            set { this.fax = value; }
        }
        public string HomePage
        {
            get { return this.homePage; }
            set { this.homePage = value; }
        }

        //constructors
        public Supplier() : this(-1, "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a")
        {
            //empty constructor
        }
        public Supplier(int aSupplierId, string aCompanyName) : this(aSupplierId, aCompanyName, "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a")
        {
            //partial constructor
        }
        public Supplier(int aSupplierId, string aCompanyName, string aContactName, string aContactTitle, string aAddress, string aCity, string aRegion, string aPostalCode, string aCountry, string aPhone, string aFax, string aHomePage)
        {
            this.supplierId = aSupplierId;
            this.companyName = aCompanyName;
            this.contactName = aContactName;
            this.contactTitle = aContactTitle;
            this.address = aAddress;
            this.city = aCity;
            this.region = aRegion;
            this.postalCode = aPostalCode;
            this.country = aCountry;
            this.phone = aPhone;
            this.fax = aFax;
            this.homePage = aHomePage;
        }
        //methods go here
        public override string ToString()
        {
            string msg = "";
            msg += "SupplierId:" + this.supplierId + "\n";
            msg += "CompanyName:" + this.companyName + "\n";
            msg += "ContactName:" + this.contactName + "\n";
            msg += "ContactTitle:" + this.contactTitle + "\n";
            msg += "Address:" + this.address + "\n";
            msg += "City:" + this.city + "\n";
            msg += "Region" + this.region + "\n";
            msg += "PostalCode:" + this.postalCode + "\n";
            msg += "Country:" + this.country + "\n";
            msg += "Phone:" + this.phone + "\n";
            msg += "Fax:" + this.fax + "\n";
            msg += "HomePage" + this.homePage + "\n";
            return msg;
        }


    }
}