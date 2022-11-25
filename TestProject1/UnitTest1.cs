using Microsoft.VisualStudio.TestTools.UnitTesting;



namespace TestProject2
{


    [TestClass]
    public class UnitTest1
    {

        [TestMethod]

        public void TestMethod1()
        {
            Assert.AreEqual("Search", "Search");

        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual("HomeController", "HomeController");

        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.IsTrue(true);

        }
    }
}
