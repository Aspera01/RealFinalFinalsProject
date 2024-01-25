using System;
using System.CodeDom.Compiler;
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
        string[] temp = new string[10];
        bool pass = false;
        public void MMenu()
        {
            Console.Write("  _______        _      __  __                                   " +
                "\r\n |__   __|      | |    |  \\/  |                                  " +
                "\r\n    | | __ _ ___| | __ | \\  / | __ _ _ __   __ _  __ _  ___ _ __ " +
                "\r\n    | |/ _` / __| |/ / | |\\/| |/ _` | '_ \\ / _` |/ _` |/ _ \\ '__|" +
                "\r\n   " +
                " | | (_| \\__ \\   <  | |  | | (_| | | | | (_| | (_| |  __/ |   " +
                "\r\n    |_|\\__,_|___/_|\\_\\ |_|  |_|\\__,_|_| |_|\\__,_|\\__, |\\___|_|  " +
                " \r\n    " +
                "                                              __/ |          " +
                "\r\n                                                 |___/                  ");
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
                       "\r\n                                                                  ");
        }
        public void CMenu()
        {           
            Console.Write("  __  __                                   " +
                "\r\n |  \\/  |                                  " +
                "\r\n | \\  / | __ _ _ __   __ _  __ _  ___ _ __ " +
                "\r\n | |\\/| |/ _` | '_ \\ / _` |/ _` |/ _ \\ '__|" +
                "\r\n | |  | | (_| | | | | (_| | (_| |  __/ |   " +
                "\r\n |_|  |_|\\__,_|_| |_|\\__,_|\\__, |\\___|_|   " +
                "\r\n                            __/ |          " +
                "\r\n                           |___/           ");
            temp = rnw.Read(pass);
            int bro = temp[0].Split(',').Length;
            for (int x = 0; x < bro; x++)
            {
                if (temp[x] == null)
                {
                    break;
                }
                Console.Write("\n||");
                for (int y = 0; y < bro-1; y++)
                {
                    Console.Write(temp[x].Split(',')[y]);
                    if (x <= 0)
                    {
                        Console.Write(" | ");
                    }
                    if (x > 0)
                    {
                        Console.Write("|       ");
                    }

                }
                
            }
            Console.WriteLine("\n\nManager is now shown! (Press any key to return)");
            Console.ReadKey();
        }
        public void IM()
        {
            pass = true;
            Console.Write("  _______        _          " +
                "\r\n |__   __|      | |       _ " +
                "\r\n    | | __ _ ___| | _____(_)" +
                "\r\n    | |/ _` / __| |/ / __|  " +
                "\r\n    | | (_| \\__ |   <\\__ \\_ " +
                "\r\n    |_|\\__,_|___|_|\\_|___(_)\r\n                           " +
                "\r\n                            ");
            temp = rnw.Read(pass);
            int bro = temp[0].Split('|').Length;
            for (int x = 0; x < temp.Length; x++)
            {
                if (temp[x] == null)
                {
                    break;
                }
                Console.Write("\n=============================\n");
                for(int y = 0; y < bro; y++)
                {
                    Console.Write(temp[x].Split('|')[y] + " | ");
                }
            }
            Console.WriteLine("\n\nTask Information is now shown! (Press any key to return)");
            Console.ReadKey();
            pass = false;

        }
        public void VMenu()
        {        
            Console.Write(" __      __       _  __       " +
                "\r\n \\ \\    / /      (_)/ _|      " +
                "\r\n  \\ \\  / /__ _ __ _| |_ _   _ " +
                "\r\n   \\ \\/ / _ \\ '__| |  _| | | |" +
                "\r\n    \\  /  __/ |  | | | | |_| |" +
                "\r\n     \\/ \\___|_|  |_|_|  \\__, |" +
                "\r\n                         __/ |" +
                "\r\n                        |___/ ");
            //pass = true;
            temp = rnw.Read(pass);
            int bro = temp[0].Split('|').Length;
            for (int x = 1; x < temp.Length; x++)
            {
                if (temp[x] == null)
                {
                    break;
                }
                if (temp[x].Split(',')[4] != "OPEN")
                {
                    Console.Write("\n====================\n");
                    Console.Write(temp[x].Split(',')[0] + " | " + temp[x].Split(',')[4]);
                }
            }
            Console.Write("\n====================\n");

        }

        public void Comments()
        {
            Console.Write("   _____                                     _       " +
                "\r\n  / ____|                                   | |      " +
                "\r\n | |     ___  _ __ ___  _ __ ___   ___ _ __ | |_ ___ " +
                "\r\n | |    / _ \\| '_ ` _ \\| '_ ` _ \\ / _ | '_ \\| __/ __|" +
                "\r\n | |___| (_) | | | | | | | | | | |  __| | | | |_\\__ \\" +
                "\r\n  \\_____\\___/|_| |_| |_|_| |_| |_|\\___|_| |_|\\__|___/" +
                "\r\n                                                    " +
                "\r\n                                                     ");

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

            Console.Write("\n[1]Create Tasks \n[2]Assign Task \n[3]Check Manager \n[4]Task Information \n[5]Comments \n[6]Verification Page \n[7]End/Close Task \n[0]Exit Task Manager\n");
            try
            {
                choice = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.Clear();
                Console.WriteLine("pls input a proper choice...");
                //Console.ReadKey();
                //wha
                choice = 4125;
            }
            Console.Clear();
            return choice;
        }
    }
}
