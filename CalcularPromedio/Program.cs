using System;

namespace CalcularPromedio
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Seleccion una opcion");
            Console.WriteLine("1- lista materia \n 2-agregar materia \n 3-borrar materia \n 4- editar materia");
            int menu = Convert.ToInt32(Console.ReadLine());

            switch (menu)
            {
                case 1:
                    Console.WriteLine("Listo materia");
                    break;
                case 2:
                    Console.WriteLine("agrego materia");
                    break;
                case 3:
                    Console.WriteLine("borro materia");
                    break;
                case 4:
                    Console.WriteLine("edito materia");
                    break;
                default:
                    Console.WriteLine("no se");
                    break;
            }

         
            Console.WriteLine("Digite los siguientes numeros para calcular el promedio");
            Console.WriteLine("Introduzca el valor del primer numero");
            int Numero1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduzca el valor del segundo numero");
            int Numero2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduzca el valor del tercer numero");
            int Numero3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduzca el valor del cuarto numero");
            int Numero4 = Convert.ToInt32(Console.ReadLine());

            double Resultado = (Numero1 + Numero2 + Numero3 + Numero4) / 4;

            if (Resultado >= 70)
            {

                if (Resultado >= 70 && Resultado <= 79)
                {
                    Console.WriteLine("El promedio es " + Resultado + " y la literal es C");
                }
                else if (Resultado >= 80 && Resultado <= 89)
                {
                    Console.WriteLine("El promedio es " + Resultado + " y la literal es B");
                }
                else
                {
                    Console.WriteLine("El promedio es " + Resultado + " y la literal es A");
                }
            }
            else
            {
                Console.WriteLine("El promedio es " + Resultado + " usted es un penco");
            }


            Console.ReadKey();
        }
    }
}
