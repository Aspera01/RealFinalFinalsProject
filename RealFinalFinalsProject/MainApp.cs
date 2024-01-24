using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OOP_finals__console_
{
    internal class MainApp
    {
        Display disp = new Display();
        ReadAndWrite rnw = new ReadAndWrite();
        bool pass = false;
        public void Start(int choice)
        {
            while (choice != 0)
            {            
                string[] ManagerInfo = new string[8];
                //bool whatthefuck = false;

                switch (choice)
                {
                    //creating task
                    case 1:
                        infoManager(choice, ManagerInfo);
                        rnw.Write(choice, ManagerInfo);
                        Console.WriteLine("Done! (Press any key to return to menu)");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    //assigning task
                    case 2:
                        infoManager(choice, ManagerInfo);
                        rnw.Write(choice, ManagerInfo);
                        Console.WriteLine("Done! (Press any key to return to menu)");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    //check task manager
                    case 3:
                        disp.CMenu();
                        Console.Clear();
                        break;

                    //task information
                    case 4:
                        disp.IM();
                        Console.Clear();
                        break;

                    //comments
                    case 5:
                        Console.Clear();
                        break;
                    default:
                        choice = 1;
                        Console.WriteLine("pls input a proper choice...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
                if(choice != 0)
                {                  
                    choice = disp.choices();
                }
                
            }
            Console.WriteLine("Thanks for using!");
            Console.ReadKey();
            Console.Clear();

        }

        //public void assignTask()
        //{

        //}

        //public void something()
        //{

        //}

        public string[] infoManager(int choice, string[] ManagerInfo)
        {                     
            string TaskName = "";
            string TaskDesc = "";
            string Assigned = "";
            string TaskStatus = "";   
            bool pass = false;

            string[] temp = new string[rnw.Read(pass).Length];

            DateTime currTime = DateTime.Now;

            // 0 - task name
            // 1 - creation time
            // 2 - assigned to who
            // 3 - assigned time
            // 4 - task status 
            // 5 - completion time
            // 6 - task desc
            // 7 - N/A

            ManagerInfo[1] = String.Concat(Convert.ToString(currTime.Hour),':', Convert.ToString(currTime.Minute));
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
                    pass = true;
                    disp.TMenu();
                    temp = rnw.Read(pass);
                    for (int x = 0; x < temp.Length; x++)
                    {
                        if (temp[x] == null)
                        {
                            break;
                        }
                        Console.WriteLine("\n" + temp[x].Split('|')[0]);

                    }
                    Console.WriteLine("==========");
                    Console.WriteLine("Please choose a task:");
                    TaskName = Console.ReadLine();
                    Console.WriteLine("Who is this going to be assigned to?");
                    Assigned = Console.ReadLine();
                    ManagerInfo[0] = TaskName;
                    ManagerInfo[2] = Assigned;
                    ManagerInfo[3] = ManagerInfo[1];
                    ManagerInfo[4] = "Assigned";
                    pass = false;
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
