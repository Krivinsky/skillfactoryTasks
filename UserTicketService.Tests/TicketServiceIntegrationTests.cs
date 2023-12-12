using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UserTicketService.Tests
{
    [TestClass]
    public class TicketServiceIntegrationTests
    {
        [DataTestMethod]
        public void SaveTicketMustAddTicketInBase()
        {
            var ticketServiceTest = new TicketService();
            
            var newTicket = new Ticket(300, "Test ticket", 1000);

            ticketServiceTest.SaveTicket(newTicket);

            var allTicketsAfterAddingNewTicket = ticketServiceTest.GetAllTickets();

            PrivateObject obj = new PrivateObject(ticketServiceTest);

            NUnit.Framework.Legacy.CollectionAssert.Contains(allTicketsAfterAddingNewTicket, newTicket);

            obj.Invoke("DeleteTicket", newTicket);

            var allTicketsAfterDeletingNewTicket = ticketServiceTest.GetAllTickets();
            NUnit.Framework.Legacy.CollectionAssert.DoesNotContain(allTicketsAfterDeletingNewTicket, newTicket);
        }
    }
}
