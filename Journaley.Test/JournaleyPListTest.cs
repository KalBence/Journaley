using Journaley.Core.PList;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Journaley.Test
{
    [TestClass()]
    public class JournaleyPListTest
    {
        [TestMethod()]
        public void InitPListReal()
        {
            decimal value = 5;

            PListReal pListReal = new PListReal(value);

            Assert.AreEqual(pListReal.Value, value);

        }
    }
}
