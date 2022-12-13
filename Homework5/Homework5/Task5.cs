using NUnit.Framework;
using NUnit.Framework.Internal;

namespace Homework5
{
    public class Task5
    {
        public string StringSort(string str)
        {
            return "(" + string.Join(")(",
                    str.
                    ToUpper().
                    Split(';').
                    Select(n => n.Split(':')).
                    Select(n => string.Join(", ", n.Reverse())).
                    OrderBy(n => n)
                ) + ")";
        }

        [Test]
        public void StringSortTest1()
        {
            string str = "Fred:Corwill;Wilfred:Corwill;Barney:TornBull;Betty:Tornbull;Bjon:Tornbull;Raphael:Corwill;Alfred:Corwill";
            string expectedStr = "(CORWILL, ALFRED)(CORWILL, FRED)(CORWILL, RAPHAEL)(CORWILL, WILFRED)(TORNBULL, BARNEY)(TORNBULL, BETTY)(TORNBULL, BJON)";
            string actualStr = StringSort(str);
            Assert.AreEqual(expectedStr, actualStr);
        }
    }
}
