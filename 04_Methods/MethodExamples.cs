using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _04_Methods
{
    [TestClass]
    public class MethodExamples
    {
        //Input
        //What we do
        //Output

        //Access modifier - return type - method signature (name and list of parameters)

        public int AddTwoNumbers(int numOne, int numTwo)
        {
            int sum = numOne + numTwo;
            return sum;
        }

        private int SubtractTwoNumbers(int a, int b)
        {
            int num = a - b;
            return num;
        }

        private int MultiplyTwoNumbers(int x, int z)
        {
            int prod = x * z;
            return prod;

        }

        private int DivideTwoNumbers(int a, int b)
        {
            int div = a / b;
            return div;
        }



        [TestMethod]
        public void MethodTests()
        {
            int banana = AddTwoNumbers(7, 12);
            int sumTwo = AddTwoNumbers(5, 42);

            Assert.AreEqual(19, banana);

        }
    }
}
