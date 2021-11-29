using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class Person
    {

        public int Id { get; set; }
        
        public string LastName { get; set; }
        public string FirstName { get;  set; }
    }

    public class PersonDb : DbContext 
    {
        public DbSet<Person> People { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Server=.; initial catalog=PersonDb; Integrated Security=true");

            base.OnConfiguring(optionsBuilder);
        }
    }


}
