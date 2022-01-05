using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Calculator.Test
{  
    [TestClass]
    public class UnitTest1
    {
        private TestContext _testContext;
        public TestContext TestContext
        {
            get
            {
                return _testContext;
            }
            set
            {
                _testContext = value;
            }
        }

        [TestMethod]
        [TestCategory("Demo"), TestCategory("Calculator")]
        [TestProperty("Test Group","Performance")]
        public void TestMethod1()
        {
            System.Diagnostics.Debug.WriteLine("Debug: TestMethod1");
            TestContext.WriteLine("TestContext: TestMethod1");
        }
    }
}
