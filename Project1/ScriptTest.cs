using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAPFEWSELib;
using System.Windows.Forms;
using SapGuiScripting.@base;

namespace HelloWorld
{
    class ScriptTest {
        //--------------------------//
        //main method somewhere else 
        public static void Main(string[] args)
        {
            FirstSessionProvider provider = new FirstSessionProvider();
            GuiSession session = provider.GetSession();
            session.StartRequest += delegate (GuiSession guiSession) { System.Diagnostics.Debug.Write("yeees"); };
            Application.Run(new Form1());
            
        }
    }
}
