using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookListRazor.Model
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {

        }

        public DbSet<Book> Book { get; set; }
        public DbSet<Account> Account { get; set; }
        //public DbSet<Client> Client { get; set; }
        public DbSet<Order> Order { get; set; }
        /*public DbSet<Order_Item> Order_Item { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Shopping_Cart> Shopping_Cart { get; set; }
        public DbSet<Shopping_Cart_Item> Shopping_Cart_Item { get; set; }
        */
    }
}
