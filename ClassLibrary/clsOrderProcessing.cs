using System;

namespace ClassLibrary
{
    public class clsOrderProcessing
    {
        public DateTime DateAdded;
        public string OrderNo;

        public string Description { get; set; }

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