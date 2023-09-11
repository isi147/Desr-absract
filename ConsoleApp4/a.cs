using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    abstract public class a
    {

        abstract public int n { get; }




    }

    class b : a
    {
        public override int n => throw new NotImplementedException();
    }
}
