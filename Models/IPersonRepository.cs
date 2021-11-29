using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public interface IPersonRepository
    {
        int Add(Person person);
        List<Person> Getall();

    }
    
}
