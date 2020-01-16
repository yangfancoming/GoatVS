using System;
using System.Windows.Forms;

namespace chapter3_6_1 {

    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
//        [STAThread]
//        static void Main() {
//            Application.EnableVisualStyles();
//            Application.SetCompatibleTextRenderingDefault(false);
//            Application.Run(new Form1());
//        }

        static void Main(string[] args) {
            Xml1.parse(@"E:\Code\C#_code\RiderLearning\GoatVS\chapter3-6-1\student.xml");
        }
    }
}