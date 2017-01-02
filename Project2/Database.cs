using MySql.Data.MySqlClient;

namespace Database {
    public class Database {
        private static Database _instance;

        private Database() {
        }

        public string DatabaseName { get; set; } = string.Empty;

        public string Password { get; set; }

        public MySqlConnection Connection { get; private set; }

        public static Database Instance() {
            if (_instance == null)
                _instance = new Database();
            return _instance;
        }

        public bool IsConnect() {
            var result = true;
            if (Connection == null) {
                if (string.IsNullOrEmpty(DatabaseName))
                    result = false;
                var connstring = string.Format("Server=localhost; database={0}; UID=UserName; password=your password",
                    DatabaseName);
                Connection = new MySqlConnection(connstring);
                Connection.Open();
                result = true;
            }

            return result;
        }

        public void Close() {
            Connection.Close();
        }
    }
}