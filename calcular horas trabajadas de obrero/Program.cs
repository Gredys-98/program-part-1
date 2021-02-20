using System;

namespace clacular_horas_trabajadas_de_obrero
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int horas;
                string aumento;


                Console.WriteLine("ingrese las horas trabajadas!");
                aumento = Console.ReadLine();

                horas = int.Parse(aumento);
                float total = horas * 16;
                float horastotal = horas;
                Console.WriteLine("\nsu sueldo es:");
                aumento = Console.ReadLine();
                Console.Write(total + horastotal);

                if (horas >40)
                {
                    float tot = horas;
                    Console.Write("\npor haber trabajo mas de 40 horas tiene un aumento de:");
                    aumento = Console.ReadLine();
                    Console.Write(tot);
                }
               
                   
                    
                
            }
        }
    }
}
