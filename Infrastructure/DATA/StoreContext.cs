
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.DATA
{
    public class StoreContext(DbContextOptions options) : DbContext(options)
    {
        public required DbSet<Product> Products { get; set; }
    }
}