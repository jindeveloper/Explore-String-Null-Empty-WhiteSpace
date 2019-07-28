using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Explore_String_Null_Empty_WhiteSpace
{
    [TestClass]
    public class UnitTest1
    {
        private string strNull = null;
        private string strEmptyString = "";
        private string strWhiteSpace = " ";
        private string strWhiteSpaces = "  ";
        private string strWhiteSpaceTab = "\t";
       
        [TestMethod]
        public void Test_String_IsNullOrWhiteSpace()
        {
            Assert.AreEqual(strNull, null); 
            
            Assert.AreEqual(true, string.IsNullOrWhiteSpace(strEmptyString), $"{strEmptyString} is an empty string");

            Assert.AreEqual(true, string.IsNullOrWhiteSpace(strWhiteSpace));

            Assert.AreEqual(true, string.IsNullOrWhiteSpace(strWhiteSpaces));

            Assert.AreEqual(true, string.IsNullOrWhiteSpace(strWhiteSpaceTab));
        }
      
        [TestMethod]
        public void Test_String_IsNullOrEmpty()
        {
            Assert.AreEqual(strNull, null);

            Assert.AreEqual(true, string.IsNullOrEmpty(strEmptyString), $"{strEmptyString} is an empty string");

            Assert.AreEqual(false, string.IsNullOrEmpty(strWhiteSpace));
                                           
            Assert.AreEqual(false, string.IsNullOrEmpty(strWhiteSpaces));
                                         
            Assert.AreEqual(false, string.IsNullOrEmpty(strWhiteSpaceTab));
        }
    }
}

