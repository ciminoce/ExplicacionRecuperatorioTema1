namespace Ejercicio01.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Trabajo con Paralelogramos");
            int lado;
            int baseP;
            int altura;
            do
            {
                Console.Write("Ingrese el lado del paralelogramo:");
                if (int.TryParse(Console.ReadLine(), out lado) && lado>0)
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
        }
        private static double GetPerimetro(int baseP,int lado)=>2*(baseP+lado);
        private static double GetSuperficie(int baseP, int lado) => baseP * lado;
    }
}
