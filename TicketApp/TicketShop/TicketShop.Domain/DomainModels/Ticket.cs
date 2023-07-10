using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TicketShop.Domain.DomainModels
{
    public class Ticket
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        public string TicketName { get; set; }
        [Required]
        public string TicketImage { get; set; }
        [Required]
        public int TicketPrice { get; set; }
        [Required]
        public string TicketDescription { get; set; }
        [Required]
        public int TicketDate { get; set; }
        public virtual ICollection<TicketInShoppingCart> TicketInShoppingCarts { get; set; }
    }
}
