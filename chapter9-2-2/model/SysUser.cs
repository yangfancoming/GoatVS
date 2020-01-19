using System;

namespace chapter6_2_3.model {

    [Serializable] //提高实体传输数据的效率
    public class SysUser {

        public int? id { get; set; }
        public String account { get; set; }
        public String password { get; set; }
        public String username { get; set; }
        public String nickname { get; set; }
        public String createtime { get; set; }
        public bool isenable { get; set; }
        public String email { get; set; }

        public int user_id { get; set; }
        public int role_id { get; set; }
        public String code { get; set; }

    }
}
