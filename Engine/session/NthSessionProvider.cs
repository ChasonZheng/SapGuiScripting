﻿using SapROTWr;
using SAPFEWSELib;
using System.Reflection;
using System.Linq;

namespace Engine.session {
    class NthSessionProvider : GuiSessionProvider {

        private int index;

        public NthSessionProvider(int index) {
            this.index = index;
        }

        public GuiSession GetSession() {
            CSapROTWrapper sapRotWrapper = new CSapROTWrapper();
            object sapGuilRot = sapRotWrapper.GetROTEntry("SAPGUI");
            if (sapGuilRot == null) throw new NoSapGuiFoundException("No rot object found - is Sap Gui running?");
            object engine = sapGuilRot.GetType().InvokeMember(
                "GetScriptingEngine",
                BindingFlags.InvokeMethod,
                null,
                sapGuilRot,
                null);
            if (engine == null) throw new NoSapGuiFoundException("no engine - wie kann das sein?");
            GuiApplication sapGuiApp = engine as GuiApplication;

            GuiConnection connection = sapGuiApp?.Children.Cast<GuiConnection>().ElementAt(index);
            if (connection == null) throw new NoSapGuiFoundException("no connection - Are you logged into any system?");
            foreach (SAPFEWSELib.GuiSession session in connection.Sessions) {
                return new SapGuiSession(session);
            }
            return null;
        }
    }
}
