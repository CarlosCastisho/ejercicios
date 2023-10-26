namespace ejer1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num1 = {5, 6, 7, 8, 9, 10, 12, 13};
            int[] num2 = { 2, 3, 4, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };

            int num_falta1 = num_arr.num_falta(num1);
            int num_falta2 = num_arr.num_falta(num2);

            Console.WriteLine("El numero que falta de la lista es: {0}", num_falta1);
            Console.WriteLine("El numero que falta de la lista es: {0}", num_falta2);

        }
    }
}