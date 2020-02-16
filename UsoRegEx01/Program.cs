using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UsoRegEx01
{
    class Program
    {
        static void Main(string[] args)
        {
            //aprender uso RegEx
            string frase = "Mi nombre es Oscar y mi nº de tfno es (+34)123-45-67 y mi codigo postal es 28029";
            string pattern = @"\+44";

            Regex findPhrase = new Regex(pattern);

            MatchCollection coincidencia= findPhrase.Matches(frase);

            if (coincidencia.Count > 0) Console.WriteLine("se han encontrado numeros");
            else Console.WriteLine("no se han encontrado numeros");

            
        }
    }
}
