using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OOP_finals__console_
{
    internal class Display
    {
        ReadAndWrite rnw = new ReadAndWrite();      
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

        public void TMenu()
        {
            Console.Write("   _____                          _     _______        _          " +
                       "\r\n  / ____|                        | |   |__   __|      | |       _ " +
                       "\r\n | |    _   _ _ __ _ __ ___ _ __ | |_     | | __ _ ___| | _____(_)" +
                       "\r\n | |   | | | | '__| '__/ _ \\ '_ \\| __|    | |/ _` / __| |/ / __|  " +
                       "\r\n | |___| |_| | |  | | |  __/ | | | |_     | | (_| \\__ \\   <\\__ \\_ " +
                       "\r\n  \\_____\\__,_|_|  |_|  \\___|_| |_|\\__|    |_|\\__,_|___/_|\\_\\___(_)" +
                       "\r\n                                                                 " +
                       " \r\n                                                                  ");
        }
        public void CMenu()
        {
            string[] temp = new string[10];
            bool pass = false;

            Console.Write("  __  __                                   " +
                "\r\n |  \\/  |                                  " +
                "\r\n | \\  / | __ _ _ __   __ _  __ _  ___ _ __ " +
                "\r\n | |\\/| |/ _` | '_ \\ / _` |/ _` |/ _ \\ '__|" +
                "\r\n | |  | | (_| | | | | (_| | (_| |  __/ |   " +
                "\r\n |_|  |_|\\__,_|_| |_|\\__,_|\\__, |\\___|_|   " +
                "\r\n                            __/ |          " +
                "\r\n                           |___/           ");
            temp = rnw.Read(pass);
            int length = temp[0].Split(',').Length;
            for (int x = 0; x < length; x++)
            {
                if (temp[x] == null)
                {
                    break;
                }
                Console.Write("\n||");
                for (int y = 0; y < length; y++)
                {
                    Console.Write(temp[x].Split(',')[y] + "  |");
                }
                Console.Write("|");
            }
            Console.WriteLine("\n\nManager is now shown! (Press any key to return)");
            Console.ReadKey();
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

            Console.Write("\n[1]Create Tasks \n[2]Assign Task \n[3]Check Manager \n[4]Task Information \n[0]Exit Task Manager\n");          
            choice = int.Parse(Console.ReadLine());
            Console.Clear();
            return choice;
        }
    }
}
