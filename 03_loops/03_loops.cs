using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _03_loops
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ForLoops()
        {
            int StudentCount = 15;

            //1 Start
            //2 Condition that while true, keeps loop running
            //3 What happens after each loop
            //4 Body of the loop, what happens after each iteration
            // for  //1
            for (int i = 0; i < StudentCount; i++)   //i = i+i
            {
                Console.WriteLine(i);
            }
        }
        [TestMethod]
        public void ForeachLoops()
        {
            string name = "Eleven Fifty Academy";

            //1 Collection that's being worked on
            //2 Name of the current iteration
            //3 Current type in the collection
            //4 in keyworld, used to seperate the individual and the collection
            //5 body

            foreach (char letter in name)
            {
                Console.WriteLine(letter);
            }
        }

        [TestMethod]
        public void WhileLoops()
        {
            int total = 1;

            //1 Loop runs while the condition is true
            //2 The body of the loop

            while (total != 30)
            {
                Console.WriteLine(total);
                total++; //total = total +1
            }
        }
    }
}
