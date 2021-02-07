using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace svanTipuricKlaseIObjektiDrugiZad
{
    class Program
    {
        static void Main(string[] args)
        {
            Cetverokut a = new Cetverokut();

            Trokut b = new Trokut();

            a.UcitajStranice();

            b.UcitajStranice();

            Console.ReadKey();
        }
    }
}
