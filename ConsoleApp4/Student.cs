using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    
    public class Student : Person
    {
        public float Average { get; set; }
        public Student(Guid id, string? name, DateTime birthDate, float average) : base(id, name, birthDate)
        {
            Average = average;
        }
        public sealed override string ToString()
        {
            return base.ToString() + "Average:" + Average.ToString();

        }
        override 
        //new keyword example
        //public new string ToString()
        //{
        //    return base.ToString() + "Average:" + Average.ToString();

        //}
    }
}
