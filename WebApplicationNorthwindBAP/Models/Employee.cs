//aylah prettie

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WebApplicationNorthwindBAP.Models
{
    public class Employee
    {
        private int employeeid = -1;
        private string lastName = "n/a";
        private string firstName = "n/a";
        private string title = "n/a";
        private string titleOfCourtesy = "n/a";
        private string birthDate = "n/a";
        private string hireDate = "n/a";
        private string address = "n/a";
        private string city = "n/a";
        private string region = "n/a";
        private string postalcode = "n/a";
        private string country = "n/a";
        private string homephone = "n/a";
        private string extension = "n/a";
        private string notes = "n/a";
        private int reports = -1;

        public int EmployeeId
        {
            get { return this.employeeid; }
            set
            {
                if (value > -1)
                {
                    this.employeeid = value;
                }
                else
                {
                    this.employeeid = 0;
                }

            }

        }
        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }
        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }

        }
        public string Title
        {
            get { return this.title; }
            set { this.title = value; }
        }
        public string TitleOfCourtesy
        {
            get { return this.titleOfCourtesy; }
            set { this.titleOfCourtesy = value; }
        }
        public string BirthDate
        {
            get { return this.birthDate; }
            set { this.birthDate = value; }
        }
        public string HireDate
        {
            get { return this.hireDate; }
            set { this.hireDate = value; }
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
            get { return this.postalcode; }
            set { this.postalcode = value; }
        }

        public string Country
        {
            get { return this.country; }
            set { this.country = value; }

        }
        public string Homephone
        {
            get { return this.homephone; }
            set { this.homephone = value; }
        }
        public string Extension
        {
            get { return this.extension; }
            set { this.extension = value; }
        }
        public string Notes
        {
            get { return this.notes; }
            set { this.notes = value; }
        }
        public int Reports
        {
            get { return this.reports; }
            set
            {
                if (value > -1)
                {
                    this.reports = value;
                }
                else
                {
                    this.reports = 0;
                }


            }
        }
        //constructors 
        public Employee() : this(-1, "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", -1)
        {
            //empty constructor
        }
        public Employee(int aEmployeeId, string aLastName, string aFirstName) : this(aEmployeeId, aLastName, aFirstName, "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", -1)
        {
            //partial constructor
        }
        public Employee(int aEmployeeId, string aLastName, string aFirstName, string aTitle, string aTitleOfCourtesy, string aBirthDate, string aHireDate, string aAddress, string aCity, string aRegion, 
            string aPostalCode, string aCountry, string aHomePhone, string aExtension, string aNotes, int aReports)
        {
            //Full constructor
            this.employeeid = aEmployeeId;
            this.lastName = aLastName;
            this.firstName = aFirstName;
            this.title = aTitle;
            this.titleOfCourtesy = aTitleOfCourtesy;
            this.birthDate = aBirthDate;
            this.hireDate = aHireDate;
            this.address = aAddress;
            this.city = aCity;
            this.region = aRegion;
            this.postalcode = aPostalCode;
            this.country = aCountry;
            this.homephone = aHomePhone;
            this.extension = aExtension;
            this.notes = aNotes;
            this.reports = aReports;
        }
        //methods
        public override string ToString()
        {
            string msg = "";
            msg = msg + "EmployeeID:" + this.employeeid + "\n";
            msg = msg + "LastName:" + this.lastName + "\n";
            msg = msg + "FirstName:" + this.firstName + "\n";
            msg = msg + "Title:" + this.title + "\n";
            msg = msg + "TitleOfCourtesy:" + this.titleOfCourtesy + "\n";
            msg = msg + "BirthDate:" + this.birthDate + "\n";
            msg = msg + "HireDate:" + this.hireDate + "\n";
            msg = msg + "Address:" + this.address + "\n";
            msg = msg + "City:" + this.city + "\n";
            msg = msg + "Region:" + this.region + "\n";
            msg = msg + "PostalCode:" + this.postalcode + "\n";
            msg = msg + "Country:" + this.country + "\n";
            msg = msg + "HomePhone:" + this.homephone + "\n";
            msg = msg + "Notes:" + this.notes + "\n";
            msg = msg + "Reports:" + this.reports + "\n";
            return msg;
        }
    }
}


