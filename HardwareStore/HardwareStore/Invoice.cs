using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareStore
{
    
    public class Invoice
    {
        //private variables
        private int quantity;
        private decimal price;

        //constructors
        public Invoice( string part, string desc, int qty, decimal price )
        {
            PartNumber = part;
            PartDescrition = desc;
            Quantity = qty;
            Price = price;

        }
        //public properties
        public string PartNumber { get; set; }
        public string PartDescrition { get; set; }
        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                if (value >= 0)
                {
                    quantity = value;
                }
            }
        }
        public decimal Price
        {
            get
            {
                return price;
            }
            set
            {
                if (value >= 0)
                {
                    price = value;
                }
            }
        }

        
        //Method
        public decimal GetInvoiceAmount()
        {
            return Quantity * Price;
        }

    }

   



}
