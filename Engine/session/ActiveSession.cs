using System;
using System.Linq;
using System.Reflection;
using SapROTWr;
using SAPFEWSELib;

namespace Engine.session {
    public class ActiveSession : GuiSession, GuiSessionProvider {

        private GuiApplication application;

        public ActiveSession() {
            GetApplication().CreateSession += delegate (SAPFEWSELib.GuiSession session) {
                session.StartRequest += DelegateOnStartRequest;
                session.FocusChanged += DelegateOnFocusChanged;
            };
            GuiConnection connection = GetApplication().Children.Cast<GuiConnection>().FirstOrDefault();
            if (connection != null) {
                foreach (SAPFEWSELib.GuiSession session in connection?.Sessions) {
                    session.StartRequest += DelegateOnStartRequest;
                    session.FocusChanged += DelegateOnFocusChanged;
                }
            }
        }

        private GuiApplication GetApplication() {

            if (application == null) {
                CSapROTWrapper sapRotWrapper = new CSapROTWrapper();
                object sapGuilRot = sapRotWrapper.GetROTEntry("SAPGUI");
                if (sapGuilRot == null) {
                    throw new NoSapGuiFoundException("No ROT object found - is SAP GUI running?");
                }
                object engine = sapGuilRot.GetType().InvokeMember(
                    "GetScriptingEngine",
                    BindingFlags.InvokeMethod,
                    null,
                    sapGuilRot,
                    null
                );
                if (engine == null) {
                    throw new NoSapGuiFoundException("No engine - is SAP GUI Scripting enabled?");
                }
                application = (GuiApplication)engine;
            }
            return application;
        }

        public GuiComponent FindById(string path) {
            Console.WriteLine("find_by_id called on active session");
        //    GuiApplication application = GetApplication();
      //      var guiConnection = application.Children.Cast<GuiConnection>();


    //        Console.WriteLine(GetSession);
//            string connectionIndex = GetSession().GetConnectionIndex();
//           string sessionIndex = GetSession().GetIndex();
            path = GetSession().GetId() + "/wnd[0]" + path;
            Console.WriteLine(path);
            return GetSession().FindById(path);
        }
        public string GetCurrentProgram() {
            return GetSession().GetCurrentProgram();
        }

        public string GetCurrentScreen() {
            return GetSession().GetCurrentScreen();
        }

        public void StartTransaction(string transaction) {
            GetSession().FindById(transaction);
        }

        public string GetIndex() {
            return GetSession().GetIndex();
        }
        public string GetWindowIndex() {
            return GetSession().GetWindowIndex();
        }

        public string GetConnectionIndex() {
            return GetSession().GetConnectionIndex();
        }
        public string GetId() {
            return GetSession().GetId();
        }

        private void DelegateOnStartRequest(SAPFEWSELib.GuiSession currentSession) {
            StartRequest?.Invoke(GetSession());
        }

        private void DelegateOnFocusChanged(SAPFEWSELib.GuiSession currentSession, GuiVComponent newFocusedControl) {
            FocusChanged?.Invoke(GetSession(), newFocusedControl);
        }

        public override string ToString() {
            return GetSession().ToString();
        }

        public GuiSession GetSession() {
            GuiSession session = new SapGuiSession(GetApplication().ActiveSession);
            if (session == null) {
                Console.WriteLine("No active session found - is SAP GUI focused?");
                return new NullSession();
            }
            return session;
        }

        public event StartRequestHandler StartRequest;
        public event FocusChangedHandler FocusChanged;
    }
}
