namespace DataBase.model {

    public class EquitmentInfo {

        public string EquitId;

        public string 设备ID{
            get => EquitId;
            set => EquitId = value;
        }


        public string IpAddr;

        public string IP地址{
            get => IpAddr;
            set => IpAddr = value;
        }

        public string MacAddr;

        public string MAC地址{
            get => MacAddr;
            set => MacAddr = value;
        }
    }
}