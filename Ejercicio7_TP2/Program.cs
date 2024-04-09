namespace Ejercicio7_TP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Base, Altura, Resultado;
            string linea;

            //Solicitar al usuario que ingrese la base
            Console.WriteLine("Ingrese la base: ");
            Base = double.Parse(Console.ReadLine());
            //Solicitar al usuario que ingrese la altura
            Console.WriteLine("Ingrese la altura");
            Altura = double.Parse(Console.ReadLine());
            
            //Calcula la hipotenusa
            Resultado = Math.Sqrt(Math.Pow(Base, 2) + Math.Pow(Altura, 2));
            //Imprime la hipotenusa
            Console.WriteLine("Hipotenusa = " + string.Format("{0:####.00}",Resultado));

            //Calcula el area del triangulo
            linea = Convert.ToString(Base * Altura / 2);
            //Imprime el area
            Console.WriteLine("Area = " + string.Format("{0:####.00}", linea));
        }
    }
}
