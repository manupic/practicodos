namespace Ejercicio4_tp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora");
            Console.WriteLine(" 1 - Sumar");
            Console.WriteLine(" 2 - Restar");
            Console.WriteLine(" 3 - Multiplicar");
            Console.WriteLine(" 4 - Dividir");
            Console.WriteLine(" 5 - Factorial");
            Console.WriteLine(" 6 - Residuo");
            Console.WriteLine(" 7 - Conversion a Binario");
            Console.WriteLine(" 8 - Raiz cuadrada");
            Console.WriteLine(" 9 - Potencia");
            Console.WriteLine(" 10 - Coseno");
            Console.WriteLine(" 11 - Seno");
            Console.WriteLine(" 12 - Valor absoluto");
            Console.WriteLine(" 13 - Redondeo");
            Console.WriteLine(" 14 - Nro maximo");
            Console.WriteLine(" 15 - Nro minimo");

            string entrada_str = Console.ReadLine();
            int entrada = Convert.ToInt32(entrada_str);
            string str_nro_a;
            string str_nro_b;
            int nro_a, nro_b;
            int resultado = 1;

            switch (entrada)
            {                
                case 1:
                    Console.WriteLine("Ingrese el nro a sumar: ");
                    str_nro_a = Console.ReadLine();
                    Console.WriteLine("Ingrese el otro nro : ");
                    str_nro_b = Console.ReadLine();
                    nro_a = Convert.ToInt32(str_nro_a);
                    nro_b = Convert.ToInt32(str_nro_b);                           
                    Console.WriteLine($"El resultado es {nro_a + nro_b}");

                    break;
                case 2:
                    Console.WriteLine("Ingrese el nro: ");
                    str_nro_a = Console.ReadLine();
                    Console.WriteLine("Ingrese el nro a restar: ");
                    str_nro_b = Console.ReadLine();
                    nro_a = Convert.ToInt32(str_nro_a);
                    nro_b = Convert.ToInt32(str_nro_b);
                    Console.WriteLine($"El resultado es {nro_a - nro_b}");

                    break;
                case 3:
                    Console.WriteLine("Ingrese el nro: ");
                    str_nro_a = Console.ReadLine();
                    Console.WriteLine("Ingrese el nro a multiplicar: ");
                    str_nro_b = Console.ReadLine();
                    nro_a = Convert.ToInt32(str_nro_a);
                    nro_b = Convert.ToInt32(str_nro_b);
                    Console.WriteLine($"El resultado es {nro_a * nro_b}");

                    break;

                case 4:
                    Console.WriteLine("Ingrese el dividendo: ");
                    str_nro_a = Console.ReadLine();
                    Console.WriteLine("Ingrese el divisor: ");
                    str_nro_b = Console.ReadLine();
                    nro_a = Convert.ToInt32(str_nro_a);
                    nro_b = Convert.ToInt32(str_nro_b);
                    Console.WriteLine($"El resultado es {nro_a / nro_b}"); ;
                    break;

                case 5:
                    Console.WriteLine("Ingrese el nro: ");
                    str_nro_a = Console.ReadLine();                    
                    nro_a = Convert.ToInt32(str_nro_a);
                    
                    for (int i = 1; i <= nro_a; i++) 
                    {                        
                        resultado *= i;
                    }

                    Console.WriteLine($"El factorial de {nro_a} es: {resultado}");

                    break;

                case 6:
                    Console.WriteLine("Ingrese el dividendo: ");
                    str_nro_a = Console.ReadLine();
                    Console.WriteLine("Ingrese el divisor: ");
                    str_nro_b = Console.ReadLine();
                    nro_a = Convert.ToInt32(str_nro_a);
                    nro_b = Convert.ToInt32(str_nro_b);
                    Console.WriteLine($"El resultado es {nro_a % nro_b}"); ;
                    
                    break;

                case 7:
                    Console.WriteLine("Ingrese el nro a convertir a binario: ");
                    str_nro_a = Console.ReadLine();
                    nro_a = Convert.ToInt32(str_nro_a);

                    string binario = Convert.ToString(nro_a, 2);

                    Console.WriteLine(binario);                                        

                    break;

                case 8:
                    Console.WriteLine("Ingrese el nro: ");
                    str_nro_a = Console.ReadLine();
                    nro_a = Convert.ToInt32(str_nro_a);                                        

                    Console.WriteLine($"El resultado de la raìz cuadrada es: {Math.Sqrt(nro_a)}");                    

                    break;
                case 9:
                    Console.WriteLine("Ingrese el nro: ");
                    str_nro_a = Console.ReadLine();
                    Console.WriteLine("Ingrese el otro nro: ");
                    str_nro_b = Console.ReadLine();
                    nro_a = Convert.ToInt32(str_nro_a);
                    nro_b = Convert.ToInt32(str_nro_b);

                    Console.WriteLine($"El nro {nro_a} elevado {nro_b} a la da como resultado es: {Math.Pow(nro_a, nro_b)}");

                    break;
                case 10:
                    Console.WriteLine("Ingrese el nro: ");
                    str_nro_a = Console.ReadLine();
                    nro_a = Convert.ToInt32(str_nro_a);

                    Console.WriteLine($"El coseno de {nro_a} es: {Math.Cos(nro_a)}");

                    break;
                case 11:
                    Console.WriteLine("Ingrese el nro: ");
                    str_nro_a = Console.ReadLine();
                    nro_a = Convert.ToInt32(str_nro_a);

                    Console.WriteLine($"El seno de {nro_a} es: {Math.Sin(nro_a)}");
                    break;
                case 12:
                    Console.WriteLine("Ingrese el nro: ");
                    str_nro_a = Console.ReadLine();
                    nro_a = Convert.ToInt32(str_nro_a);

                    Console.WriteLine($"El valor absoluto de {nro_a} es: {Math.Abs(nro_a)}");

                    break;
                case 13:
                    Console.WriteLine("Ingrese el nro: ");
                    str_nro_a = Console.ReadLine();
                    double db_nro_a = Convert.ToDouble(str_nro_a);
                    Console.WriteLine($"El redondeo de {db_nro_a} es: {Math.Round(db_nro_a)}");
                    break;
                case 14:                
                    Console.WriteLine("Ingrese el nro: ");
                    str_nro_a = Console.ReadLine();
                    Console.WriteLine("Ingrese el otro nro: ");
                    str_nro_b = Console.ReadLine();

                    nro_a = Convert.ToInt32(str_nro_a);
                    nro_b = Convert.ToInt32(str_nro_b);

                    Console.WriteLine($"El nro max es: {Math.Max(nro_a, nro_b)}");
                    break;

                case 15:
                    Console.WriteLine("Ingrese el nro: ");
                    str_nro_a = Console.ReadLine();
                    Console.WriteLine("Ingrese el otro nro: ");
                    str_nro_b = Console.ReadLine();

                    nro_a = Convert.ToInt32(str_nro_a);
                    nro_b = Convert.ToInt32(str_nro_b);

                    Console.WriteLine($"El nro minimo es: {Math.Min(nro_a, nro_b)}");
                    break;


            }            

        }
    }
}
