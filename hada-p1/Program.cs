using System;
using hada_p1;
namespace hada_p1
{
    class Program
    {
        //maIN
        static void Main(string[] args)
        {
            string respuesta;
            string seguir;
            string unidad;
            double pasar;
            HadaP1 obj = new HadaP1();
            do
            {


                Console.WriteLine("¿De que unidad partimos s/m/h?");
                respuesta = Console.ReadLine();
                
                if (respuesta == "s")
                {
                    Console.WriteLine("Introduce los segundos que quieres convertir");
                    unidad = Console.ReadLine();
                    pasar = double.Parse(unidad);
                    double v = HadaP1.Seconds2Minutes(pasar);
                    Console.WriteLine("Hemos pasado de " + pasar + " segundos a " + v +" minutos");
                }
                else if(respuesta == "h"){

                    Console.WriteLine("Introduce las horas que quieres convertir");
                    unidad = Console.ReadLine();
                    pasar = double.Parse(unidad);
                    double v = HadaP1.Hours2Minutes(pasar);
                    Console.WriteLine("Hemos pasado de " + pasar + " horas a " + v + " minutos");


                }
                else
                {
                    Console.WriteLine("Introduce los minutos que quieres convertir");
                    unidad = Console.ReadLine();
                    pasar = double.Parse(unidad);
                    double w =HadaP1.Minutes2Seconds(pasar);
                    Console.WriteLine("Hemos pasado de " + pasar + " minutos a " + w + " segundos");
                }
                Console.WriteLine("¿Quieres seguir? Si/No");
                seguir = Console.ReadLine();

            } while (seguir == "Si");

        }

    }
}
