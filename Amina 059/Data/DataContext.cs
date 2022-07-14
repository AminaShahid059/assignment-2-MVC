using Amina_059.Models;
using Microsoft.EntityFrameworkCore;

namespace Amina_059.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<customer_contact> customer_contact { get; set; }
    }
}
