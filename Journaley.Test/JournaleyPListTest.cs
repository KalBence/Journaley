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
        public void PListRealConstructor()
        {
            decimal value = 5;

            PListReal pListReal = new PListReal(value);

            Assert.AreEqual(pListReal.Value, value);
        }

        [TestMethod()]
        public void PListRealEquals()
        {
            decimal constructorParameter = 10;

            PListReal plistReal1 = new PListReal(constructorParameter);
            PListReal plistReal2 = new PListReal(constructorParameter);

            Assert.IsTrue(plistReal1.Equals(plistReal2));
        }

    }
}
