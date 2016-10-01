using MySql.Data;
using MySql.Data.MySqlClient;
using System;

namespace Database {
    public class Database {
        private Database() {
        }

        private string databaseName = string.Empty;
        public string DatabaseName {
            get { return databaseName; }
            set { databaseName = value; }
        }

        public string Password { get; set; }
        private MySqlConnection connection = null;
        public MySqlConnection Connection {
            get { return connection; }
        }

        private static Database _instance = null;
        public static Database Instance() {
            if (_instance == null)
                _instance = new Database();
            return _instance;
        }

        public bool IsConnect() {
            bool result = true;
            if (Connection == null) {
                if (String.IsNullOrEmpty(databaseName))
                    result = false;
                string connstring = string.Format("Server=localhost; database={0}; UID=UserName; password=your password", databaseName);
                connection = new MySqlConnection(connstring);
                connection.Open();
                result = true;
            }

            return result;
        }

        public void Close() {
            connection.Close();
        }
    }
}
