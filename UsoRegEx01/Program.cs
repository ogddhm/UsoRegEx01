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
            string frase = "Mi web es http://pildorasinformaticas.es";
            string pattern = "https?://(www.)?pildorasinformaticas.es";

            Regex findPhrase = new Regex(pattern);

            MatchCollection coincidencia= findPhrase.Matches(frase);

            if (coincidencia.Count > 0) Console.WriteLine("se han encontrado web");
            else Console.WriteLine("no se han encontrado web");

            
        }
    }
}
