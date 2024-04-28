using Microsoft.Win32;
using System.Diagnostics;
using System.Threading;
namespace WinRegistry
{
    public class WinReg
    {
        public void WriteInLocalMachineDWORD(string subkey, string str, object object_any)
        {
            RegistryKey reg = Registry.LocalMachine.OpenSubKey(subkey, true);
            if(reg == null)
            {
                Debug.WriteLine("Failed To Open Sub Key!!!");
            }
            reg.SetValue(str, object_any, RegistryValueKind.DWord);
        }
    }
}
