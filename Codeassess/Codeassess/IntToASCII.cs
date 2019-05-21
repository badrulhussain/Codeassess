using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codeassess
{
    class IntToASCII
    {
        static void Main(string[] args)
        {
            string unicode = Console.ReadLine();

            int intUnicode = Convert.ToInt32( unicode);

            var charUnicode = Convert.ToChar(intUnicode);
            if(char.IsUpper(charUnicode))
            {
                Console.WriteLine("upper");
            }
            if (char.IsLower(charUnicode))
            {
                Console.WriteLine("lower");
            }

        }
    }
}
