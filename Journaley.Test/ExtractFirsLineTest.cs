using Journaley.Core.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Journaley.Test
{
    [TestClass()]
    public class ExtractFirsLineTest
    {
        /// <summary>
        /// Tests if the function returns an empty string if it gets  null value
        /// </summary>
        [TestMethod()]
        public void FirstLineEmptyTest()
        {
            string empty = null;

            Assert.AreEqual("", FirstSentenceExtractor.ExtractFirstLine(empty));
        }

        /// <summary>
        /// Tests if the function returns the first part of the string before a new line
        /// </summary>
        [TestMethod()]
        public void FirstLineTest()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Lorem ipsum dolor sit amet");
            sb.Append(Environment.NewLine);
            sb.Append("Consectetur adipiscing elit");

            Assert.AreEqual("Lorem ipsum dolor sit amet", FirstSentenceExtractor.ExtractFirstLine(sb.ToString()));
        }



    }
}
