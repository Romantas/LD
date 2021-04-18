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
            FileCreation creation1 = new FileCreation("students10000");
            FileCreation creation2 = new FileCreation("students100000");
            FileCreation creation3 = new FileCreation("students1000000");
            FileCreation creation4 = new FileCreation("students10000000");
            FileCreation performanceTest = new FileCreation("students20000");

            Console.WriteLine("1. Add student\n2. Generate new students\n3. List, Linked, Que performance test\n4. List, Linked, Que performance test two\n5. Exit");
            string choise = Console.ReadLine();

            switch(choise)
            {
                case "1":
                    menu.nuskaitymas();
                    break;
                case "2":
                    creation1.fileGeneration(10000);
                    creation2.fileGeneration(100000);
                    creation3.fileGeneration(1000000);
                    creation4.fileGeneration(10000000);
                    performanceTest.fileGeneration(20000);
                    break;
                case "3":
                    performanceTest.nuskaitymas();
                    performanceTest.separation();
                    break;
                case "4":
                    performanceTest.nuskaitymas();
                    performanceTest.separationTwo();
                    break;
                case "5":
                    Environment.Exit(0);
                    break;
            }

            Main(null);
        }
    }


}
