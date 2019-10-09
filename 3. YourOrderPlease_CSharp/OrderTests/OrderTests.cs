using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace YourOrderPlease
{
    [TestClass]
    public class OrderTests
    {
        [TestMethod]
        public void Test1()
        {
            Assert.AreEqual("Thi1s is2 3a T4est", Order.DoOrder("is2 Thi1s T4est 3a"));
        }
        [TestMethod]
        public void Test2()
        {
            Assert.AreEqual("Fo1r the2 g3ood 4of th5e pe6ople", Order.DoOrder("4of Fo1r pe6ople g3ood th5e the2"));
        }
        [TestMethod]
        public void Test3()
        {
            Assert.AreEqual("wha1t sh2all 3we d4o w5ith a6 dru7nken s8ailor", Order.DoOrder("d4o dru7nken sh2all w5ith s8ailor wha1t 3we a6"));
        }
        [TestMethod]
        public void Test4()
        {
            Assert.AreEqual("", Order.DoOrder(""));
        }
        [TestMethod]
        public void Test5()
        {
            Assert.AreEqual("1 2 3 4 5 6 7 8 9", Order.DoOrder("3 6 4 2 8 7 5 1 9")); ;
        }
        [TestMethod]
        public void Test6()
        {
            Assert.AreEqual("one1 two2 three3 four4 five5 six6 seven7 eight8 nine9 ten10 eleven11 twelve12", Order.DoOrder("twelve12 eleven11 ten10 nine9 eight8 seven7 six6 five5 four4 three3 two2 one1"));
        }
    }
}
