using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    abstract public class Person
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public DateTime BirthDate { get; set; }

        public Person(Guid id, string? name, DateTime birthDate)
        {
            Id = id;
            Name = name;
            BirthDate = birthDate;
        }
        public override string ToString() =>
            $@"Guid:{Id}
Name:{Name}
Birthday:{BirthDate.ToShortDateString()}
";      
        public virtual void CalculateAge()
        {
            Console.WriteLine("Age:"+(DateTime.Now.Year-BirthDate.Year));
        }

    }
}
