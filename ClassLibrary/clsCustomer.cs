using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        public string CustomerID { get; set; }
        public string CustomerDescription { get; set; }
        public bool Marketting { get; set; }
        public decimal ProductCost { get; set; }
        public int CustomerContact { get; set; }
        public DateTime CustomerDob { get; set; }

        public bool Find(object customerId)
        {
            //always return true
            return true;
        }
    }
}
