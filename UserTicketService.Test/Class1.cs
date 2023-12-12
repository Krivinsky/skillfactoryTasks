
using NUnit;
using NUnit.Framework;

namespace UserTicketService.Tests
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void Test1()
        {
            Xunit.Assert.True(100 == 100);
        }

        [Test]
        public void Subtraction_MustReturnCorrectValue()
        {
            Calculator calculator = new Calculator();
            Assert.That(calculator.Subtraction(300, 10) == 290);
        }
    }


}