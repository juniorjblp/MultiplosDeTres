using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fatorial
{
    public class FatorialLacoFor
    {
        public void CalcularFatorial()
        {
            double i, numeroMinimo, numeroMaximo, fatorial;

            Console.WriteLine("INICIO DO LAÇO FOR");

            Console.WriteLine("Digite o número mínimo: ");
            numeroMinimo = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o número máximo: ");
            numeroMaximo = double.Parse(Console.ReadLine());

            fatorial = numeroMinimo;

            for (i = numeroMinimo; i <= numeroMaximo; i++)
            {
                Console.WriteLine(i + " * Fatorial do número anterior");
                Console.WriteLine(i + " * " + fatorial);

                fatorial = fatorial * i;

                
                Console.WriteLine("Resultado " + fatorial);
                Console.WriteLine("----------");
            }

            Console.WriteLine("FIM DO LAÇO FOR");            
            
        }
    }
}
