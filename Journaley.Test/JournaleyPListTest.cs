using Journaley.Core.PList;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
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
        /// <summary>
        /// Test that the Value property gets the good value
        /// </summary>
        [TestMethod()]
        public void PListRealConstructor()
        {
            decimal value = 5;

            PListReal pListReal = new PListReal(value);

            Assert.AreEqual(value, pListReal.Value);
        }

        /// <summary>
        /// Test the constructor with moq 
        /// </summary>
        [TestMethod()]
        public void PListRealConstructorTestWithMoq()
        {
            decimal value = 5;

            var pListRealMock = new Mock<PListReal>(MockBehavior.Strict);
            pListRealMock.Setup(s=> s.Value).Returns(value);

            Assert.AreEqual(value, pListRealMock.Object.Value);
        }

        /// <summary>
        /// Test Equals method
        /// </summary>
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
