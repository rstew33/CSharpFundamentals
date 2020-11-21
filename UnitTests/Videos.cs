using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class Videos
    {
        [TestMethod]
        public void TestMethod1()
        {
            //-- Whole Numbers
            byte oneBytesWorth;
            oneBytesWorth = 255;
            short smallWholeNumber = 16;
            Int16 anotherSmallNumber = 16;
            int wholeNumber = 32;
            long largeWholeNumber = 64;

            //-- Decimals
            float floatExample = 1.234f;
            double doubleExample = 1.23d;
            decimal demicalExample = 1.7000m;

            //-- Characters 

            char letter = 'J';

            // -- Operators
            int numOne = 17;
            int numTwo = 5;

            int sum = numOne + numTwo;
            int diff = numOne - numTwo;
            int prod = numOne * numTwo;
            int quot = numOne / numTwo;
            int reminder = numOne % numTwo;

            Console.WriteLine(reminder);
        }

        [TestMethod]
        public void ReferenceTypes()
        {
            // -- Strings
            string stringExample = "hello";
            string declared;
            declared = "now it is initialized";

            string concatonate = stringExample + " " + declared;
            string interpolate = $"{declared}. Here is the string: {stringExample}";

            Console.WriteLine(interpolate);

            // - Other Object Examples
            DateTime now = DateTime.Now;
            Console.WriteLine(now);

            DateTime randomDate = new DateTime(2019, 6, 29);

            TimeSpan waitTime = randomDate - now;
            Console.WriteLine(waitTime.TotalSeconds);


            // -- Collections

            // -- Arrays

            string anotherExample = "Hello World";
            string[] stringArray = { anotherExample, "hello", "World", "!" };
            string[] students = new string[15];

            Console.WriteLine(stringArray);

            // -- Lists
            List<string> listOfStrings = new List<string>();
            listOfStrings.Add("Lawrence");

            // -- Queues
            Queue<string> firstInFirstOut = new Queue<string>();
            firstInFirstOut.Enqueue("Lawrence");

            // -- Dictionaries
            Dictionary<char, string> keyValue = new Dictionary<char, string>();
            keyValue.Add('j', "Josh");


            // -- Other Collections
            SortedList<int, string> sortedKeyValuePair = new SortedList<int, string>();




        }
    }
}
