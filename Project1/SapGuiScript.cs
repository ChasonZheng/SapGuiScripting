using System;
using System.Collections.Generic;
using System.Text;
using SAPFEWSELib;


namespace HelloWorld
{
    //created a class for the SAP app, connection, and session objects as well as for common methods. 
    public class SapGuiScript
    {
        private GuiApplication application { get; set; }
        public static GuiConnection SapConnection { get; set; }
        public static GuiSession SapSession { get; set; }


        public GuiSession getSession()
        {

            SapROTWr.CSapROTWrapper sapROTWrapper = new SapROTWr.CSapROTWrapper();
            object SapGuilRot = sapROTWrapper.GetROTEntry("SAPGUI");
            object engine = SapGuilRot.GetType().InvokeMember(
                "GetScriptingEngine",
                System.Reflection.BindingFlags.InvokeMethod,
                null,
                SapGuilRot,
                null);

            GuiApplication sapGuiApp = engine as GuiApplication;
            return sapGuiApp.ActiveSession;
            GuiConnection connection = (GuiConnection)sapGuiApp.Children.ElementAt(0);
            GuiSession session = (GuiSession)connection.Children.ElementAt(0);

            return session;
        }

        public static void openSap(string env)
        {
            //SapGuiScript.SapGuiApp = 

            //string connectString = null;
            //if (env.ToUpper().Equals("DEFAULT"))
            //{
            //    connectString = "1.0 Test ERP (DEFAULT)";
            //}
            //else
            //{
            //    connectString = env;
            //}
            //SapGuiScript.SapConnection = SapGuiScript.SapGuiApp.OpenConnection(connectString, Sync: true); //creates connection
            //SapGuiScript.SapSession = (GuiSession)SapGuiScript.SapConnection.Sessions.Item(0); //creates the Gui session off the connection you made
        }

        public void login(string myclient, string mylogin, string mypass, string mylang)
        {
            //GuiTextField client = (GuiTextField)SapGuiScript.SapSession.ActiveWindow.FindByName("RSYST-MANDT", "GuiTextField");
            //GuiTextField login = (GuiTextField)SapGuiScript.SapSession.ActiveWindow.FindByName("RSYST-BNAME", "GuiTextField");
            //GuiTextField pass = (GuiTextField)SapGuiScript.SapSession.ActiveWindow.FindByName("RSYST-BCODE", "GuiPasswordField");
            //GuiTextField language = (GuiTextField)SapGuiScript.SapSession.ActiveWindow.FindByName("RSYST-LANGU", "GuiTextField");

            //client.SetFocus();
            //client.Text = myclient;
            //login.SetFocus();
            //login.Text = mylogin;
            //pass.SetFocus();
            //pass.Text = mypass;

            ////Press the green checkmark button which is about the same as the enter key 
            //GuiButton btn = (GuiButton)SapSession.FindById("/app/con[0]/ses[0]/wnd[0]/tbar[0]/btn[0]");
            //btn.SetFocus();
            //btn.Press();

        }
    }
}
