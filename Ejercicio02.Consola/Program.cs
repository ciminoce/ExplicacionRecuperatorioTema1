namespace Ejercicio02.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double mayorPerimetro = 0;
            double promedioSuperficies = 0;
            int iteracionNro = 0;
            int contadorIteraciones = 0;
            do
            {
                Console.WriteLine("Trabajo con Paralelogramos");
                int lado;
                int baseP;
                int altura;
                contadorIteraciones++;
                do
                {
                    Console.Write("Ingrese el lado del paralelogramo:");
                    if (int.TryParse(Console.ReadLine(), out lado) && lado > 0)
                    {
                        break;
                    }
                    Console.WriteLine("Dato mal ingresado o erróneo");
                } while (true);
                do
                {
                    Console.Write("Ingrese la base del paralelogramo:");
                    if (int.TryParse(Console.ReadLine(), out baseP) && baseP > 0)
                    {
                        break;
                    }
                    Console.WriteLine("Dato mal ingresado o erróneo");
                } while (true);
                double perimetro = GetPerimetro(baseP, lado);
                double superficie = GetSuperficie(baseP, lado);
                Console.WriteLine($"Perímetro: {perimetro}");
                Console.WriteLine($"Superficie: {superficie}");
                promedioSuperficies += superficie;
                if (perimetro>mayorPerimetro)
                {
                    mayorPerimetro = perimetro;
                    iteracionNro = contadorIteraciones;
                }
                string respuesta;
                do
                {
                    Console.Write("¿Desea agregar otro? (S/N):");
                    respuesta = Console.ReadLine();
                    if (respuesta.ToUpper()=="S" || respuesta.ToUpper()=="N")
                    {
                        break;
                    }
                    Console.WriteLine("Ingreso erróneo!!! Solo S/N");
                } while (true);
                if (respuesta.ToUpper()=="N")
                {
                    break;
                }
            } while (true);
            Console.WriteLine($"Mayor perímetro: {mayorPerimetro}");
            Console.WriteLine($"Ingresado en iteración Nro.:  {iteracionNro}");
            promedioSuperficies /= contadorIteraciones;
            Console.WriteLine($"Promedio de superficies: {promedioSuperficies}");
            Console.WriteLine("Fin del Programa");
        }
        private static double GetPerimetro(int baseP, int lado) => 2 * (baseP + lado);
        private static double GetSuperficie(int baseP, int lado) => baseP * lado;

    }
}
