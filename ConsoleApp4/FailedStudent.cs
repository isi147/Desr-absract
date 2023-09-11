using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Sealed keywordune example
namespace ConsoleApp4
{
    public sealed class FailedStudent : Student
    {
        public int FailedCount { get; set; }
        public FailedStudent(Guid id, string? name, DateTime birthDate, float average, int failedCount) : base(id, name, birthDate, average)
        {
            FailedCount = failedCount;
        }

        



    }
}
