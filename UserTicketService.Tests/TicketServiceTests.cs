global using NUnit.Framework;

namespace UserTicketService.Tests
{
    [TestFixture]
    public class TicketServiceTests
    {
        [Test]
        public void GeTicketPriceMustReturnNotNullableTicket()
        {
            var ticketServiceTest = new TicketService();
            NUnit.Framework.Assert.That(ticketServiceTest.GetTicketPrice(1) == 3500);
        }

        [Test]
        public void GeTicketPriceMustThrowException()
        {
            var ticketServiceTest = new TicketService();
            NUnit.Framework.Assert.Throws<TicketNotFoundException>(() => ticketServiceTest.GetTicketPrice(100));
        }

        [Test]
        public void GetTicketMustReturnNotNullableTicket()
        {
            var ticketServiceTest = new TicketService();
            NUnit.Framework.Assert.That(ticketServiceTest.GetTicket(1) != null);

        }

    }
}
