﻿using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TicketShop.Domain.DomainModels;
using TicketShop.Domain.Identity;

namespace TicketShop.Repository
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public virtual DbSet<Ticket> Tickets { get; set; }
        public virtual DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public virtual DbSet<TicketInShoppingCart> TicketInShoppingCarts { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Ticket>()
                .Property(z => z.Id)
                .ValueGeneratedOnAdd();

            builder.Entity<ShoppingCart>()
                .Property(z => z.Id)
                .ValueGeneratedOnAdd();

            builder.Entity<TicketInShoppingCart>()
                .HasKey(z => new { z.TicketId, z.ShoppingCartId });

            builder.Entity<TicketInShoppingCart>()
                .HasOne(z => z.Ticket)
                .WithMany(z => z.TicketInShoppingCarts)
                .HasForeignKey(z => z.ShoppingCartId);
            builder.Entity<TicketInShoppingCart>()
                .HasOne(z => z.ShoppingCart)
                .WithMany(z => z.TicketInShoppingCarts)
                .HasForeignKey(z => z.TicketId);

            builder.Entity<ShoppingCart>()
                .HasOne<TicketShopAppUser>(z => z.Owner)
                .WithOne(z => z.UserCart)
                .HasForeignKey<ShoppingCart>(z => z.OwnerId);

        }
    }
}

