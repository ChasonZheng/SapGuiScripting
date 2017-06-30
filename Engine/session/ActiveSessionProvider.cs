using System.Reflection;
using SapROTWr;
using SAPFEWSELib;

namespace Engine.session {
    public class ActiveSessionProvider : GuiSessionProvider {

        private static readonly GuiApplication application = null;
        
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

        public static GuiApplication GetApplication() {
            return null;
            if (application != null) return application;

            
        }
    }
}