using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[assembly: AssemblyTitle("OrderProcessingTesting")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("OrderProcessingTesting")]
[assembly: AssemblyCopyright("Copyright ©  2022")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

[assembly: ComVisible(false)]

[assembly: Guid("af5dedba-8ec4-4191-86fd-4d9a43152e3a")]

// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]

namespace OrderProcessingTesting
{
    class clsOrderProcessing
    {
        public string OrderId { get; internal set; }
        public string OrderDescription { get; internal set; }
        public DateTime OrderDate { get; internal set; }
        public string OrderAvailable { get; internal set; }
        public string Price { get; internal set; }
        public string OrderStatus { get; internal set; }

        internal string Valid(string nDescription)
        {
            {
                if (nDescription.Length < 1) {
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
}
