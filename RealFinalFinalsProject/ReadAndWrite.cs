using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OOP_finals__console_
{
    internal class ReadAndWrite
    {
        public void filechecks(string filename)
        {
            if (!File.Exists(filename) && !File.Exists("TaskInformation.txt"))
            {
                Console.WriteLine("Creating necessary files, please wait...");
                using (StreamWriter nw = new StreamWriter(filename))
                {
                    nw.WriteLine("Task, Creation Time, Assigned To, Assigned Time, Task Status, Completion Time");
                }
                using (StreamWriter nw = new StreamWriter("TaskInformation.txt"))
                {                  
                }
                Thread.Sleep(2000);
                Console.Clear();
                Console.WriteLine("Files created! (Press any key)");
                Console.ReadKey();
                Console.Clear();
            }
        }
        public void Write(int choice, string[] ManagerInfo)
        {
            bool pass = false;
            switch (choice)
            {
                //creating task
                case 1:
                    using (StreamWriter sw = new StreamWriter("MasterFile.csv", true))
                    {
                        sw.WriteLine("{0},{1},{2},{3},{4},{5}", ManagerInfo[0], ManagerInfo[1], ManagerInfo[5], ManagerInfo[5], ManagerInfo[4], ManagerInfo[5]);
                    }
                    using (StreamWriter sw = new StreamWriter("TaskInformation.txt",  true))
                    {
                        sw.WriteLine("{0} | {1}", ManagerInfo[0], ManagerInfo[6]);
                    }
                    Console.WriteLine("Creating Task....");
                    Thread.Sleep(2000);
                    Console.Clear();
                    break;
                //assigning task
                case 2:                   
                    string[] dummy = new string[10];
                    string[] newInfo = new string[6];
                    dummy = Read(pass);
                    File.Delete("MasterFile.csv");

                    // 0 - task name
                    // 1 - creation time
                    // 2 - assigned to who
                    // 3 - assigned time
                    // 4 - task status 
                    // 5 - completion time
                    // 6 - task desc
                    // 7 - N/A

                    for (int x = 0; x < dummy.Count(); x++)
                    {
                        if (dummy[x] != null)
                        {
                            if (dummy[x].Split(',')[0] != ManagerInfo[0])
                            {
                                for (int y = 0; y < newInfo.Length; y++)
                                {
                                    newInfo[y] = dummy[x].Split(',')[y];
                                }
                            }
                            if (dummy[x].Split(',')[0] == ManagerInfo[0])
                            {
                                pass = true;
                                for (int y = 0; y < ManagerInfo.Length - 2; y++)
                                {
                                    newInfo[y] = ManagerInfo[y];
                                }
                                using (StreamWriter sw = new StreamWriter("MasterFile.csv", true))
                                {
                                    sw.WriteLine("{0},{1},{2},{3},{4},{5}", newInfo[0], dummy[x].Split(',')[1], newInfo[2], newInfo[3], newInfo[4], newInfo[5]);
                                }
                            }

                            if (x == 0)
                            {
                                using (StreamWriter sw = new StreamWriter("MasterFile.csv", true))
                                {
                                    sw.WriteLine("{0},{1},{2},{3},{4},{5}", newInfo[0], newInfo[1], newInfo[2], newInfo[3], newInfo[4], newInfo[5]);
                                }
                            }
                            else if (x != 0 && pass == false)
                            {
                                using (StreamWriter sw = new StreamWriter("MasterFile.csv", true))
                                {
                                    sw.WriteLine("{0},{1},{2},{3},{4},{5}", newInfo[0], newInfo[1], newInfo[2], newInfo[3], newInfo[4], newInfo[5]);
                                }                             
                            }
                            pass = false;
                        }
                    }
                    Console.Clear();
                    Console.WriteLine("Creating Assignments....");
                    Thread.Sleep(2000);
                    Console.Clear();
                    break;
                //check task manager
                case 3:
                    break;




                //task informations 
                case 4:
                    break;
            }
        }
        public string[] Read(bool pass)
        {
            string[] lines = new string[10];
                     
            if (pass)
            {
                using (StreamReader sr = new StreamReader("TaskInformation.txt"))
                {
                    string line = "";
                    int x = 0;

                    while ((line = sr.ReadLine()) != null)
                    {
                        lines[x] = line;
                        x++;
                    }
                }
            }
            else if (!pass)
            {
                using (StreamReader sr = new StreamReader("MasterFile.csv"))
                {
                    string line = "";
                    int x = 0;

                    while ((line = sr.ReadLine()) != null)
                    {
                        lines[x] = line;                    
                        x++;
                    }

                }
            }
                  
            return lines;
        }       
    }
}