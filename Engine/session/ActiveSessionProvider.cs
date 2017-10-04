using System.Reflection;
using SapROTWr;
using SAPFEWSELib;

namespace Engine.session {
    public class ActiveSessionProvider : GuiSessionProvider {

        private GuiApplication application = null;
        
        public GuiSession GetSession() {
            GuiApplication application = GetApplication();
            //Direkt abspeichern, um später Referenz nicht zu verlieren
            SAPFEWSELib.GuiSession session = application.ActiveSession;

            if (session == null) {
                System.Diagnostics.Debug.WriteLine("Session angefordert - keine active Session da :(");
                return new NullSession();
            } else {
                System.Diagnostics.Debug.WriteLine("Session angefordert - Active Session is da");
            }
            return new SapGuiSession(session);
        }

        public GuiApplication GetApplication() {
            if (application == null) {
                SapROTWr.CSapROTWrapper sapRotWrapper = new SapROTWr.CSapROTWrapper();
                object sapGuilRot = sapRotWrapper.GetROTEntry("SAPGUI");
                if (sapGuilRot == null) {
                    throw new NoSapGuiFoundException("No rot object found - is Sap Gui running?");
                }
                 application = (GuiApplication) sapGuilRot.GetType().InvokeMember(
                    "GetScriptingEngine",
                    System.Reflection.BindingFlags.InvokeMethod,
                    null,
                    sapGuilRot,
                    null);
            }
            return application;
        }
    }
}