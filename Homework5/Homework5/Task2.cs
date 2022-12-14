using NUnit.Framework;
using NUnit.Framework.Internal;
using System.Runtime.InteropServices;

namespace Homework5
{
    public class Task2
    {

        public static string FirstNonRepeatingLetter(string inputStr)
        {
            string strLower = inputStr.ToLower();
            int repeatedChar = 0;
            char[] chars = strLower.ToCharArray();
            for (int i = 0; i < strLower.Length; i++)
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
                    if (inputStr.Any(char.IsUpper))
                    {
                        string upperCaseString = chars[i].ToString().ToUpper();
                        return upperCaseString;
                    } else {
                        string lowerCaseString = chars[i].ToString();
                        return lowerCaseString;
                    }
                }
            }
            return " ";
        }
        

        [Test]
        public void FirstNonRepeatingLetterTest1()
        {
            string inputStr = "stress";
            string expectedLetter = "t";
            string actualLetter = FirstNonRepeatingLetter(inputStr);
            Assert.AreEqual(expectedLetter, actualLetter);
        }

        [Test]
        public void FirstNonRepeatingLetterTest2()
        {
            string inputStr = "sTreSS";
            string expectedLetter = "T";
            string actualLetter = FirstNonRepeatingLetter(inputStr);
            Assert.AreEqual(expectedLetter, actualLetter);
        }

        [Test]
        public void FirstNonRepeatingLetterTest3()
        {
            string inputStr = "sttrreess";
            string expectedLetter = " ";
            string actualLetter = FirstNonRepeatingLetter(inputStr);
            Assert.AreEqual(expectedLetter, actualLetter);
        }

        [Test]
        public void FirstNonRepeatingLetterTest4()
        {
            string inputStr = "AbcaBDC";
            string expectedLetter = "D";
            string actualLetter = FirstNonRepeatingLetter(inputStr);
            Assert.AreEqual(expectedLetter, actualLetter);
        }

    }
}
