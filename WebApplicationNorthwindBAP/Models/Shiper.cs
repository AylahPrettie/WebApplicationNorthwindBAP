//aylah prettie

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplicationNorthwindBAP.Models
{
    public class Shiper
    {
        private int shiperId = -1;
        private string companyName = "n/a";
        private string phone = "n/a";

        public int ShiperId
        {
            get { return this.shiperId; }
            set
            {
                if (value > -1)
                {
                    this.shiperId = value;
                }
            }
        }
        public string CompanyName
        {
            get { return this.companyName; }
            set { this.companyName = value; }
        }
        public string Phone
        {
            get { return this.phone; }
            set { this.phone = value; }
        }

        public Shiper() : this(-1, "n/a", "n/a")
        {
            //empty constructor
        }
        public Shiper(int aShiperId) : this(aShiperId, "n/a", "n/a")
        {
            //partial constructor
        }
        public Shiper(int aShiperId, string aCompanyName, string aPhone)
        {
            //full constructor
            this.shiperId = aShiperId;
            this.companyName = aCompanyName;
            this.phone = aPhone;
        }
        //methods go here
        public override string ToString()
        {
            string msg = "";
            msg += "SiperId:" + this.shiperId + "\n";
            msg += "CompanyName:" + this.companyName + "\n";
            msg += "Phone:" + this.phone + "\n";
            return msg;
        }
    }

}

