using ItemStore.WebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace ItemStore.WebApi.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Item> Items { get; set; }
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
    }
}
