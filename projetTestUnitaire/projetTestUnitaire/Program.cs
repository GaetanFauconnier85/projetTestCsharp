using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Diagnostics;
using System.Net;

namespace projetTestUnitaire
{
    class Program
    {
        static void Main(string[] args)
        {
            Catapulte c = new Catapulte();
            c.CommencerManip();
            Console.Read();
        }
    }
}
