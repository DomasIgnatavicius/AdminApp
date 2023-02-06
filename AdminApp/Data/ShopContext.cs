using AdminApp.Models;
using Microsoft.EntityFrameworkCore;

namespace AdminApp.Data
{
    public class ShopContext: DbContext
    {
        public ShopContext(DbContextOptions<ShopContext> options)
            : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Staff> Staff { get; set; }
        public DbSet<Office> Offices { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .HasData(
                new Product(1,"Bracelet",14.99,"You can put it on your hand",4.2,4478,21675.54,1446,5,DateTime.Now,DateTime.Now),
                new Product(2,"White T-Shirt",21.99,"Perfectly balanced",3.6,14889,30324.33,1335,2,DateTime.Now,DateTime.Now),
                new Product(3,"Denim Jeans",35.00,"Good even for riding",4.9,5874,33320,952,1,DateTime.Now,DateTime.Now),
                new Product(4,"Orange Sweater",25.99,"For cold winters",3.8,1336,20662.05,795,3,DateTime.Now,DateTime.Now),
                new Product(5,"Jeans jacket",59.99,"Casual wear",5.4,4478,21675.54,1446,4,DateTime.Now,DateTime.Now)
                );
            modelBuilder.Entity<Category>()
                .HasData(
                new Category(1,"Trousers",DateTime.Now,DateTime.Now),
                new Category(2,"T-Shirts",DateTime.Now,DateTime.Now),
                new Category(3,"Sweaters",DateTime.Now,DateTime.Now),
                new Category(4,"Jackets",DateTime.Now,DateTime.Now),
                new Category(5,"Accesories",DateTime.Now,DateTime.Now)
                );
            modelBuilder.Entity<Transaction>()
                .HasData(
                new Transaction(1,1,255,DateTime.Now,DateTime.Now),
                new Transaction(2,2,345,DateTime.Now,DateTime.Now),
                new Transaction(3,1,399,DateTime.Now,DateTime.Now),
                new Transaction(4,4,265,DateTime.Now,DateTime.Now),
                new Transaction(5,3,146,DateTime.Now,DateTime.Now)
                );
            modelBuilder.Entity<Client>()
            .HasData(
            new Client(1,"Anthony","Jhones","a.jhones@gmail.com","Berlin","Germany","Long str. 18-5",+45755362,DateTime.Now,DateTime.Now),
            new Client(2,"Jack","Smith","j.smiths@gmail.com","London","UK","Long str. 18-5",+45755362,DateTime.Now,DateTime.Now),
            new Client(3,"James","Cameron","james.camerons@gmail.com","New York","US","Long str. 18-5",+45755362,DateTime.Now,DateTime.Now),
            new Client(4,"Carolina","Antuanete","carol.antuan@gmail.com","Madrid","Spain","Long str. 18-5",+45755362,DateTime.Now,DateTime.Now),
            new Client(5,"Jesicca","Benton","jess.benton@gmail.com","Rome","Italy","Long str. 18-5",+45755362,DateTime.Now,DateTime.Now)
            );
            modelBuilder.Entity<Staff>()
            .HasData(
            new Staff(1,"Admin","Root","admin.root@adminapp.com","root",1,DateTime.Now,DateTime.Now)
            );
            modelBuilder.Entity<Office>()
            .HasData(
            new Office(1,"Vilnius","Lithuania","Vilnius str.",DateTime.Now,DateTime.Now)
            );
        }
    }
    
}
