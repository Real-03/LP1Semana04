using System;

namespace BetterDecorador
{
    public class Program
    {
        /// <summary>
        /// Chama um metodo que decora uma string
        /// </summary>
        /// <param name="args">array de strings</param>
        private static void Main(string[] args)
        {
            Console.WriteLine(Decor(args[0],Convert.ToChar(args[1]),Convert.ToInt32(args[2])));
            
        }
        /// <summary>
        /// Decora a string
        /// </summary>
        /// <param name="s">String a decorar</param>
        /// <param name="dec">Simbolo para decorar</param>
        /// <param name="num">Numero de vezes que o simbolo aparece</param>
        /// <returns></returns>
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
