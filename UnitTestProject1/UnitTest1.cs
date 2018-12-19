using Microsoft.VisualStudio.TestPlatform.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Program = UnitTest.Program;

namespace U.nitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var result = Program.CheckName("madammadam");

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var result = Program.CheckName("imen");

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var result = Program.CheckName("imen1imen1imen1");

            Assert.IsFalse(result);
        }

    }
}
