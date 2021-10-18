using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplosDeTres
{
    class Program
    {
        static void Main(string[] args)
        {
            MultiplosLacoFor multiplosLacoFor = new MultiplosLacoFor();
            MultiplosLacoWhile multiplosLacoWhile = new MultiplosLacoWhile();

            multiplosLacoFor.Multiplicar();

            multiplosLacoWhile.Multiplicar();

            Console.ReadLine();

                    
        }
        
    }
}
