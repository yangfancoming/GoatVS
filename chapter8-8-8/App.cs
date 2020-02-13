using System;
using System.Diagnostics;
using System.Management;
using chapter8_8_8.constant;

namespace chapter8_8_8 {

    public class App {

        public static void test1() {
            var ipAddr = getSystemInfo(Funcs.ipAddr);
            Debug.Print(ipAddr);
            var macAddress = getSystemInfo(Funcs.macAddr);
            Debug.Print(macAddress);
        }

        /// <summary>
        /// 获取本机MAC地址
        /// </summary>
        /// <returns>本机MAC地址</returns>
        private static string getSystemInfo(Func<ManagementObject, string> func){
            var strMac = string.Empty;
            try{
                var mc = new ManagementClass("Win32_NetworkAdapterConfiguration");
                var moc = mc.GetInstances();
                foreach (ManagementObject mo in moc){
                    if ((bool)mo["IPEnabled"]) {
                        strMac = func(mo);
                    }
                }
                return strMac;
            }
            catch{
                return strMac;
            }
        }
    }
}