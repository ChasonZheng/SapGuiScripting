using System.Diagnostics;
using SapGuiScripting.session;
using SAPFEWSELib;
using Xunit;

namespace SapGuiScriptingTest {
    public class Test {

        [Fact]
        public void TestSimple() {
            Debug.WriteLine("dasdsaasdasd");
            FirstSessionProvider provider = new FirstSessionProvider();
            GuiSession session = provider.GetSession();
            session.StartRequest += delegate { Debug.Write("yeees"); };
            //Application.Run(new Form1());
            //while (true) {
            //System.Threading.Thread.Sleep(1000);
            //}
        }

        public static void Main() {
        }
    }
}