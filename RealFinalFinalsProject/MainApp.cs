﻿using System;
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
                string[] ManagerInfo = new string[9];
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

                    //commentss
                    case 5:
                        infoManager(choice, ManagerInfo);
                        rnw.Write(choice, ManagerInfo);
                        Console.WriteLine("Done! (Press any key to return to menu)");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    //its over retard bros
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
        }

        public string[] infoManager(int choice, string[] ManagerInfo)
        {
            string temp1 = "";
            string temp2 = "";
            bool pass = false;

            string[] temp = new string[rnw.Read(pass).Length];

            DateTime currTime = DateTime.Now;

            // 0 - task name
            // 1 - creation time
            // 2 - assigned to who
            // 3 - assigned time
            // 4 - task status 
            // 5 - completion time
            // 6 - comments
            // 7 - task desc
            // 8 - N/A
          
            for(int w = 0; w < ManagerInfo.Length; w++)
            {
                ManagerInfo[w] = "N/A";
            }
            ManagerInfo[1] = String.Concat(Convert.ToString(currTime.Hour), ':', Convert.ToString(currTime.Minute));

            switch (choice)
            {
                //creating task
                case 1:
                    Console.Write("Please put the name of your task here: ");
                    temp1 = Console.ReadLine();
                    Console.Write("Please write a short/brief description of your task: ");
                    temp2 = Console.ReadLine();
                    ManagerInfo[0] = temp1;
                    ManagerInfo[4] = "Open";
                    ManagerInfo[7] = temp2;
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
                    temp1 = Console.ReadLine();
                    Console.WriteLine("Who is this going to be assigned to?");
                    temp2 = Console.ReadLine();
                    ManagerInfo[0] = temp1;
                    ManagerInfo[2] = temp2;
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
                //comment section
                case 5:
                    pass = true;
                    disp.Comments();
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
                    Console.WriteLine("Choose a task to comment on:");
                    temp1 = Console.ReadLine();
                    Console.WriteLine("Input comment here:");
                    temp2 = Console.ReadLine();
                    ManagerInfo[0] = temp1;
                    ManagerInfo[6] = temp2;
                    pass = false;
                    break;
            }
            //Console.ReadKey();

            return ManagerInfo;
        }
    }
}
