//aylah prettie

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplicationNorthwindBAP.Models
{
    public class Product
    {
        private int productId = -1;
        private string productName = "n/a";
        private int supplierId = -1;
        private int categoryId = -1;
        private string quantityPerUnit = "n/a";
        private double unitPrice = 50000.00;
        private int unitsInStock = -1;
        private int unitsOnOrder = -1;
        private int recorderLevel = 9000;
        private bool discounted = true;

        public int ProductId
        {
            get { return productId; }
            set
            {
                if (value < -1)
                {
                    this.productId = value;
                }

            }

        }
        public string ProductName
        {
            get { return this.productName; }
            set { this.productName = value; }
        }
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
        public int CategoryId
        {
            get { return this.categoryId; }
            set
            {
                if (value > -1)
                {
                    this.categoryId = value;
                }
            }
        }
        public string QuantityPerUnit
        {
            get { return this.quantityPerUnit; }
            set { this.quantityPerUnit = value; }
        }
        public double UnitPrice
        {
            get { return this.unitPrice; }
            set
            {
                if (value > 0)
                {
                    this.unitPrice = value;
                }
            }
        }
        public int UnitsInStock
        {
            get { return this.unitsInStock; }
            set
            {
                if (value > -1)
                {
                    this.unitsInStock = value;
                }
            }
        }
        public int UnitsInOrder
        {
            get { return this.unitsOnOrder; }
            set
            {
                if (value > -1)
                {
                    this.unitsOnOrder = value;
                }
            }
        }
        public int RecorderLevel
        {
            get { return this.recorderLevel; }
            set
            {
                if (value > 0)
                {
                    this.recorderLevel = value;
                }
            }
        }
        public bool Discounted
        {
            get { return this.discounted; }
            set { this.discounted = value; }
        }

        public Product() : this(-1, "n/a", -1, -1, "n/a", 50000.00, -1, -1, 9000, true)
        {
            //empty constructor
        }
        public Product(int aProductId, string aProductName, int aSupplierId) : this(aProductId, aProductName, aSupplierId, -1, "n/a", 50000.00, -1, -1, 9000, true)
        {
            //partial constructor
        }
        public Product(int aProductId, string aProductName, int aSupplierId, int aCategoryId, string aQuantityPerUnit, double aUnitPrice, int aUnitsInStock, int aUnitsOnOrder, int aRecorderLevel, bool aDiscounted)
        {
            //full constructors
            this.productId = aProductId;
            this.productName = aProductName;
            this.supplierId = aSupplierId;
            this.categoryId = aCategoryId;
            this.quantityPerUnit = aQuantityPerUnit;
            this.unitPrice = aUnitPrice;
            this.unitsInStock = aUnitsInStock;
            this.unitsOnOrder = aUnitsOnOrder;
            this.recorderLevel = aRecorderLevel;
            this.discounted = aDiscounted;
        }
        //methods here 
        public override string ToString()
        {
            string msg = "";
            msg += "ProductId:" + this.productId + "\n";
            msg += "ProductName:" + this.productName + "\n";
            msg += "SupplierId:" + this.supplierId + "\n";
            msg += "QuantityPerUnit:" + this.quantityPerUnit + "\n";
            msg += "UnitPrice:" + this.unitPrice + "\n";
            msg += "UnitsInStock:" + this.unitsInStock + "\n";
            msg += "UnitsOnOrder:" + this.unitsOnOrder + "\n";
            msg += "RecorderLevel:" + this.recorderLevel + "\n";
            msg += "Discounted:" + this.discounted + "\n";
            return msg;

        }
    }
}