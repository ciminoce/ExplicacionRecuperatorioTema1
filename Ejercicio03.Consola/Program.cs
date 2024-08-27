using Ejercicio03.Entidades;

namespace Ejercicio03.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Trabajo con Paralelogramos");
            int lado;
            int baseP;
            do
            {
                Console.Write("Ingrese el lado del paralelogramo:");
                if (int.TryParse(Console.ReadLine(), out lado) )
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
            Paralelogramo p=new Paralelogramo(lado,baseP);
            if (p.Valido())
            {
                double perimetro = p.GetPerimetro();
                double superficie = p.GetSuperficie();
                Console.WriteLine($"Perímetro: {perimetro}");
                Console.WriteLine($"Superficie: {superficie}");

            }
            else
            {
                Console.WriteLine("Los datos proporcionados no conforman un paralelogramo");
            }

        }
    }
}
