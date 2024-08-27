namespace Ejercicio03.Entidades
{
    public struct Paralelogramo
    {
        public int Lado { get; set; }
        public int Base { get; set; }
        public Paralelogramo(int lado, int baseP)
        {
            Lado = lado;
            Base = baseP;
        }
        public double GetPerimetro() => 2 * (Base + Lado);
        public double GetSuperficie() => Base * Lado;
        public bool Valido()=>Base>0 && Lado > 0;
    }
}
