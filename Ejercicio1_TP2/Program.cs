namespace Ejercicio1_TP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Solicitar al usuario que ingrese un número
            Console.WriteLine("Ingrese un número:");
            // Leer la entrada del usuario y guardarla como una cadena
            string numeroStr = Console.ReadLine();

            // Verificar si la entrada es un número válido
            if (EsNumero(numeroStr))
            {
                // Si es válido, invertir el número y mostrar el resultado
                string numeroInvertido = InvertirNumero(numeroStr);
                Console.WriteLine($"El número invertido es: {numeroInvertido}");
            }
            else
            {
                // Si no es válido, mostrar un mensaje de error
                Console.WriteLine("Por favor ingrese un número válido.");
            }
        }

        // Función para verificar si una cadena contiene solo dígitos
        static bool EsNumero(string str)
        {
            foreach (char c in str)
            {
                // Verificar si cada caracter de la cadena es un dígito
                if (!Char.IsDigit(c))
                    return false;
            }
            // Si todos los caracteres son dígitos, devolver verdadero
            return true;
        }

        // Función para invertir una cadena
        static string InvertirNumero(string numero)
        {
            // Convertir la cadena en un arreglo de caracteres
            char[] numeroArray = numero.ToCharArray();
            // Invertir el arreglo de caracteres
            Array.Reverse(numeroArray);
            // Crear una nueva cadena a partir del arreglo invertido y devolverla
            return new string(numeroArray);
        }
    }
}