using System;

namespace ClassLibrary
{
    public class clsOrderProcessing
    {
        public string DateAdded;
        public string OrderNo;
        public string OrderDescription;
        public string OrderAvailable;
        public string Price;
        public string OrderStatus;

        public string Valid(string nDescription)
        {
            if (nDescription.Length < 1) 
            {
                return "Description cannot be blank";
            }
            if (nDescription.Length > 1) {

                return "Description cannot be more than 50 characters";
            }
            else {

                return "";
            }
        }
    }
}