using Desafio_New_Talent;

namespace Teste_New_Talent
{
    public class CalculatorTest
    {
        private Calculator _calc = new Calculator();

        [Theory]
        [InlineData(2, 3, 5)] 
        [InlineData(-1, -1, -2)]
        [InlineData(0, 5, 5)]
        public void Sum_Two_Numbers(double num1, double num2, double expected)
        {
            // Act
            var result = _calc.Sum(num1, num2);

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(2, 3, -1)]
        [InlineData(-1, -1, 0)]
        [InlineData(5, 0, 5)]
        [InlineData(5, 1, 4)]
        public void Subtraction_Two_Numbers(double num1, double num2, double expected)
        {
            // Act
            var result = _calc.Subtraction(num1, num2);

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(2, 3, 6)]
        [InlineData(-1, -1, 1)]
        [InlineData(-2, 5, -10)]
        public void Multiply_Two_Numbers(double num1, double num2, double expected)
        {
            // Act
            var result = _calc.Multiply(num1, num2);

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(6, 2, "3")]
        [InlineData(-1, -1, "1")]
        [InlineData(-10, 2, "-5")]
        [InlineData(-10, 0, "Can't divide by zero.")]
        public void Divide_Two_Numbers(double num1, double num2, string expected)
        {
            // Act
            var result = _calc.Division(num1, num2);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Check_History()
        {
            // Act
            _calc.Sum(1, 6);
            _calc.Subtraction(4, 1);
            _calc.Multiply(4, 7);
            _calc.Division(9, 3);

            // Assert
            Assert.NotEmpty(_calc.History());
        }
    }
}