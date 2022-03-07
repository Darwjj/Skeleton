using System;

namespace ClassLibrary
{
    public class clsDataConnection
    {
        public int Count { get; set; }
        public object DataTable { get; set; }


        public void AddParameter(string v, int OrderId)
        {
            throw new NotImplementedException();
        }

        public void Execute(string v)
        {
            throw new NotImplementedException();
        }
    }
}