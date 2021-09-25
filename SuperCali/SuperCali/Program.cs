using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperCali
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Print Supercalifragilisticexpialidocious");
            // String of authors  
            string word = "supercalifragilisticexpialidocious";
            char[] charArray = word.ToCharArray();
            foreach (char letter in charArray)
            {
                Console.WriteLine(letter);
            }
            foreach (char letter in charArray)
            {
                if (letter != 'i')
                {
                    Console.WriteLine("Not an i");
                }
                else
                {
                    Console.WriteLine(letter);
                }
            }
          

            Console.ReadLine();
        }
    }
}
