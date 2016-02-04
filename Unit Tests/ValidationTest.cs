using BusinessLogic.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Unit_Tests
{
    
    
    /// <summary>
    ///This is a test class for ValidationTest and is intended
    ///to contain all ValidationTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ValidationTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for IsValidEmail
        ///</summary>
        [TestMethod()]
        public void IsValidEmailTest()
        {
            string emailAddress = "test.email@land.";
            bool expected = false;
            bool actual;
            actual = Validation.IsValidEmail(emailAddress);
            Assert.AreEqual(expected, actual);
        }
    }
}
