using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TicketApi.Models;
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;


namespace TicketApi.DAL
{
    public class TicketContext : DbContext
    {
        public TicketContext(DbContextOptions<TicketContext> options): base(options){}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public DbSet<Ticket> Tickets { get; set; }
    }
}
