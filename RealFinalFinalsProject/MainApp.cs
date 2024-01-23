using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OOP_finals__console_
{
    internal class MainApp
    {

        public void Start(int choice)
        {
            Display disp = new Display();
            ReadAndWrite rnw = new ReadAndWrite();

            string[] ManagerInfo = new string[7];
            //bool didsomething = false;

            switch (choice)
            {
                //creating task
                case 1:
                    infoManager(choice, ManagerInfo);
                    rnw.Write(choice, ManagerInfo);
                    break;
                //assigning task
                case 2:
                    infoManager(choice, ManagerInfo);
                    Console.Clear();
                    break;
                //check task manager
                case 3:
                    Console.Clear();
                    break;
                //task informations 
                case 4:
                    Console.Clear();
                    break;
            }          
            Console.WriteLine("Done! (Press any key to return to menu)");
            Console.ReadKey();
            Console.Clear();
            disp.choices();
        }

        //public void assignTask()
        //{

        //}

        //public void something()
        //{

        //}

        public string[] infoManager(int choice, string[] ManagerInfo)
        {
            ReadAndWrite rnw = new ReadAndWrite();

            string TaskName = "";
            string TaskDesc = "";
            string Assigned = "";
            string TaskStatus = "";
            List<String> temp = new List<String>();

            DateTime currTime = DateTime.Now;

            // 0 - task name
            // 1 - hrs
            // 2 - min
            // 3 - Assigned to who
            // 4 - task status 
            // 5 - default N/A
            // 6 - task desc

            ManagerInfo[1] = Convert.ToString(currTime.Hour);
            ManagerInfo[2] = Convert.ToString(currTime.Minute);
            ManagerInfo[5] = "N/A";

            switch (choice)
            {
                //creating task
                case 1:
                    Console.Write("Please put the name of your task here: ");
                    TaskName = Console.ReadLine();
                    Console.Write("Please write a short/brief description of your task: ");
                    TaskDesc = Console.ReadLine();
                    ManagerInfo[0] = TaskName;
                    ManagerInfo[4] = "Open";
                    ManagerInfo[6] = TaskDesc;
                    break;
                //assigning task
                case 2:
                    Console.Write("   _____                          _     _______        _          " +
                        "\r\n  / ____|                        | |   |__   __|      | |       _ " +
                        "\r\n | |    _   _ _ __ _ __ ___ _ __ | |_     | | __ _ ___| | _____(_)" +
                        "\r\n | |   | | | | '__| '__/ _ \\ '_ \\| __|    | |/ _` / __| |/ / __|  " +
                        "\r\n | |___| |_| | |  | | |  __/ | | | |_     | | (_| \\__ \\   <\\__ \\_ " +
                        "\r\n  \\_____\\__,_|_|  |_|  \\___|_| |_|\\__|    |_|\\__,_|___/_|\\_\\___(_)" +
                        "\r\n                                                                 " +
                        " \r\n                                                                  ");
                    for (int x = 0; x < rnw.Read().Length; x++)
                    {
                        if (rnw.Read()[x] == null)
                        {
                            break;
                        }
                        Console.WriteLine("\n" + rnw.Read()[x].Split('|')[0]);

                    }
                    Console.WriteLine("==========");
                    Console.WriteLine("Please choose a task:");
                    TaskName = Console.ReadLine();
                    Console.WriteLine("Who is this going to be assigned to?");
                    Assigned = Console.ReadLine();
                    Console.Clear();
                    break;
                //check task manager
                case 3:

                    break;
                //task informations 
                case 4:

                    break;
            }
            //Console.ReadKey();

            return ManagerInfo;
        }
    }
}
