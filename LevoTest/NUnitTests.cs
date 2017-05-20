using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using LevoTest;

namespace LevoTest
{
    [TestFixture]
    public class NUnitTests
    {
        [Test]
        public void TestMethod1()
        {
            string actualResult = Program.ReverseCharInWords(null);
            Assert.AreEqual("Error: String is either null or empty", actualResult);            
        }
        [Test]
        public void TestMethod2()
        {            
            string actualResult = Program.ReverseCharInWords(string.Empty);
            Assert.AreEqual("Error: String is either null or empty", actualResult);            
        }
        [Test]
        public void TestMethod3()
        {            
            string actualResult = Program.ReverseCharInWords("Hello World!");
            Assert.AreEqual("Output String : olleH !dlroW", actualResult);
        }
    }
}
