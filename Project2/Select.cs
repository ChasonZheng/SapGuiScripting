using MySql.Data.MySqlClient;
using SharpSapRfc;
using SharpSapRfc.Soap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase {

    class Select {
        public static void Main(String[] args) {
            //String connectionString = "Server=172.16.254.155; database=plunz; UID=abap_test; password=master";
            //MySqlConnection connection = new MySqlConnection(connectionString);
            //connection.Open();

            //string query = "SELECT * from parameters";
            //var cmd = new MySqlCommand(query, connection);
            //var reader = cmd.ExecuteReader();
            //while (reader.Read()) {
            //    string someStringFromColumnZero = reader.GetString(0);
            //    string someStringFromColumnOne = reader.GetString(1);
            //    Console.WriteLine(someStringFromColumnZero + "," + someStringFromColumnOne);
            //}



            //connection.Close();

            SapRfcConnection conn = new SoapSapRfcConnection("DEV");
            var result = conn.ExecuteFunction("ZPLU_RFC_TEST");



        }
    }
}
