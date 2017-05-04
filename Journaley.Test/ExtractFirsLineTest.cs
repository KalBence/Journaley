using Journaley.Core.Utilities;
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
    public class ExtractFirsLineTest
    {
        /// <summary>
        /// Tests if the function returns an empty string if it gets  null value
        /// </summary>
        [TestMethod()]
        public void FirstLineEmptyTest()
        {
            string empty = null;

            Assert.AreEqual(string.Empty, FirstSentenceExtractor.ExtractFirstLine(empty));
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

        /// <summary>
        /// Tests if the function returns with null - empty string tuple
        /// </summary>
        [TestMethod()]
        public void TitleAndFirstSentenceEmptyTest()
        {
            var actual = FirstSentenceExtractor.ExtractTitleAndFirstSentence(string.Empty);
            var expected = new Tuple<string, string>(null, string.Empty);

            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Tests if the function returns with null - first sentence, when the first line has punctuation mark
        /// </summary>
        [TestMethod()]
        public void TitleAndFirstSentenceWithPunctuationTest()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("This is a sentence with a punctuation mark.");
            sb.Append(Environment.NewLine);
            sb.Append("Lorem ipsum dolor sit amet");

            var actual = FirstSentenceExtractor.ExtractTitleAndFirstSentence(sb.ToString());
            var expected = new Tuple<string, string>(null, "This is a sentence with a punctuation mark.");

            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Tests if the function returns with first line - first sentence of the second line,
        /// when the first line doesn't have punctuation mark but the second one does.
        /// </summary>
        [TestMethod()]
        public void TitleAndFirstSentenceWithoutPunctuationTest1()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("This is a sentence without a punctuation mark");
            sb.Append(Environment.NewLine);
            sb.Append("Lorem ipsum dolor sit amet! consectetur adipiscing elit");

            var actual = FirstSentenceExtractor.ExtractTitleAndFirstSentence(sb.ToString());
            var expected = new Tuple<string, string>("This is a sentence without a punctuation mark", "Lorem ipsum dolor sit amet!");

            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Tests if the function returns with first line -  second line,
        /// when the first and the second line doesn't have punctuation mark 
        /// </summary>
        [TestMethod()]
        public void TitleAndFirstSentenceWithoutPunctuationTest2()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("This is a sentence without a punctuation mark");
            sb.Append(Environment.NewLine);
            sb.Append("Lorem ipsum dolor sit amet");

            var actual = FirstSentenceExtractor.ExtractTitleAndFirstSentence(sb.ToString());
            var expected = new Tuple<string, string>("This is a sentence without a punctuation mark", "Lorem ipsum dolor sit amet");

            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Tests if the function returns with the one line - empty string, if that one line is the only input
        /// </summary>
        [TestMethod()]
        public void TitleAndFirstSentenceOneLongTest()
        {
            var actual = FirstSentenceExtractor.ExtractTitleAndFirstSentence("This line is the only input");
            var expected = new Tuple<string, string>("This line is the only input", string.Empty);

            Assert.AreEqual(expected, actual);
        }

    }
}
