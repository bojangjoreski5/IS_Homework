using Microsoft.AspNetCore.Identity;
using TicketShop.Web.Models.Domain;

namespace TicketShop.Web.Models.Identity
{
    public class TicketShopAppUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public virtual ShoppingCart UserCart { get; set; }
    }
}
