using System;
using System.Management;

namespace chapter8_8_8.constant {


    public class Funcs {

        public static readonly Func<ManagementObject, string> macAddr = mo => mo["MacAddress"].ToString();

        public static readonly Func<ManagementObject, string> ipAddr = mo =>  (mo.Properties["IpAddress"].Value as Array).GetValue(0).ToString();

    }
}