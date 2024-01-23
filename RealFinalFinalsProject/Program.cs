using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OOP_finals__console_
{
    internal class Program
    {
        static void Main(string[] args)
        {          
            Display disp = new Display();
            ReadAndWrite rnw = new ReadAndWrite();
            MainApp MA = new MainApp();

            string filename = "MasterFile.csv";
            int temp = 0;

            disp.MMenu();
            rnw.filechecks(filename);
            temp = disp.choices();

            MA.Start(temp);
            
           

        }
    }
}
