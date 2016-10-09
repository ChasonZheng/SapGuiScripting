using SAPFEWSELib;

namespace SapGuiScripting.@base {
    internal class ActiveSessionProvider : GuiSessionProvider {

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
                throw new NoSapGuiFoundException("no engine");
            }

            GuiApplication sapGuiApp = engine as GuiApplication;
            if (sapGuiApp.ActiveSession == null) {
                throw new NoSapGuiFoundException("No active session detected - is Sap Gui focused");
            }
            return sapGuiApp.ActiveSession;
        }
    }
}
