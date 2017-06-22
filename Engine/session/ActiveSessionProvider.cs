using System.Reflection;
using SapROTWr;
using SAPFEWSELib;

namespace Engine.session {
    public class ActiveSessionProvider : GuiSessionProvider {

        private readonly GuiApplication application = null;
        
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
            if (application != null) return application;

            CSapROTWrapper sapRotWrapper = new CSapROTWrapper();
            object sapGuilRot = sapRotWrapper.GetROTEntry("SAPGUI");
            if (sapGuilRot == null) {
                throw new NoSapGuiFoundException("No rot object found - is Sap GUI running?");
            }
            object engine = sapGuilRot.GetType().InvokeMember(
                "GetScriptingEngine",
                BindingFlags.InvokeMethod,
                null,
                sapGuilRot,
                null
            );
            if (engine == null) {
                throw new NoSapGuiFoundException("no engine - is sap gui scripting enabled?");
            }
            return (GuiApplication)engine;
            return this.application;

        }
    }
}