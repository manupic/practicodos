namespace Ejercicio3_TP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Solicitar al usuario que ingrese un número
            Console.WriteLine("Ingrese un número:");
            // Leer la entrada del usuario y convertirla a entero
            string numeroStr = Console.ReadLine();

            // Verificar si la entrada es un número válido
            if (EsNumero(numeroStr))
            {
                int numero = Convert.ToInt32(numeroStr);
                // Verificar si el número es un número de Armstrong y mostrar el resultado
                Console.WriteLine(EsNumeroArmstrong(numero) ? $"{numero} es un número de Armstrong." : $"{numero} no es un número de Armstrong.");
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

        // Función para verificar si un número es un número de Armstrong
        static bool EsNumeroArmstrong(int numero)
        {
            string numeroStr = numero.ToString();
            int longitud = numeroStr.Length;
            int suma = 0;

            foreach (char c in numeroStr)
            {
                int digito = c - '0'; // Convertir el carácter en un dígito
                suma += (int)Math.Pow(digito, longitud); // Sumar la potencia del dígito
            }
            // Si suma == numero, devolver verdadero
            return suma == numero;
        }
    }
}