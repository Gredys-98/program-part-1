using System;

namespace Determinar_si_un__numero_es_primo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Determinar si un numero es primo!");
            int a = 0, numero;
            Console.WriteLine("numero");
            numero = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < (numero + 1); i++)
            {
                if (numero % i == 0)
                {
                    a++;
                }
            }
            if (a != 2)
            {
                Console.WriteLine( numero + " No es primo");
            }
            else
            {
                Console.WriteLine(numero + " Si es primo");
            }
            Console.ReadLine();
        }
    }
}
