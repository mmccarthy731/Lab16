using NUnit.Framework;

namespace Lab16
{
    [TestFixture]
    public class HikerTest
    {
        [Test]
        public void case1()
        {
            Assert.AreEqual(2, Hiker.GetPrime(1));
        }
    
        [Test]
        public void case2()
        {
            Assert.AreEqual(3, Hiker.GetPrime(2));
        }
    
        [Test]
        public void case3()
        {
            Assert.AreEqual(5, Hiker.GetPrime(3));
        }

        [Test]
        public void case4()
        {
            Assert.AreEqual(229, Hiker.GetPrime(229));
        }
    
        [Test]
        public void case4()
        {
            Assert.AreEqual(541, Hiker.GetPrime(100));
        }
    
        [Test]
        public void case5()
        {
            Assert.AreEqual("st", Hiker.GetSuffix(1));
        }
    
        [Test]
        public void case6()
        {
            Assert.AreEqual("nd", Hiker.GetSuffix(2));
        }
    
        [Test]
        public void case7()
        {
            Assert.AreEqual("th", Hiker.GetSuffix(11));
        }
    
        [Test]
        public void case8()
        {
            Assert.AreEqual("th", Hiker.GetSuffix(12));
        }
    
    }

}
