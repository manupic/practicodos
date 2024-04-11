using System;

namespace Ejercicio8_TP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int CantidadH = 0, CantidadP = 0, CantidadB = 0;
            double precioH, precioP, precioB;
            double Resultado = 0;
            //string linea;


            // Se solicita al usuario que ingrese la cantidad de hamburguesas y su precio
            do
            {
                Console.WriteLine("Cantidad de hamburguesas: ");
                CantidadH = Convert.ToInt32(Console.ReadLine());
                // Si la cantidad es -1 sale del bucle
                if(CantidadH == -1)
                    break;
                Console.WriteLine("Precio: ");
                precioH = Convert.ToDouble(Console.ReadLine());
                // Se calcula el total de la venta y se almacena en la variable resultado
                Resultado += CantidadH * precioH;
                Console.WriteLine("Subtotal: $" + String.Format("{0:g}", Resultado));

            } while (CantidadH != -1);

            // Se solicita al usuario que ingrese la cantidad de papas y su precio
            do
            {
                Console.WriteLine("Cantidad de papas: ");
                CantidadP = Convert.ToInt32(Console.ReadLine());
                // Si la cantidad es -1 sale del bucle
                if (CantidadP == -1)
                    break;
                Console.WriteLine("Precio: ");
                precioP = Convert.ToDouble(Console.ReadLine());
                // Se calcula el total de la venta y se suma a la variable resultado
                Resultado += CantidadP * precioP;
                Console.WriteLine("Subtotal: $" + String.Format("{0:g}", Resultado));

            } while (CantidadP != -1);

            // Se solicita al usuario que ingrese la cantidad de bebidas y su precio
            do
            {
                Console.WriteLine("Cantidad de bebidas: ");
                CantidadB = Convert.ToInt32(Console.ReadLine());
                // Si la cantidad es -1 sale del bucle
                if (CantidadB == -1)
                    break;
                Console.WriteLine("Precio: ");
                precioB = Convert.ToDouble(Console.ReadLine());
                // Se calcula el total de la venta y se suma a la variable resultado
                Resultado += CantidadB * precioB;
                Console.WriteLine("Subtotal: $" + String.Format("{0:g}", Resultado));

            } while (CantidadB != -1);

            // Se imprime los resultados
            Console.WriteLine("\n### TOTAL DEL TICKET ###");

            // Imprime el total como un número entero, rellenando con ceros a la izquierda si es necesario hasta el 5° caracter
            Console.WriteLine("Total seteado con 5 caracteres:" + String.Format("{0:00000}", (int)Resultado));

            // Imprime el total con 5 enteros y dos decimales
            Console.WriteLine("Total de hasta 5 enteros y 2 decimales: " + String.Format("{0:#####.00}", Resultado));

            // Imprime el total en formato moneda
            Console.WriteLine("Total como moneda: " + String.Format("{0:c}", Resultado));

            // Imprime solo los caracteres enteros del número
            Console.WriteLine("Total (solo valor entero): " + String.Format("{0:g}", Resultado));

            // Imprime la fecha y hora completa
            Console.WriteLine("Fecha y hora completa: " + String.Format("{0:F}", DateTime.Now));

            // Imprime el nombre del día de la semana y la fecha en formato día/mes/año
            Console.WriteLine("Dia de la semana dia/mes/año: " + String.Format("{0:dddd, dd/MM/yyyy}", DateTime.Now));

        }
    }
}
