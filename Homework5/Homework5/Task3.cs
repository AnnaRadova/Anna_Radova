using NUnit.Framework;
using NUnit.Framework.Internal;

namespace Homework5
{
    internal class Task3
    { 

        public int DigitalRoot(int n)
        {
            if (n < 10)
                return n;
            List<int> digits = new List<int>();
            while (n > 0)
            {
                digits.Add(n % 10);
                n /= 10;
            }
            return DigitalRoot(digits.Sum());
        }

        [Test]
        public void DigitalRootTest1()
        {
            int n = 16;
            int expectedDigitalRoot = 7;
            int actualDigitalRoot = DigitalRoot(16);
            Assert.AreEqual(expectedDigitalRoot, actualDigitalRoot);
        }

        [Test]
        public void DigitalRootTest2()
        {
            int n = 942;
            int expectedDigitalRoot = 6;
            int actualDigitalRoot = DigitalRoot(n);
            Assert.AreEqual(expectedDigitalRoot, actualDigitalRoot);
        }

        [Test]
        public void DigitalRootTest3()
        {
            int n = 132189;
            int expectedDigitalRoot = 6;
            int actualDigitalRoot = DigitalRoot(n);
            Assert.AreEqual(expectedDigitalRoot, actualDigitalRoot);
        }
    }
}
