using System;

namespace Dias_de_semana_y_si_es_laboral
{
    class Program
    {
        static void Main(string[] args)
        {
            string dias;
            Console.WriteLine("ingresa un dia");
            dias = Console.ReadLine();
            switch (dias)
            {
                case "lunes": Console.WriteLine("es laboral"); break;

                case "martes": Console.WriteLine("es laboral"); break;

                case "miercoles": Console.WriteLine("es laboral"); break;

                case "jueves": Console.WriteLine("es laboral"); break;

                case "vernes": Console.WriteLine("es laboral"); break;

                case "sabado": Console.WriteLine("es laboral"); break;

                case "domingo": Console.WriteLine(" no es laboral"); break;

            }
            Console.ReadKey();
        }
    }
}
