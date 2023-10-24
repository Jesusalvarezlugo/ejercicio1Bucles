using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1Bucles.servicios
{
    internal class operacionesImplementacion : operacionesInterfaz
    {
        public int PedirNumero()
        {
            int numero;

            Console.WriteLine("Introduce un número entero mayor que 0");
            numero = Int32.Parse(Console.ReadLine());

            while (numero == 0)
            {
                Console.WriteLine("Introduce un número entero mayor que 0");
                numero = Int32.Parse(Console.ReadLine());
            }

            return numero;
        }

        public void Suma(int numero)
        {
            int i;
            int suma=0;
           
            for ( i=0;i<=numero;i++)
            {


                suma += i;

            }

            Console.WriteLine("La suma es:{0}",suma);

           


        }
    }
}
