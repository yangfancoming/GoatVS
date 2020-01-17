using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Windows.Forms;
using Dapper;
using DemoLibrary;

namespace chapter5_2_7 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private static string LoadConnectionString(string ID = "Default") {
            return ConfigurationManager.ConnectionStrings[ID].ConnectionString;
        }
        private void button1_Click(object sender, EventArgs e) {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<PersonModel>("SELECT * FROM PERSON", new DynamicParameters());
                List<PersonModel> temp = output.ToList();
            }
        }

        private void button2_Click(object sender, EventArgs e) {

            PersonModel person = new PersonModel();
            person.FirstName = "FirstName";
            person.FullName = "fi";
            person.LastName = "LastName";
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString())) {
                var execute = cnn.Execute("INSERT INTO PERSON (FIRSTNAME, LASTNAME) values (@FirstName, @LastName)", person);
            }
        }

        private void button3_Click(object sender, EventArgs e) {
      
        }
    }
}