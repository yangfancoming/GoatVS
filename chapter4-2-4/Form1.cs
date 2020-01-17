using System;
using System.Diagnostics;
using System.Windows.Forms;
using item01;
using Spring.Context;
using Spring.Context.Support;

namespace chapter4_2_4 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            NormalMethod();  // 一般方法
            FactoryMethod();  // 工厂方法
            IoCMethod();  // IoC方法"
        }


        private static void NormalMethod(){
            IPerson dao = new Person();
            dao.Save();
            Debug.Print("我是一般方法");
        }

        private static void FactoryMethod(){
            IPerson dao = DataAccess.CreatePersonDao();
            dao.Save();
            Debug.Print("我是工厂方法");
        }

        private static void IoCMethod(){
            IApplicationContext ctx = ContextRegistry.GetContext();
            if (ctx.GetObject("Person") is IPerson dao){
                dao.Save();
                Debug.Print("我是IoC方法");
            }
        }
    }
}