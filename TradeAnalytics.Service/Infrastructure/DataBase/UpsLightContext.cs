using Microsoft.EntityFrameworkCore;
using System.Net;
using TradeAnalitycs.Service.Models;

namespace TradeAnalitycs.Service
{
    public class UpsLightContext : DbContext
    {
        public DbSet<ProductTrade> ProductTrade { get; set; }

        protected UpsLightContext() { }
        public UpsLightContext (DbContextOptions options) : base(options)
        {

        }
    }
}
