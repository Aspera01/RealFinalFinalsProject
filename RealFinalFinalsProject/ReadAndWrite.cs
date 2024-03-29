﻿using System;
using System.CodeDom;
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
        bool pass = false;
        bool stop = false;
        public void filechecks(string filename)
        {
            if (!File.Exists(filename) && !File.Exists("TaskInformation.txt"))
            {
                Console.WriteLine("Creating necessary files, please wait...");
                using (StreamWriter nw = new StreamWriter(filename))
                {
                    nw.WriteLine("Task, Creation T., Assigned To, Assigned T., Task Status, Completion T., Comments, Verification, Verification T.");
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
        public bool checker(bool stop, int knower, string[] ManagerInfo)
        {
            string[] temp = new string[9];
            string[] holder = new string[9];
            temp = Read(pass);
            for(int xx = 0; xx < temp.Length; xx++)
            {
                if (temp[xx] != null)
                {
                    for (int yy = 0; yy < ManagerInfo.Length-2; yy++)
                    {                       
                        holder[yy] = temp[xx].Split(',')[yy];
                    }
                    if (holder[0] == ManagerInfo[0])
                        break;
                }
            }

            switch (knower)
            {
                case 2:
                    if (holder[2] != "N/A")
                        return true;
                    break;
                case 6:
                    if (ManagerInfo[7] == "NO")
                        return true;
                    break;
                case 7:
                    if (holder[4] == "OPEN")
                        return true;
                    break;

            }
            return false;
        }
        public void Write(int choice, string[] ManagerInfo)
        {           
            int knower = 0;
            if (choice > 1)
            {
                knower = choice;
                choice = 2;
            }
            switch (choice)
            {               
                //creating task
                case 1:
                    using (StreamWriter sw = new StreamWriter("MasterFile.csv", true))
                    {
                        sw.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7},{8}", ManagerInfo[0], ManagerInfo[1], ManagerInfo[2], ManagerInfo[3], ManagerInfo[4], ManagerInfo[5], ManagerInfo[6], ManagerInfo[7], ManagerInfo[9]);
                    }
                    using (StreamWriter sw = new StreamWriter("TaskInformation.txt",  true))
                    {
                        sw.WriteLine("{0} | {1}", ManagerInfo[0], ManagerInfo[8]);
                    }
                    Console.WriteLine("Creating Task....");
                    Thread.Sleep(2000);
                    Console.Clear();
                    break;
                //other tasks
                case 2:
                    stop = checker(stop, knower, ManagerInfo);
                    if (stop)
                    {                       
                        break;
                    }
                    string[] dummy = new string[10];
                    string[] newInfo = new string[9];
                    string[] tempInfo = new string[9];
                    dummy = Read(pass);
                    File.Delete("MasterFile.csv");

                    for (int x = 0; x < dummy.Count(); x++)
                    {   
                        if (dummy[x] != null)
                        {
                            for (int w = 0; w < tempInfo.Length; w++)
                            {
                                tempInfo[w] = dummy[x].Split(',')[w];
                            }

                            if (tempInfo[0] != ManagerInfo[0])
                            {
                                for (int y = 0; y < newInfo.Length; y++)
                                {
                                    newInfo[y] = tempInfo[y];
                                }
                            }
                            if (tempInfo[0] == ManagerInfo[0])
                            {                              
                                pass = true;
                                specWrite(tempInfo, ManagerInfo, newInfo, knower, stop);
                            }                       
                            if (x == 0)
                            {
                                using (StreamWriter sw = new StreamWriter("MasterFile.csv", true))
                                {
                                    sw.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7},{8}", newInfo[0], newInfo[1], newInfo[2], newInfo[3], newInfo[4], newInfo[5], newInfo[6], newInfo[7], newInfo[8]);
                                }
                            }
                            else if (x != 0 && pass == false)
                            {
                                using (StreamWriter sw = new StreamWriter("MasterFile.csv", true))
                                {
                                    sw.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7},{8}", newInfo[0], newInfo[1], newInfo[2], newInfo[3], newInfo[4], newInfo[5], newInfo[6], newInfo[7], newInfo[8]);
                                }                             
                            }
                            pass = false;
                        }
                    }                   
                    break;                 
                //check task manager
                case 3:
                    break;
            }
            if (stop)
            {
                switch (knower)
                {
                    case 2:
                        Console.Clear();
                        Console.WriteLine("That task is already assigned!");
                        Console.ReadKey();
                        Console.Clear();
                        stop = false;
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("End/Assign the task first!");
                        Console.ReadKey();
                        Console.Clear();
                        stop = false;
                        break;
                    case 7:
                        Console.Clear();
                        Console.WriteLine("End/Assign the task first!");
                        Console.ReadKey();
                        Console.Clear();
                        stop = false;
                        break;
                }

                
            }
        }

        public bool specWrite(string[] tempInfo, string[] ManagerInfo, string[] newInfo, int knower, bool stop)
        {
            for (int y = 0; y < ManagerInfo.Length - 2; y++)
            {
                newInfo[y] = ManagerInfo[y];
            }
            switch (knower)
            {
                case 2:                 
                    using (StreamWriter sw = new StreamWriter("MasterFile.csv", true))
                    {
                        sw.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7},{8}", newInfo[0], tempInfo[1], newInfo[2], newInfo[3], newInfo[4], newInfo[5], newInfo[6], newInfo[7], newInfo[8]);
                        Console.Clear();
                        Console.WriteLine("Creating Assignments....");
                        Thread.Sleep(2000);
                        Console.Clear();
                    }
                    break;
                case 5:
                    using (StreamWriter sw = new StreamWriter("MasterFile.csv", true))
                    {
                        sw.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7},{8}", newInfo[0], tempInfo[1], tempInfo[2], tempInfo[3], tempInfo[4], tempInfo[5], newInfo[6], newInfo[7], newInfo[8]);
                        Console.Clear();
                        Console.WriteLine("Inputting comments....");
                        Thread.Sleep(2000);
                        Console.Clear();
                    }
                    break;
                case 6:
                    using (StreamWriter sw = new StreamWriter("MasterFile.csv", true))
                    {
                        sw.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7},{8}", newInfo[0], tempInfo[1], tempInfo[2], tempInfo[3], tempInfo[4], tempInfo[5], tempInfo[6], newInfo[7], ManagerInfo[7]);
                        Console.Clear();
                        Console.WriteLine("Changing status and verification....");
                        Thread.Sleep(2000);
                        Console.Clear();
                    }
                    break;
                case 7:
                    using (StreamWriter sw = new StreamWriter("MasterFile.csv", true))
                    {
                        sw.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7},{8}", newInfo[0], tempInfo[1], tempInfo[2], tempInfo[3], newInfo[4], newInfo[2], tempInfo[6], newInfo[7], ManagerInfo[8]);
                        Console.Clear();
                        Console.WriteLine("Ending/Closing Task....");
                        Thread.Sleep(2000);
                        Console.Clear();
                    }
                    break;
            }
            return false;
        }

        // 0 - task name
        // 1 - creation time
        // 2 - assigned to who
        // 3 - assigned time
        // 4 - task status 
        // 5 - completion time
        // 6 - comments
        // 7 - verification
        // 8 - task desc
        // 9 - verification time
        // 10 - n/a

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