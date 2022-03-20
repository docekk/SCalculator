using NUnit.Framework;
using System;
using System.IO;

namespace SCalculator.UnitTests
{
    public class Tests
    { 
        Calculator calculator = new Calculator();


        [TestCase("arg x = 5", "calc x", "5\r\n")]
        [TestCase("arg zmienna = 26", "calc zmienna", "26\r\n")]
        [TestCase("arg xDwDgj = 12", "calc xDwDgj", "12\r\n")]
        public void Is_Adding_Arguments(string arg,string write,string expected)
        {
            //arrange
            var stringWriter = new StringWriter();

            //act
            calculator.SetInput(arg);
            calculator.Action();
            Console.SetOut(stringWriter);
            calculator.SetInput(write);
            calculator.Action();

            //assert
            var result = stringWriter.ToString();
            Assert.AreEqual(expected, result);
        }


        [TestCase("calc 5+10", "15\r\n")]
        [TestCase("calc 5*10", "50\r\n")]
        [TestCase("calc 20/2", "10\r\n")]
        [TestCase("calc 10^2", "100\r\n")]
        [TestCase("calc sqrt(16)+10/2", "9\r\n")]
        public void Is_Calculating(string operation, string expected)
        {
            var stringWriter = new StringWriter();


            calculator.SetInput(operation);
            Console.SetOut(stringWriter);
            calculator.Action();


            var result = stringWriter.ToString();
            Assert.AreEqual(expected, result);
        }
    }
}