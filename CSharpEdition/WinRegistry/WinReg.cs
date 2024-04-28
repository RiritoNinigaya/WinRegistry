using Microsoft.Win32;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Threading;
namespace WinRegistry
{
    public class WinReg
    {
        public void WriteDWORDValue(RegistryHive hive, string subkey, string str, object object_any)
        {
            RegistryKey reg = RegistryKey.OpenBaseKey(hive, RegistryView.Registry64); //By Default is X64 for NOW!!!
            RegistryKey newKey = null;
            newKey = reg.OpenSubKey(subkey, true);
            if(newKey == null)
            {
                Debug.WriteLine("Failed To Open Sub Key!!!");
            }
            newKey.SetValue(str, object_any, RegistryValueKind.DWord);
            newKey.Close(); //Closes key Function and Flushes Values in regedit program
        }
        public void WriteQWORDValue(RegistryHive hive, string subkey , string newValue, object value)
        {
            RegistryKey reg = RegistryKey.OpenBaseKey(hive, RegistryView.Registry64);
            RegistryKey newKey = null;
            newKey = reg.OpenSubKey(subkey, true);
            if (newKey == null)
            {
                Debug.WriteLine("Failed To Open Sub Key!!!");
            }
            newKey.SetValue(newValue, value, RegistryValueKind.QWord);
            newKey.Close();
        }
        public void WriteStrValue(RegistryHive hive, string subkey, string newValue, object value)
        {
            RegistryKey reg = RegistryKey.OpenBaseKey(hive, RegistryView.Registry64);
            RegistryKey newKey = null;
            newKey = reg.OpenSubKey(subkey, true);
            if (newKey == null)
            {
                Debug.WriteLine("Failed To Open Sub Key!!!");
            }
            newKey.SetValue(newValue, value, RegistryValueKind.String);
            newKey.Close();
        }
        public void WriteBinaryValue(RegistryHive hive, string subkey, string newValue, byte[] value)
        {
            RegistryKey reg = RegistryKey.OpenBaseKey(hive, RegistryView.Registry64);
            RegistryKey newKey = null;
            newKey = reg.OpenSubKey(subkey, true);
            if (newKey == null)
            {
                Debug.WriteLine("Failed To Open Sub Key!!!");
            }
            newKey.SetValue(newValue, value, RegistryValueKind.Binary);
            newKey.Close();
        }
    }
}
