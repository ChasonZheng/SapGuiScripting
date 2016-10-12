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

        public static void Main(string[] args)
        {
            FirstSessionProvider provider = new FirstSessionProvider();
            GuiSession session = provider.GetSession();
            ISapAbapEditorTarget editor = (ISapAbapEditorTarget)session.FindById("/app/con[0]/ses[0]/wnd[0]/usr/subDY0400_EDITORSUBSCREEN:SAPLEDITOR_START:8430/cntlEDITOR");
            int count = 0;
            session.StartRequest += delegate (GuiSession guiSession) {
                count++;
                System.Diagnostics.Debug.Write(count);
            };
           // Application.Run(new Form1());
            
        }
    }
}
