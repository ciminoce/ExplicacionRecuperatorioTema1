
using ConsoleTables;
using Ejercicio04.Entidades;

namespace Ejercicio04.Consola
{
    internal class Program
    {
        static Paralelogramo[] paralelogramos = new Paralelogramo[5];
        static int contador=0;
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Menú Principal");
                Console.WriteLine("1-Ingreso de Datos");
                Console.WriteLine("2-Listado de Datos");
                Console.WriteLine("x-Salir");
                Console.Write("Ingrese opción:");
                string opcionSeleccionada=Console.ReadLine();
                switch (opcionSeleccionada)
                {
                    case "1":
                        IngresoDeDatos();
                        break;
                    case "2":
                        ListadoDeDatos();
                        break;
                    default:
                        break;
                }
            } while (true);
        }
        private static bool EstaVacio()=>contador==0;
        private static void ListadoDeDatos()
        {
            Console.Clear();
            Console.WriteLine("Listado de Paralelogramos");
            if (EstaVacio())
            {
                Console.WriteLine("Array sin datos todavía!!!");
                Console.WriteLine("Presione Enter para continuar");
                Console.ReadLine();
            }
            else
            {
                var tabla = new ConsoleTable("Pos", "Lado", "Base");
                int contadorPosiciones = 0;
                foreach (var item in paralelogramos)
                {
                    if (item.Lado>0)
                    {
                        tabla.AddRow(contadorPosiciones,
                            item.Lado,
                            item.Base);

                    } 
                }
                Console.WriteLine(tabla.ToString());
                Console.WriteLine("Presione Enter para continuar");
                Console.ReadLine();

            }

        }

        private static void IngresoDeDatos()
        {
            Console.WriteLine("Ingreso de Datos");
            int lado;
            int baseP;
            do
            {
                Console.Write("Ingrese el lado del paralelogramo:");
                if (int.TryParse(Console.ReadLine(), out lado))
                {
                    break;
                }
                Console.WriteLine("Dato mal ingresado o erróneo");
            } while (true);
            do
            {
                Console.Write("Ingrese la base del paralelogramo:");
                if (int.TryParse(Console.ReadLine(), out baseP))
                {
                    break;
                }
                Console.WriteLine("Dato mal ingresado o erróneo");
            } while (true);
            Paralelogramo p = new Paralelogramo(lado, baseP);
            if (p.Valido())
            {
                double perimetro = p.GetPerimetro();
                double superficie = p.GetSuperficie();
                Console.WriteLine($"Perímetro: {perimetro}");
                Console.WriteLine($"Superficie: {superficie}");

                paralelogramos[contador] = p;
                contador++;
            }
            else
            {
                Console.WriteLine("Los datos proporcionados no conforman un paralelogramo");
            }

            Console.WriteLine("Presione Enter para continuar");
            Console.ReadLine();
        }
    }
}
