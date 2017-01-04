using System.Reflection;
using SapROTWr;
using SAPFEWSELib;

namespace SapGuiScripting.session {
    public class ActiveSessionProvider : GuiSessionProvider {
        public GuiSession GetSession() {
            CSapROTWrapper sapRotWrapper = new CSapROTWrapper();
            object sapGuilRot = sapRotWrapper.GetROTEntry("SAPGUI");
            if (sapGuilRot == null) throw new NoSapGuiFoundException("No rot object found - is Sap GUI running?");
            object engine = sapGuilRot.GetType().InvokeMember(
                "GetScriptingEngine",
                BindingFlags.InvokeMethod,
                null,
                sapGuilRot,
                null);

            if (engine == null) throw new NoSapGuiFoundException("no engine");

            GuiApplication sapGuiApp = engine as GuiApplication;
            if (sapGuiApp.ActiveSession == null)
                throw new NoSapGuiFoundException("No active session detected - is Sap GUI focused?");
            return new SapGuiSession(sapGuiApp.ActiveSession);
        }
    }
}