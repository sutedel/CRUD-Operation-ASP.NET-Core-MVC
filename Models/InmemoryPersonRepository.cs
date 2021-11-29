using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class InmemoryPersonRepository: IPersonRepository
    {
        private readonly List<Person> people = new List<Person>
        {
            new Person
            {
                Id= 1,
                FirstName= "Ahmad",
                LastName= "Jafari"
            }
        };
        public int Add(Person person)
        {
            person.Id = people.Count + 1;
            people.Add(person);
            return person.Id;
        }

        public List<Person> Getall()
        {
            return people;
        }
    }
}
