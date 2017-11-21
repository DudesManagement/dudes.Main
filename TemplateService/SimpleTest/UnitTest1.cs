using Microsoft.VisualStudio.TestPlatform.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SimpleTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AlwaysTrueTest()
        {
            Assert.IsTrue(true, "AlwaysTrueTest, expected true always");
        }
		
		[TestMethod]
        public void NegativeTest()
        {
            try
            {
                Assert.Fail("Not Failing,Expected behaviour, we are expecting this exception message always");
            }
            catch (Exception e)
            {
                Assert.IsTrue(e is AssertFailedException, "NegativeTest: Unexpected exception was , expected AssertFailedException");
            }
            
        }
    }
}
