using SAPFEWSELib;

namespace SapGuiScripting.@base {
    public class FirstSessionProvider: GuiSessionProvider {
        public GuiSession GetSession() {
            SapROTWr.CSapROTWrapper sapRotWrapper = new SapROTWr.CSapROTWrapper();
            object sapGuilRot = sapRotWrapper.GetROTEntry("SAPGUI");
            if (sapGuilRot == null) {
                throw new NoSapGuiFoundException("No rot object found - is Sap Gui running?");
            }
            object engine = sapGuilRot.GetType().InvokeMember(
                "GetScriptingEngine",
                System.Reflection.BindingFlags.InvokeMethod,
                null,
                sapGuilRot,
                null);
            if (engine == null) {
                throw new NoSapGuiFoundException("no engine - wie kann das sein?");
            }
            GuiApplication sapGuiApp = engine as GuiApplication;
            
            GuiConnection connection = null;
            foreach (GuiConnection child in sapGuiApp.Children) {
                connection = child;
                break;
            }
            if (connection == null) {
                throw new NoSapGuiFoundException("no connection - Are you logged into any system?");
            }
            foreach (GuiSession session in connection.Sessions) {
                return session;
            }
            return null;
        }
    }
}