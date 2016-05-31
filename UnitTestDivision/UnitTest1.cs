using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestDivision
{
    [TestClass]
    public class UnitTest1
    {
        /*
         * Identifier: 1.1
         * Description: Testing 7/7 = 1
         * inputs: 7,7
         * Action: do the division
         * Expected result: it will give 1
         * Actual result: will be reported
         * Failed action: Alert the user that the user failed to divide 7/7
        */

        [TestMethod]
        public void Test7DivideBy7()
        {
            
            //Initialize
            double i = 7;
            double j = 7;

            //Act
            double result = DivideProject.Form1.Divide(i, j);

            //Report
            Assert.AreEqual(1, result);

        }
        /*
         * Identifier: 1.2
         * Description: Testing 0/7 = 0
         * inputs: 0,7
         * Action: do the division
         * Expected result: it will give 0
         * Actual result: will be reported
         * Failed action: Alert the user that the user failed to divide 0/7
        */

        [TestMethod]
        public void Test0DivideBy7()
        {

            //Initialize
            double i = 0;
            double j = 7;

            //Act
            double result = DivideProject.Form1.Divide(i, j);

            //Report
            Assert.AreEqual(0, result);

        }
        /*
         * Identifier: 1.3
         * Description: Testing 7/0 = 0
         * inputs: 7,0
         * Action: do the division
         * Expected result: it will give infinity
         * Actual result: will be reported
         * Failed action: Alert the user that the user failed to divide 7/0
        */

        [TestMethod]
        public void Test7DivideBy0()
        {

            //Initialize
            double i = 7;
            double j = 0;

            //Act
            double result = DivideProject.Form1.Divide(i, j);

            //Report
            Assert.AreEqual(double.PositiveInfinity, result);

        }
        /*
         * Identifier: 1.4
         * Description: Testing 7/14 = 0
         * inputs: 7,14
         * Action: do the division
         * Expected result: it will give .5
         * Actual result: will be reported
         * Failed action: Alert the user that the user failed to divide 7/14
        */

        [TestMethod]
        public void Test7DivideBy14()
        {

            //Initialize
            double i = 7;
            double j = 14;

            //Act
            double result = DivideProject.Form1.Divide(i, j);

            //Report
            Assert.AreEqual(0.5, result);

        }
        /*
         * Identifier: 1.5
         * Description: Testing -7/14 = 0
         * inputs: -7,14
         * Action: do the division
         * Expected result: it will give -.5
         * Actual result: will be reported
         * Failed action: Alert the user that the user failed to divide -7/14
        */

        [TestMethod]
        public void TestMinus7DivideBy14()
        {

            //Initialize
            double i = -7;
            double j = 14;

            //Act
            double result = DivideProject.Form1.Divide(i, j);

            //Report
            Assert.AreEqual(-0.5, result);

        }
    }
}
