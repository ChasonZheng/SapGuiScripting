using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAPFEWSELib;
using System.Windows.Forms;

namespace HelloWorld
{
    class ScriptTest {
        //--------------------------//
        //main method somewhere else 
        public static void Main(string[] args)
        {
            SapGuiScript script = new SapGuiScript();
            //GuiSession session = script.getSession();
            //ISapCTextField component = (ISapCTextField)session.FindById("/app/con[0]/ses[0]/wnd[0]/usr/ctxtSEOCLASS-CLSNAME");
            //component.Text = "ac";
            Application.Run(new Form1());
            
        }
    }
}
