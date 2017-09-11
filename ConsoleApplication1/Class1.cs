using System;
using SolidWorks.Interop.sldworks;
using System.Threading;
using System.Diagnostics;
using Microsoft.Win32;
using System.Runtime.InteropServices;

namespace ConsoleApplication1
{
    class MyProcess
    {
        //C:\Program Files\SOLIDWORKS Corp\SOLIDWORKS\ + 

        //delegate void del();

        // MyProcess instance = new MyProcess();
        // del d = new del(CheckProcess);


        public static int errors;
        public static int warnings;
        Program prog = new Program();
        public SldWorks CheckProcess()
        {
            Process[] process = Process.GetProcessesByName("SLDWORKS");
            Process pr = new Process();
            string path = null;

           
            if (process.Length > 0)
            {
                Console.WriteLine(process.Length.ToString());
                Console.WriteLine("The process is already going!");
                Console.ReadLine();
            }
            else
            {
                string p = "SOFTWARE\\SolidWorks\\SOLIDWORKS 2016\\Setup\\";
                
                RegistryKey key = Registry.LocalMachine.OpenSubKey(p);
                
                var installPath = key.GetValue(@"SolidWorks Folder");
                
                if (installPath != null)
                {
                   path = installPath.ToString() + "SLDWORKS.exe";
                }
                else
                {
                    Console.Write("Path is null");                    
                }

                Console.WriteLine("THE");
                
                ProcessStartInfo info = new ProcessStartInfo(path);
                pr.StartInfo = info;
                pr.Start();




                Thread main = Thread.CurrentThread;
                Thread.Sleep(5000);
                // pr.WaitForExit();
                Console.WriteLine("END");
                //Console.ReadLine();
            };
            return (SldWorks)Marshal.GetActiveObject("SldWorks.Application");            
        }
    }
}