using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

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
                    nw.WriteLine("");
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
            switch (choice)
            {
                //creating task
                case 1:
                    using (StreamWriter sw = new StreamWriter("MasterFile.csv", true))
                    {
                        sw.WriteLine("{0},{1}:{2},{3},{4},{5},{6}", ManagerInfo[0], ManagerInfo[1], ManagerInfo[2], ManagerInfo[5], ManagerInfo[5], ManagerInfo[4], ManagerInfo[5]);
                    }
                    using (StreamWriter sw = new StreamWriter("TaskInformation.txt"))
                    {
                    }
                    Console.WriteLine("Creating Task....");
                    Thread.Sleep(2000);
                    Console.Clear();
                    break;
                //assigning task
                case 2:
                    break;
                //check task manager
                case 3:
                    break;
                //task informations 
                case 4:
                    break;
            }
        }
        public string[] Read()
        {
            string[] lines = new string[10];

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

            return lines;

        }
    }
}