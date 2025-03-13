using System;

namespace BetterDecorador
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(Decor(args[0],Convert.ToChar(args[1]),Convert.ToInt32(args[2])));
            
        }
        private static string Decor(string s, char dec, int num)
        {
            string total = "";
            for(int i =0; i<num; i++)
            {
                total+=dec;
            }
            return $"{total} {s} {total}";
        }
    }
}
