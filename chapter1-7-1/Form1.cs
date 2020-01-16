using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using chapter1_7_1.yield;

namespace chapter1_7_1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            IEnumerable<int> findBobs1 = Yield3.enumerableFuc1();
            Debug.Print(findBobs1.ToString());


            IEnumerable<int> findBobs2 = Yield3.enumerableFuc2();
            Debug.Print(findBobs2.ToString());


            string[] temp = {"hha", "gag", "Bob"};

            IList<string> findBobs11 = Yield2.FindBobs1(temp);
            Debug.Print(findBobs11.ToString());

            IEnumerable<string> findBobs22 = Yield2.FindBobs2(temp);
            Debug.Print(findBobs22.ToString());


            foreach (string item in Yield1.SimpleList())
                Debug.Print(item);
        }
    }
}