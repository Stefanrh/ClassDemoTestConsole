using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassDemoTestConsole.Test;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Dummy dum = new Dummy();
            try
            {
                dum.Somenumber = 0;
                Assert.Fail();
            }
            catch (ArgumentException ae)
            {

                // ok
            }
        }

        [TestMethod]
        public void TestMethod2()
        {
            Dummy dum = new Dummy();


            dum.Somenumber = 1;
            Assert.AreEqual(1, dum.Somenumber);
        }

        [TestMethod]
        public void TestMethod3()
        {
            Dummy dum = new Dummy();
            try
            {
                dum.Somenumber = 4;
                Assert.AreEqual(4, dum.Somenumber);
            }
            catch (ArgumentException ae)
            {

                // ok
            }
        }
        [TestMethod]
        public void TestMethod4()
        {
            Dummy dum = new Dummy();
            try
            {
                dum.Somenumber = 5;
                Assert.AreEqual(5, dum.Somenumber);
             }
            catch(ArgumentException ae)
            {

            }
            }
        }
}
