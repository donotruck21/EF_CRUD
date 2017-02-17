using Microsoft.EntityFrameworkCore;
using MySQL.Data.EntityFrameworkCore.Extensions;
namespace EFPerson.Models{
    public class PersonContext : DbContext{
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            string Server = "localhost";
            string Port = "8889";
            string Database = "EFPerson";
            string UserId = "root";
            string Password = "root";
            string Connection = $"Server={Server};port={Port};database={Database};uid={UserId};pwd={Password};SslMode=None;";
            optionsBuilder.UseMySQL(Connection);
        }


        public DbSet<Person> Persons { get; set; }
    }
}