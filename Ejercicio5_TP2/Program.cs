using System;

namespace Ejercicio5_TP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string entrada;

            do
            {
                // Solicitar al usuario que ingrese un caracter
                Console.WriteLine("Ingrese una letra o número (escriba 'exit' para salir):");
                // Leer la entrada del usuario
                entrada = Console.ReadLine(); // Corregir aquí: quitar la declaración de la variable "string entrada"

                // Verificar si la entrada no es "exit"
                if (entrada != "exit")
                {
                    // Verificar si la entrada tiene solo un caracter
                    if (entrada.Length == 1)
                    {
                        //Comprobar el tipo de caracter
                        switch (entrada)
                        {
                            case "a":
                            case "e":
                            case "i":
                            case "o":
                            case "u":
                                Console.WriteLine("El caracter ingresado es una vocal.");
                                break;
                            case "0":
                            case "1":
                            case "2":
                            case "3":
                            case "4":
                            case "5":
                            case "6":
                            case "7":
                            case "8":
                            case "9":
                                Console.WriteLine("El caracter ingresado es un número.");
                                break;
                            default:
                                Console.WriteLine("El caracter ingresado es una consonante.");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Por favor, ingrese un solo caracter.");
                    }
                }
            } while (entrada != "exit");
        }
    }
}
