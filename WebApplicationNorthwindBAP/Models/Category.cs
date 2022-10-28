//aylah prettie
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WebApplicationNorthwindBAP.Models
{
    public class Category
    {
        private int categoryID = -1;
        private string categoryName = "n/a";
        private string description = "n/a";

        public int CategoryId
        {
            get { return this.categoryID; }
            set
            {
                //must be greater than -1
                if (value > -1)
                {
                    this.categoryID = value;
                }
                else
                {
                    this.categoryID = 0;
                }

            }
        }
        public string CategoryName
        {
            get { return this.categoryName; }
            set { this.categoryName = value; }
        }
        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }
        public Category(int aCategoryID, string aCategoryName, string aDescription)
        {
            this.categoryID = aCategoryID;
            this. CategoryName = aCategoryName;
            this.Description = aDescription;
            
        }

        public override string ToString()
        {
            string msg = "";
            msg = msg + "CategoryId:" + this.CategoryId + "\n" + "CategoryName: " + this.CategoryName + "\n" + "Description: " + this.Description + "\n";
            return msg;
        }

    }
}

