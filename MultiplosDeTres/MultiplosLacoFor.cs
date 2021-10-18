using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplosDeTres
{
   public class MultiplosLacoFor
    {
       
        public void Multiplicar()
        {
            Console.WriteLine("COMEÇO DO LAÇO FOR");
            
           
            for (int i = 0; i <= 50; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i + " É multiplo de 3");


                }
                else
                {
                   // Console.WriteLine(i + " Não é multiplo de 3");
                }
            }
            Console.WriteLine("FIM DO LAÇO FOR\n");
        }

    }
}
