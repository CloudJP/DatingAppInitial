using DatingApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Data
{
    public class DataContext:DbContext
    {
        //DbContext Installation
        //Open cmd line and search for nuget package manager->Microsoft.EntityFrameworkCore
        //Select Microsoft.EntityFrameworkCore from the options and select 3.0.0 version
        public DataContext(DbContextOptions<DataContext> options):base(options){}        
        public DbSet<Value> Values { get; set; }
        //The name should be match with the table name(Values)
        //To use this context we should declae it in startup.cs file
        //services.AddDbContext<DataContext>()

    }
}