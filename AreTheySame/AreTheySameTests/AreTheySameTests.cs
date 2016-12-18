using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AreTheySameTests
{
    [TestClass()]
    public class AreTheySameTests
    {
        [TestMethod()]
        public void CompTest1()
        {
            int[] a = new int[] { 121, 144, 19, 161, 19, 144, 19, 11 };
            int[] b = new int[] { 121, 14641, 20736, 361, 25921, 361, 20736, 361 };
            bool result = AreTheySame.AreTheySame.Comp(a,b);
            Assert.AreEqual(true,result);
        }
        [TestMethod()]
        public void CompTest2()
        {
            int[] a = new int[] { 121, 144, 19, 161, 19, 144, 19, 11 };
            int[] b = new int[] { 11 * 11, 121 * 121, 144 * 144, 19 * 19, 161 * 161, 19 * 19, 144 * 144, 19 * 19 };
            bool result = AreTheySame.AreTheySame.Comp(a, b);
            Assert.AreEqual(true, result);
        }
        [TestMethod()]
        public void CompTest3()
        {
            int[] a = new int[] { 121, 144, 19, 161, 19, 144, 19, 11 };
            int[] b = new int[] { 132, 14641, 20736, 361, 25921, 361, 20736, 361 };
            bool result = AreTheySame.AreTheySame.Comp(a, b);
            Assert.AreEqual(false, result);
        }
        [TestMethod()]
        public void CompTest4()
        {
            int[] a = new int[] { 121, 144, 19, 161, 19, 144, 19, 11 };
            int[] b = new int[] { 121, 14641, 20736, 36100, 25921, 361, 20736, 361 };
            bool result = AreTheySame.AreTheySame.Comp(a, b);
            Assert.AreEqual(false, result);
        }
        [TestMethod()]
        public void CompTest5()
        {
            int[] a = new int[] {2,2,3 };
            int[] b = new int[] {4,9,9 };
            bool result = AreTheySame.AreTheySame.Comp(a, b);
            Assert.AreEqual(false, result);
        }
        [TestMethod()]
        public void CompTest6()
        {
            int[] a = new int[] {  };
            int[] b = new int[] {  };
            bool result = AreTheySame.AreTheySame.Comp(a, b);
            Assert.AreEqual(true, result);
        }
        [TestMethod()]
        public void CompTest7()
        {
            bool result = AreTheySame.AreTheySame.Comp(null, null);
            Assert.AreEqual(false, result);
        }
    }
}