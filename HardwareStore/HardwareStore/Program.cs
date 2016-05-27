using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareStore
{
    class Program
    {
        static void Main(string[] args)
        {
            //create instance
            Invoice invoice1 = new Invoice ("1234", "Hammer", 2, 15.95M);

            //display Invoice
            Console.WriteLine("Original invoice information");
            Console.WriteLine("Part Number: {0}", invoice1.PartNumber);
            Console.WriteLine("Part Descriptino: {0}", invoice1.PartDescrition);
            Console.WriteLine("Quantity: {0}", invoice1.Quantity);
            Console.WriteLine("Price: {0:C}", invoice1.Price);
            Console.WriteLine("Invoice Total: {0:C}", invoice1.GetInvoiceAmount());
            
        }
    }
}
