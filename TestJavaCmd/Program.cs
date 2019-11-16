using RunProcessAsTask;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestJavaCmd
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Starting..");

            string javaPATH = @"C:\Users\Nathan\Documents\JavaPlayground\TestCmdReturnCode\src\app\App";
            string strCmdText;
            strCmdText = @"-classpath C:\Users\Nathan\Documents\JavaPlayground\TestCmdReturnCode\src\app; App fsdf";


            var processInfo = new ProcessStartInfo(@"C:\Program Files\AdoptOpenJDK\jdk-11.0.5.10-hotspot\bin\java.exe", strCmdText)
            {
                CreateNoWindow = true,
                UseShellExecute = false
            };
            Process proc;

            if ((proc = Process.Start(processInfo)) == null)
            {
                throw new InvalidOperationException(" ?? ");
            }

            Stopwatch sw1 = new Stopwatch();
            sw1.Start();
            proc.WaitForExit();
            int exitCode = proc.ExitCode;
            proc.Close();
            sw1.Stop();
            Console.WriteLine(sw1.ElapsedMilliseconds);
            Console.WriteLine($"ExitCode: {exitCode}");



        }
    }
}
