using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace StockTesting
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
   
           public void InstanceOK()
        {
            clsStock AStock = new clsStock();
            Assert.IsNotNull(AStock);
        }
        }
    }

