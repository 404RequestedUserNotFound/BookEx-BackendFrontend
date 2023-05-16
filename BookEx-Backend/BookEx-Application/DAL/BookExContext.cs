using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BookExContext : DbContext
    {
        public DbSet<Admin> Admin { get; set; }
        public DbSet<Book> Book { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderItem> OrderItem { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Receipt> Receipt { get; set; }
        public DbSet<Author> Author { get; set; }
        public DbSet<Publisher> Publisher { get; set; }
        public DbSet<Borrow> Borrow { get; set; }
        public DbSet<Reservation> Reservation { get; set; }



    }
}
