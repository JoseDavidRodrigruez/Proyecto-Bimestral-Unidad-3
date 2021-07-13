using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Bimestral_Unidad_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string r = "s";
            while (r == "s")
            {
                Console.WriteLine("Calculo de masa corporal");
                Console.WriteLine("");

                double peso = 0;
                double altura = 0;
                double mc = 0;

                Console.Write("Ingresa tu peso (en Kilogramos) -   ");
                try
                {
                    peso = double.Parse(Console.ReadLine());
                    Console.WriteLine(peso + "Kg.");
                }
                catch { Console.WriteLine("Ingresa solamente datos numericos."); Console.WriteLine(""); }

                Console.Write("Ingresa tu altura (en metros y .) -   ");
                try
                {
                    altura = double.Parse(Console.ReadLine());
                    Console.WriteLine(altura + "m.");
                }
                catch { Console.WriteLine("Ingresa solamente datos numericos."); Console.WriteLine(""); }

                mc = peso / (altura * altura);
                mc = Math.Round(mc, 2);

                if (mc <= 18)
                {
                    Console.WriteLine("Peso bajo, " + mc + " Kg.");
                }
                if (mc > 18 && mc < 25)
                {
                    Console.WriteLine("Peso normal, " + mc + " Kg.");
                }
                if (mc > 25 && mc <= 30)
                {
                    Console.WriteLine("Peso elevado, " + mc + " Kg.");
                }
                else if (mc > 30)
                {
                    Console.WriteLine("Sobrepeso, " + mc + " Kg.");
                }

                Console.WriteLine("");
                Console.WriteLine("¿Quieres hacer otro calculo?");
                Console.WriteLine("s/n");
                r = Console.ReadLine();
                if (r == "n" || r != "s")
                {
                    return;
                }
                Console.Clear();
            }

            Console.ReadKey();
        }
    }
}
