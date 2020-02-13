using System;
using System.Diagnostics;
using System.Management;

namespace chapter8_8_8 {

    public class App {

        public static void test1() {
            var macAddress = GetMacAddress();
            Debug.Print(macAddress);
        }

        /// <summary>
        /// 获取本机MAC地址
        /// </summary>
        /// <returns>本机MAC地址</returns>
        private static string GetMacAddress(){
            var strMac = string.Empty;
            try{
                var mc = new ManagementClass("Win32_NetworkAdapterConfiguration");
                var moc = mc.GetInstances();
                foreach (ManagementObject mo in moc){
                    if ((bool)mo["IPEnabled"]) {
                        strMac = mo["MacAddress"].ToString();
//                        var ar = (Array)(mo.Properties["IpAddress"].Value);
//                        strMac = ar.GetValue(0).ToString();
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