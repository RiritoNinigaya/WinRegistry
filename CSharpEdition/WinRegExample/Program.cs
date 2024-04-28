using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinRegistry;

namespace WinRegExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WinReg registr = new WinReg();
            registr.WriteStrValue(Microsoft.Win32.RegistryHive.LocalMachine, "SOFTWARE\\Policies\\Microsoft\\Windows\\System", "Test1", "Test1");
            Environment.Exit(1112);
        }
    }
}
