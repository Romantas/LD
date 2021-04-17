using System;
using System.Collections;
using System.Linq;

namespace LD
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            FileCreation creation1 = new FileCreation("students10000", 10000);
            FileCreation creation2 = new FileCreation("students100000", 100000);
            FileCreation creation3 = new FileCreation("students1000000", 1000000);
            FileCreation creation4 = new FileCreation("students10000000", 10000000);
            //menu.nuskaitymas();
        }
    }


}
