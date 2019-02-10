using Microsoft.EntityFrameworkCore;
using DatingApp.Api.Models;
namespace DatingApp.Api.Data
{
    public class DataContext : DbContext
    {
        //Here we are assigning the DbContext options to our DatContext's constructor
        //and then chaining it to the base constructor of DbContext 
        public DataContext(DbContextOptions<DataContext> options) : base (options)
        {
        }
        public DbSet <Value> Values {get; set;}
        // property that takes values of type value(present in model namespace) and the datatype is DbSet 
    }
}