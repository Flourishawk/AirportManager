using AirportManager.Models;

namespace AirportManager.Services.Interfaces
{
    internal interface ITicketService
    {
        List<Ticket> GetAllTicket();
        void AddTicket(Ticket ticket);
        void UpdateTicket(Ticket ticket, );
        void DeleteTicket(Ticket ticket);
    }
}
