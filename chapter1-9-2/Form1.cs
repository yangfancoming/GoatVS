﻿using System;
using System.Windows.Forms;
using Amazon.S3;

namespace chapter1_9_2 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            MinIo1.test1();
        }

        private void button2_Click(object sender, EventArgs e) {
            MinIo1.test2();
        }

        private void btn_test_Click(object sender, EventArgs e) {
//            App.test();
            App.test2();
        }
    }
}