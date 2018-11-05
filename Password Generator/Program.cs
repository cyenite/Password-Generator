using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Password_Generator
{
    class Program
    {
        static string generatePswd(int length)
        {
            const string validChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            StringBuilder res = new StringBuilder();
            Random rnd= new Random();
            while (0 < length--)
            {
                res.Append(validChars[rnd.Next(validChars.Length)]);
            }

            return res.ToString();
        }
        static void Main(string[] args)
        {
            //password length
            int length = 8;

            string pass = generatePswd(length);
            Console.WriteLine(pass);

            Console.ReadLine();
        }
    }
}