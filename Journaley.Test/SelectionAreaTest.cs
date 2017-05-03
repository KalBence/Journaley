using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Pabo.Calendar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Journaley.Test
{
    [TestFixture]
    public class SelectionAreaTest
    {
        /// <summary>
        /// Test ToString method in some case
        /// First is the default case
        /// </summary>
        [TestCase(-1,-1, ExpectedResult ="Empty")]
        [TestCase(1, 2, ExpectedResult = "1:2")]
        [TestCase(5, 11, ExpectedResult = "11:5")]
        [TestCase(-1, 10, ExpectedResult = "-1-10")]
        public string ToStringTest(int begin, int end)
        {
            SelectionArea selectionArea = new SelectionArea(begin, end);

            return selectionArea.ToString();
        }
    }
}
