using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplosDeTres
{
    class MultiplosLacoWhile
    {
        public void Multiplicar()
        {
            Console.WriteLine("COMEÇO DO LAÇO WHILE");

            int cont = 0;

            while (cont < 50)
            {
                cont++;

                if (cont % 3 == 0)
                {
                    Console.WriteLine(cont + " É multiplo de 3");
                }
                else
                {
                    /*Console.WriteLine(cont + " Não é multiplo de 3");*/
                }
            }
            Console.WriteLine("FIM DO LAÇO WHILE");
        }
    }
}
