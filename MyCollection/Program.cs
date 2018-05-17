using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula10
{
    class Program
    {
        static void Main(string[] args)
        {
            Guarda<string> g3s = new Guarda3<string>();
            Guarda<float> g3f = new Guarda3<float>();

            g3s SetItem (1, "Ola");
            g3s SetItem (2, "Adeus");
            g3s SetItem (3, "La La");

            g3s SetItem(1, 2.3f);
            g3s SetItem(2, 5.7f);
            g3s SetItem(3, -4);

            Console.WriteLine("g3s, GetItem(1)");
        }
    }
}
