using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimaleHouseModel
{
    class Program
    {
        static void Main(string[] args)
        {
            AutomatikProductUpdate auto = new AutomatikProductUpdate();
            auto.CheckForFiles();
            Console.ReadKey();


        }
    }
}
