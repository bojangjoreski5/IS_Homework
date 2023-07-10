using System;
using System.Collections.Generic;

namespace TicketShop.Domain.DomainModels
{
    public class TicketInShoppingCart
    {
        public Guid TicketId { get; set; }
        public Ticket Ticket { get; set; }
        public Guid ShoppingCartId { get; set; }
        public ShoppingCart ShoppingCart { get; set; }
        public int Quantity { get; set; }
        public virtual ICollection<TicketInShoppingCart> TicketInShoppingCarts { get; set; }


    }
}
