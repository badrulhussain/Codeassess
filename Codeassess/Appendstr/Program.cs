using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appendstr
{
    class Program
    {
        static void Main(string[] args)
        {
            var output = Appendstr("Hi all! How are you? We have aclass right now so open your books quickly.");
            Console.WriteLine(output);
        }

        public static string Appendstr(string input)
        {
            string output = null;
            int stringLength = input.Length;
            if(stringLength >= 10)
            {
                output = input.Substring(0, 10) + "....";
            }
            else
            {
                return input;
            }
            return output;
        }
    }
}
