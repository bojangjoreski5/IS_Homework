using System;
using System.Collections.Generic;
using TicketShop.Web.Models.Identity;

namespace TicketShop.Web.Models.Domain
{
    public class ShoppingCart
    {
        public Guid Id { get; set; }
        public string OwnerId { get; set; }
        public TicketShopAppUser Owner { get; set; }
        public virtual ICollection<TicketInShoppingCart> TicketInShoppingCarts { get; set; }

    }
}
