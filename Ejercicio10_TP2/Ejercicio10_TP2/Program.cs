namespace Ejercicio10_TP2
{
    internal class Program
    {
        public static string Left(string param, int length)
        {
            string result = param.Substring(0, length);
            return result;
        }

        public static string Right(string param, int length)
        {
            int value = param.Length - length;
            string result = param.Substring(value, length);
            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su nombre: ");
            string ingreso = Console.ReadLine();
            string ingreso_secondary;
            byte k;
            
            Console.WriteLine($"Su longitud es {ingreso.Length}");

            Console.WriteLine("Ingrese el texto para saber si lo contiene");
            ingreso_secondary = Console.ReadLine();

            Console.WriteLine($"¿Lo contiene? {ingreso.Contains(ingreso_secondary)}");

            Console.WriteLine($"El nombre en minusculas es: {ingreso.ToLower()}");
            Console.WriteLine($"El nombre en mayusculas es: {ingreso.ToUpper()}");

            Console.WriteLine("Ingrese la cantidad de letras que desesa mantener");            
            
            Console.WriteLine($"Remover 4 letras: {ingreso.Remove(4)}");                               
            
            string resultado_str = ingreso.Substring(0, 4);
            Console.WriteLine($"Extraer 4 letras: {resultado_str}");                                                           

            for (int i=0; i <= ingreso.Length; i++) {
                Console.WriteLine(ingreso.Substring(0, i));
            }

            for (int j = ingreso.Length; j >= 0; j--)
            {                
                Console.WriteLine(ingreso.Substring(j));
            }

            Console.WriteLine($"Izquierda 4 letras {Left(ingreso, 4)}");

            Console.WriteLine($"Derecha 4 letras {Right(ingreso, 4)}" );

        }
    }
}
