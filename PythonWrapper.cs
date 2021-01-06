using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumControlCustomBrowser
{
    class PythonWrapper
    {
        public void run_cmd(string cmd, string args)
        {
            ProcessStartInfo start = new ProcessStartInfo();
            //start.FileName = "cmd.exe";
            start.FileName = "C:\\Users\\Peterson Andrade\\AppData\\Local\\Programs\\Python\\Python39\\python.exe";
            //start.Arguments = "/c python C:\\Users\\Peterson Andrade\\Desktop\\instapy\\quickstart.py";
            start.Arguments = "\"C:\\Users\\Peterson Andrade\\Desktop\\instapy\\quickstart.py\"";
            //var path = "C:\\Users\\Peterson Andrade\\Desktop\\instapy";
            //start.Arguments = "/c \"python " + path + "\\quickstart.py\"";

            //start.UseShellExecute = true;
            //start.CreateNoWindow = false;
            start.UseShellExecute = false;
            start.RedirectStandardOutput = true;
            //Process process = Process.Start(start);
            string resultado = string.Empty;
            using (Process process = Process.Start(start))
            {
                using (StreamReader reader = process.StandardOutput)
                {
                    string result = reader.ReadToEnd();
                    resultado = result;
                }
            }
        }
    }
}
