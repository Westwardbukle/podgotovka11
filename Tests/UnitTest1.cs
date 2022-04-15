using Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Services;
using System;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(AuthVariants.LoginAndPassworcorrect, Authorization.Login("admin", "admin"));
        }
    }
}
