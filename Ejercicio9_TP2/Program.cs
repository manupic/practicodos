namespace Ejercicio9_TP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte CantidadNro, c;
            int Nro;
            Random ran = new Random(); // Iniciar generador random

            // Solicitar al usuario la cantidad de números aleatorios a generar
            Console.Write("Ingrese la cantidad de números aleatorios a generar: ");
            CantidadNro = byte.Parse(Console.ReadLine());

            // Operaciones
            for (c = 0; c < CantidadNro; c++)
            {
                // Genera numero aleatorio limitado a 100
                Nro = ran.Next(100);

                // Para cada número, mostrar el carácter ASCII
                Console.WriteLine($"Número random: {Nro} - Caracter ASCII: {Convert.ToString((char)Nro)}");
            }
        }
    }
}
