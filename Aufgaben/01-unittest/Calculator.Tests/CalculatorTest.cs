using System;
using Xunit;

namespace Calculator.Tests
{
    public class CalculatorTest
    {
        [Fact]
        public void TestAddThreeToTwoPIsFive()
        {
            // Arrange
            int a = 2;
            int b = 3;
            int expected = 5;
            Calculator calculator = new Calculator();

            // Act
            int actual = calculator.Add(a, b);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestSubtractFourFromSixIsTwo()
        {
            // Given
            int a = 6;
            int b = 4;
            int expected = 2;
            Calculator calculator = new Calculator();

            // When
            int actual = calculator.Subtract(a, b);

            // Then
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Multiplikation()
        {
            //Arrange
            int p1 = 5;
            int p2 = 4;
            int expect = 20;
            Calculator calculator = new Calculator();

            //Act
            int Resultat = calculator.Multiply(p1, p2);

            //assert
            Assert.Equal(expect, Resultat);
        }


        [Fact]
        public void Division()
        {
            //Arrange
            int p1 = 20;
            int p2 = 4;
            int expect = 5;
            Calculator calculator = new Calculator();

            //Act
            int Resultat = calculator.Division(p1, p2);

            //assert
            Assert.Equal(expect, Resultat);
        }

        [Fact]
        public void DividedByZeroException()
        {
            //Arrange
            int p1 = 20;
            int p2 = 0;
            Calculator calculator = new Calculator();

            //assert
            Assert.Throws<DivideByZeroException>(() => calculator.Division(p1, p2));
        }

        [Fact]
        public void ArgumentException()
        {
            //Arrange
            int p1 = 20;
            int p2 = 0;
            Calculator calculator = new Calculator();

            //assert
            Assert.Throws<ArgumentException>(() => calculator.Division(p1, p2));



        }
    }
}
