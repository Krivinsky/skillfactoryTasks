using NUnit.Framework;

namespace Calculator
{
    [TestFixture]
    public class CalculatorTests
    {
        Calculator calculator = new Calculator();

        [Test]
        public void Multiplication_MustReturnNotNullValue()
        {
            NUnit.Framework.Assert.That(calculator.Multiplication(2, 4) == 8);
        }

        [Test]
        public void Subtraction_MustReturnCorrectValue()
        {
            NUnit.Framework.Assert.That(calculator.Subtraction(5, 3) == 2);
        }

        [Test]
        public void Division_MustThrowException()
        {
            NUnit.Framework.Assert.Throws<DivideByZeroException>(() => calculator.Division(10, 0));
        }

        [Test]
        public void Division_MustReturnCorrectValue()
        {
            NUnit.Framework.Assert.That(calculator.Division(10, 5) == 2); ;
        }


        [Test]
        public void Add_MustReturnCorrectValue()
        {
            NUnit.Framework.Assert.That(calculator.Add(2, 2) == 4);
        }
    }
}
