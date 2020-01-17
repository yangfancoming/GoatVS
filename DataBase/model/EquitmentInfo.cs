namespace DataBase.model {
    public class EquitmentInfo {


        public string EquitId;

        public string 设备ID{

            get { return EquitId; }
            set { EquitId = value; }
        }


        public string IpAddr;

        public string IP地址{
            get { return IpAddr; }
            set { IpAddr = value; }
        }



        public string MacAddr;

        public string MAC地址{
            get { return MacAddr; }
            set { MacAddr = value; }
        }
    }
}