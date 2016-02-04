using BusinessLogic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLogic.Common;

namespace Unit_Tests
{
    
    
    /// <summary>
    ///This is a test class for BusinessLogicHandlerTest and is intended
    ///to contain all BusinessLogicHandlerTest Unit Tests
    ///</summary>
    [TestClass()]
    public class BusinessLogicHandlerTest
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
        ///A test for CheckUserLogin
        ///</summary>
        [TestMethod()]
        public void CheckUserLoginTest()
        {
            BusinessLogicHandler target = new BusinessLogicHandler();
            string userId = "1234567890"; // not existing ID
            string password = "badPassword12456";
            bool expected = false;
            bool actual;
            actual = target.CheckUserLogin(userId, password);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for CheckAdministratorLogin
        ///</summary>
        [TestMethod()]
        public void CheckAdministratorLoginTest()
        {
            BusinessLogicHandler target = new BusinessLogicHandler();
            string username = "notExistingUser123456";
            string password = "badPassword12456";
            bool expected = false;
            bool actual;
            actual = target.CheckAdministratorLogin(username, password);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for CreateSessionForUser
        ///</summary>
        [TestMethod()]
        public void CreateSessionForUserTest()
        {
            BusinessLogicHandler target = new BusinessLogicHandler();
            string userId = "1";
            SessionInfo actual = target.CreateSessionForUser(userId);
            Assert.AreEqual(actual.UserId.ToString(), userId);
        }

        /// <summary>
        ///A test for CreateSessionForAdministrator
        ///</summary>
        [TestMethod()]
        public void CreateSessionForAdministratorTest()
        {
            BusinessLogicHandler target = new BusinessLogicHandler();
            string username = "admin";
            SessionInfo actual = target.CreateSessionForAdministrator(username);
            Assert.AreEqual(actual.UserId, 1);
        }
    }
}
