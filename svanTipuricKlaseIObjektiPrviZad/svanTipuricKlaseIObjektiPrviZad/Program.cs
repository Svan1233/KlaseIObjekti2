using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace svanTipuricKlaseIObjektiPrviZad
{
    class Program
    {
        static void Main(string[] args)
        {
            Bjelogoricno Hrast = new Bjelogoricno(true);
            Crnogoricno Bor = new Crnogoricno(false);

            Console.WriteLine("Hrast: " + Hrast.OpadajuListovi());
            Console.WriteLine("Bor: " + Bor.OpadajuListovi());
            Console.ReadKey();
        }
    }
}
