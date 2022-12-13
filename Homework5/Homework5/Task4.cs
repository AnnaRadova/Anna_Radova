using NUnit.Framework;
using NUnit.Framework.Internal;

namespace Homework5
{
    public class Task4
    {
        public int CountNumberOfPairs(int[] arr, int targetSum)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
                for (int j = i + 1; j < arr.Length; j++)
                    if ((arr[i] + arr[j]) == targetSum)
                        count++;
            return count;
        }

        [Test]
        public void CountNumberOfPairsTest1()
        {
            int[] arr = { 1, 3, 6, 2, 2, 0, 4, 5 };
            int expectedCount = 4;
            int actualCount = CountNumberOfPairs(arr, 5);
            Assert.AreEqual(expectedCount, actualCount);
        }
    }
}
