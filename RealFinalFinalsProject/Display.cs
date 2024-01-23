using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OOP_finals__console_
{
    internal class Display
    {
        public void MMenu()
        {
            Console.Write("  _______        _      __  __                                   \r\n |__   __|      | |    |  \\/  |                                  " +
                "\r\n    | | __ _ ___| | __ | \\  / | __ _ _ __   __ _  __ _  ___ _ __ \r\n    | |/ _` / __| |/ / | |\\/| |/ _` | '_ \\ / _` |/ _` |/ _ \\ '__|\r\n   " +
                " | | (_| \\__ \\   <  | |  | | (_| | | | | (_| | (_| |  __/ |   \r\n    |_|\\__,_|___/_|\\_\\ |_|  |_|\\__,_|_| |_|\\__,_|\\__, |\\___|_|   \r\n    " +
                "                                              __/ |          \r\n                                                 |___/                  ");
            Console.WriteLine("\n =Press any key to Start=");
            Console.ReadKey();
            Console.Clear();
        }

        public int choices()
        {
            int choice = 0;
            Console.Write("  __  __       _         __  __                 " +
                " \r\n |  \\/  |     (_)       |  \\/  |                 " +
                "\r\n | \\  / | __ _ _ _ __   | \\  / | ___ _ __  _   _ " +
                "\r\n | |\\/| |/ _` | | '_ \\  | |\\/| |/ _ \\ '_ \\| | | |" +
                "\r\n | |  | | (_| | | | | | | |  | |  __/ | | | |_| |" +
                "\r\n |_|  |_|\\__,_|_|_| |_| |_|  |_|\\___|_| |_|\\__,_|" +
                "\r\n                                                 ");

            Console.Write("\n[1]Create Tasks \n[2]Assign Task \n[3]Check Manager \n[4]Task Information \n");          
            choice = int.Parse(Console.ReadLine());
            Console.Clear();
            return choice;
        }
    }
}
