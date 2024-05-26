using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Interceptors
{
    public static class Interception
    {
        private const string V = "C:\\Users\\toeto\\OneDrive\\Desktop\\CSharp12Features\\Interceptors\\Program.cs";

        //[InterceptsLocation(
        //filePath: V,
        //line: 6,
        //character: 9)]
        public static void InterceptMethod1(this Example example) => Console.WriteLine("Hello from Interceptor.");
    }

    
}
