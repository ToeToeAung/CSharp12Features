using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interceptors
{
    public class Example
    {

        public void Method1()
        {
            Console.WriteLine("Calling from Method1");
        }

        public void Method2(string name)
        {
            Console.WriteLine($"Calling from Method2, {name}");
        }
    }
}
