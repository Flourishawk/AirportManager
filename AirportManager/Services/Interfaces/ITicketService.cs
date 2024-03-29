using AirportManager.Models;

namespace AirportManager.Services.Interfaces
{
    internal interface ITicketService
    {
        List<Ticket> GetAllTickets();
        void AddTicket(Ticket ticket);
        void UpdateTicket(Ticket ticketBeforeChanges, DateTime departureTime, DateTime purchaseTime, DateTime expirationTime, sbyte? seat, int? passangerId);
        void DeleteTicket(Ticket ticket);
    }
}
