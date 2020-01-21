using System;
using System.Windows.Forms;
using chapter6_2_3.Domain;
using IBatisNet.DataMapper;
using IBatisNet.DataMapper.Configuration;

namespace chapter6_2_3 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        public static ISqlMapper EntityMapper
        {
            get
            {
                try
                {
                    ISqlMapper mapper = Mapper.Instance();
                    mapper.DataSource.ConnectionString = "Data Source=(local);Initial Catalog=web;Integrated Security=True";
                    return mapper;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

//        public static Guid executeFunction()
//        {

//            ISqlMapper mapper = EntityMapper;
//            Guid str = mapper.QueryForObject<Guid>("FindPageId", "Footer");
//            return str;

//        }

//        public static BASE_DAL baseDal = new BASE_DAL();
        private void button1_Click(object sender, EventArgs e) {
            DomSqlMapBuilder builder = new DomSqlMapBuilder();
            ISqlMapper Map = builder.Configure("IBatis/SqlMap.config");
            SysUser temp = new SysUser();
            temp.account = "123";
            SysUser user = Map.QueryForObject("sys_user.selectOne", temp) as SysUser;
        }

    }
}