using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SAPFEWSELib;
using SapGuiScripting;
using SapGuiScripting.actions;
using SapGuiScripting.@base;
using TEXTEDITLib;
using Xunit;

namespace SapGuiScriptingTest {
    public class Test {

        [Fact]
        public void TestSimple() {
            Console.WriteLine("dasdsaasdasd");
            System.Diagnostics.Debug.WriteLine("dasdsaasdasd");
            FirstSessionProvider provider = new FirstSessionProvider();
            GuiSession session = provider.GetSession();
            session.StartRequest += delegate (GuiSession guiSession) { System.Diagnostics.Debug.Write("yeees"); };
            //Application.Run(new Form1());
            //while (true) {
            //System.Threading.Thread.Sleep(1000);
            //}


        }

    }
}
