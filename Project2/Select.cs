using SharpSapRfc;
using SharpSapRfc.Soap;

namespace DataBase {
    internal class Select {
        public static void Main(string[] args) {
            SapRfcConnection conn = new SoapSapRfcConnection("DEV");
            RfcResult result = conn.ExecuteFunction("ZPLU_RFC_TEST");
        }
    }
}