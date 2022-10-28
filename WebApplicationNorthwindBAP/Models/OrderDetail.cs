//aylah prettie

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplicationNorthwindBAP.Models
{
    public class OrderDetail
    {
        private int orderId = -1;
        private int productId = -1;
        private double unitPrice = 0.00;
        private int quantity = 0;
        private double discount = 0;

        public int OrderId
        {
            get { return this.orderId; }
            set
            {
                if (value > -1)
                {
                    this.orderId = value;
                }
            }
        }
        public int ProductId
        {
            get { return this.productId; }
            set
            {
                if (value > -1)
                {
                    this.productId = value;
                }

            }
        }
        public double UnitPrice
        {
            get { return this.unitPrice; }
            set
            {
                if (value > 0.00)
                {
                    this.unitPrice = value;
                }

            }
        }
        public int Quantity
        {
            get { return this.quantity; }
            set
            {
                if (value > 0)
                {
                    this.Quantity = value;
                }
            }
        }
        public double Discount
        {
            get { return this.discount; }
            set
            {
                if (value > 0)
                {
                    this.discount = value;
                }
            }
        }
        //Constructors
        public OrderDetail() : this(-1, -1, 0.00, 0, 0)
        {
            //empty constructor
        }
        public OrderDetail(int aOrderId, int aProductId) : this(aOrderId, aProductId, 0.00, 0, 0)
        {
            // partialconstructor
        }
        public OrderDetail(int aOrderId, int aProductId, double aUnitPrice, int aQuantity, double aDiscount)
        {
            this.orderId = aOrderId;
            this.productId = aProductId;
            this.unitPrice = aUnitPrice;
            this.quantity = aQuantity;
            this.discount = aDiscount;
        }
        //methods go here
        public override string ToString()
        {
            string msg = "";
            msg += "OrderId:" + this.orderId + "\n";
            msg += "ProductId:" + this.productId + "\n";
            msg += "UnitPrice:" + this.unitPrice + "\n";
            msg += "Quantity:" + this.quantity + "\n";
            msg += "Discount:" + this.discount + "\n";
            return msg;
        }
    }
}

