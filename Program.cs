using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvjeraZnanjaZadatak1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi niz znakova: ");
            string s = Console.ReadLine();
            s = s.Replace(' ','_');
            Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}
