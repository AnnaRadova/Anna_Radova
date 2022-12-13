using NUnit.Framework;
using NUnit.Framework.Internal;

namespace Homework5
{
    internal class Task3
    {

        public int DigitalRoot(int n)
        {
            int digitalRoot = 0;
            while (n > 0 || digitalRoot > 9)
            {
                if (n == 0)
                {
                    n = digitalRoot;
                    digitalRoot = 0;
                }
                digitalRoot += n % 10;
                n /= 10;
            }
            return digitalRoot;
        }

        [Test]
        public void DigitalRootTest1()
        {
            int n = 16;
            int expectedDigitalRoot = 7;
            int actualDigitalRoot = DigitalRoot(n);
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
