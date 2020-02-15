using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsoRegEx01
{
    class Program
    {
        static void Main(string[] args)
        {
            //aprender uso RegEx
            string frase = "Mi nombre es Oscar y mi nº de tfno es (+34)123-45-67 y mi cOdigo postal es 28029";
            int count = 0;
            foreach(char i in frase)
            {
                if (i == 'O')
                {
                    
                    count++;
                }

            }
            if (count != 0)
            {
                Console.WriteLine("la cadena tiene O y el contador es {0}", count);
            }
                
            else Console.WriteLine("no hay O mayuscula");

        }
    }
}
