using System;
using TicketShop.Web.Models.Domain;

namespace TicketShop.Web.Models.DTO
{
    public class AddToShoppingCartDto
    {
        public Ticket SelectedTicket { get; set; }
        public Guid TicketId { get; set; }
        public int Quantity { get; set; }
    }
}
