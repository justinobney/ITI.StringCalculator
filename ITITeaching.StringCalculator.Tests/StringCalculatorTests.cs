using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ITITeaching.StringCalculator.Domain;

namespace ITITeaching.StringCalculator.Tests
{
    [TestClass]
    public class StringCalculatorTests
    {
        private Domain.StringCalculator target;

        [TestInitialize]
        public void Init() {
            target = new Domain.StringCalculator();
        }

        [TestMethod]
        public void Add_ShouldReturnZeroForEmpty()
        {
            // Arrange
            int expected = 0;

            // Act
            int actual = target.Add("");

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_ShouldReturnInputAsParsedNumber()
        {
            // Arrange
            int expected = 7;

            // Act
            int actual = target.Add("7");

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_ShouldSumTwoCommaSeperatedNumbers()
        {
            // Arrange
            int expected = 3;

            // Act
            int actual = target.Add("1,2");

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_ShouldSumAllCommaSeperatedNumbers()
        {
            // Arrange
            int expected = 15;

            // Act
            int actual = target.Add("1,2,3,4,5");

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_ShouldAcceptNewlineAsSeperator()
        {
            // Arrange
            int expected = 6;

            // Act
            int actual = target.Add("1\n2,3");

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_ShouldAcceptCustomDelimiters()
        {
            // Arrange
            int expected = 3;

            // Act
            int actual = target.Add("//!\n1!2");

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
