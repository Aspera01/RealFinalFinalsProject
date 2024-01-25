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
                string[] ManagerInfo = new string[11];

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
                    //verification
                    case 6:
                        infoManager(choice, ManagerInfo);
                        rnw.Write(choice, ManagerInfo);
                        Console.WriteLine("Done! (Press any key to return to menu)");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 7:
                        infoManager(choice, ManagerInfo);
                        rnw.Write(choice, ManagerInfo);
                        Console.WriteLine("Done! (Press any key to return to menu)");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    //its over retard bros
                    default:
                        choice = 1;
                        Console.WriteLine("pls input correctly..."); 
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
            bool pass = false;

            string[] temp = new string[rnw.Read(pass).Length];
            string[] temp2 = new string[9];

            DateTime currTime = DateTime.Now;

            // 0 - task name
            // 1 - creation time
            // 2 - assigned to who
            // 3 - assigned time
            // 4 - task status 
            // 5 - completion time
            // 6 - comments
            // 7 - verification
            // 8 - task desc
            // 9 - verifying time
            // 10 - N/A
          
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
                    ManagerInfo[0] = Console.ReadLine().ToUpper();
                    Console.Write("Please write a short/brief description of your task: ");
                    ManagerInfo[8] = Console.ReadLine();
                    ManagerInfo[4] = "OPEN";
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
                    ManagerInfo[0] = Console.ReadLine().ToUpper();
                    Console.WriteLine("Who is this going to be assigned to?");
                    ManagerInfo[2] = Console.ReadLine().ToUpper();
                    ManagerInfo[3] = ManagerInfo[1];
                    ManagerInfo[4] = "ASSIGNED";
                    pass = false;
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
                    ManagerInfo[0] = Console.ReadLine().ToUpper();
                    Console.WriteLine("Input comment here:");
                    ManagerInfo[6] = Console.ReadLine();
                    pass = false;
                    break;
                case 6:
                    disp.VMenu();
                    Console.WriteLine("\n\nPick a task you'd like to verify: ");
                    ManagerInfo[0] = Console.ReadLine().ToUpper();
                    ManagerInfo[9] = ManagerInfo[1];
                    temp = rnw.Read(pass);
                    for(int i = 0; i < temp.Length;i++)
                    {
                        if (temp[i] != null)
                        {
                            for (int j = 0; j < temp2.Length; j++)
                            {
                                temp2[j] = temp[i].Split(',')[j];
                            }
                            if (temp2[0] == ManagerInfo[0])
                            {
                                if (temp2[4] == "ASSIGNED" || temp2[4] == "OPEN")
                                {
                                    ManagerInfo[7] = "NO";
                                    break;
                                }
                                else if (temp2[4] == "FOR VERIFICATION")
                                {
                                    ManagerInfo[7] = "FOR VERIFICATION";
                                    break;
                                }
                                else if (temp2[4] == "CLOSED")
                                {
                                    ManagerInfo[7] = "VERIFIED";
                                    break;
                                }
                                //}
                            }
                        }
                            
                    }

                    break;

                case 7:
                    disp.TMenu();
                    temp = rnw.Read(pass);
                    ManagerInfo[0]
                    int bro = temp[0].Split('|').Length;
                    for (int x = 0; x < temp.Length; x++)
                    {
                        if (temp[x] == null)
                        {
                            break;
                        }
                        Console.Write("\n=============================\n");
                        //for (int y = 0; y < bro; y++)
                        //{
                        Console.Write(temp[x].Split(',')[0] + " | ");
                        Console.Write(temp[x].Split(',')[4] + " | ");
                        //}
                    }
                    Console.WriteLine("\n\nPick a task to end/close");
                    ManagerInfo[0] = Console.ReadLine().ToUpper();
                    Console.WriteLine("Do you want to end/close this task?");
                    ManagerInfo[4] = Console.ReadLine().ToUpper();
                    if (ManagerInfo[4] == "END")
                        ManagerInfo[4] = "FOR VERIFICATION";
                    else if (ManagerInfo[4] == "CLOSE")
                    {
                        ManagerInfo[4] = "CLOSED";
                    }
                    break;
                                         
            }
            //Console.ReadKey();

            return ManagerInfo;
        }
    }
}
