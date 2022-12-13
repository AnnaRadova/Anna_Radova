using NUnit.Framework;
using NUnit.Framework.Internal;

namespace Homework5
{
    public class Task2
    {
        public static char FirstNonRepeatingLetter(string inputStr)
        {
            int repeatedChar = 0;
            char[] chars = inputStr.ToCharArray();
            for (int i = 0; i < inputStr.Length; i++)
            {
                repeatedChar = 0;
                for (int j = 0; j < chars.Length; j++)
                {
                    if ((i != j) && (chars[i] == chars[j]))
                    {
                        repeatedChar++;
                        break;
                    }
                }
                if (repeatedChar == 0)
                {
                    return chars[i];
                }
            }
            return ' ';
        }

        [Test]
        public void FirstNonRepeatingLetterTest1()
        {
            string inputStr = "stress";
            char expectedLetter = 't';
            char actualLetter = FirstNonRepeatingLetter(inputStr);
            Assert.AreEqual(expectedLetter, actualLetter);
        }

        [Test]
        public void FirstNonRepeatingLetterTest2()
        {
            string inputStr = "sTress";
            char expectedLetter = 'T';
            char actualLetter = FirstNonRepeatingLetter(inputStr);
            Assert.AreEqual(expectedLetter, actualLetter);
        }

        [Test]
        public void FirstNonRepeatingLetterTest3()
        {
            string inputStr = "sttrreess";
            char expectedLetter = ' ';
            char actualLetter = FirstNonRepeatingLetter(inputStr);
            Assert.AreEqual(expectedLetter, actualLetter);
        }
    }
}
