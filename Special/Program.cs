using System;

namespace Special
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int number =0;
            Console.Write("Insert n-th number of the special sequence: ");
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(GetSpecial(number));



        }
        private static int GetSpecial(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;

            // Chamada recursiva conforme a fórmula
            return GetSpecial(n - 1) + 2 * GetSpecial(n - 2);
        }
    }
}
