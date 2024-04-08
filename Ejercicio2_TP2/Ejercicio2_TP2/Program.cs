namespace Ejercicio2_TP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ingreso_str = Console.ReadLine();
            int ingreso = Convert.ToInt32(ingreso_str);
            bool primo = true;            

            for (int i=1; i <= ingreso; i++)
            {
                if(i != 1 && i!=ingreso)
                {
                    if (ingreso % i == 0)
                    {
                        primo = false;
                        break;
                    }
                }                
            }

            if (primo) 
            {
                Console.WriteLine($"El número {ingreso} es primo");
            }
            else
            {
                Console.WriteLine($"El número {ingreso} NO es primo");
            }


            Console.ReadKey();
        }
    }
}
