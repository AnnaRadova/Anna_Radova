using NUnit.Framework;
using NUnit.Framework.Internal;

namespace Homework5
{
    public class Task1
    {
        public List<int> GetIntegersFromList(List<object> objList)
        {
            List<int> intList = objList
                .Where(i => i.GetType() == typeof(int))
                .Cast<int>()
                .ToList();
            return intList;
        }

        [Test]
        public void GetIntegersFromListTest1()
        {
            List<object> objList = new List<object>() {1, 2, "a", "b"};
            List<int> expectedList = new List<int>() {1, 2};
            List<int> actualList = GetIntegersFromList(objList);
            Assert.AreEqual(expectedList, actualList);
        }

        [Test]
        public void GetIntegersFromListTest2()
        {
            List<object> objList = new List<object>() {1, 2, "a", "b", 0, 15};
            List<int> expectedList = new List<int>() {1, 2, 0, 15};
            List<int> actualList = GetIntegersFromList(objList);
            Assert.AreEqual(expectedList, actualList);
        }

        [Test]
        public void GetIntegersFromListTest3()
        {
            List<object> objList = new List<object>() {1, 2, "a", "b", "aasf", "1", "123", 231};
            List<int> expectedList = new List<int>() {1, 2, 231};
            List<int> actualList = GetIntegersFromList(objList);
            Assert.AreEqual(expectedList, actualList);
        }
    }
}