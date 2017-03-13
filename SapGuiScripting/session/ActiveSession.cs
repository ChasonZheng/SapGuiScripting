using System;
using System.Linq;
using SAPFEWSELib;

namespace SapGuiScripting.session {
    public class ActiveSession : GuiSession {

        private readonly ActiveSessionProvider activeSessionProvider;

        public ActiveSession(ActiveSessionProvider activeSessionProvider) {
            this.activeSessionProvider = activeSessionProvider;
            activeSessionProvider.GetApplication().CreateSession += delegate (SAPFEWSELib.GuiSession session) {
                session.StartRequest += DelegateOnStartRequest;
                session.FocusChanged += DelegateOnFocusChanged;
            };
            GuiConnection connection = activeSessionProvider.GetApplication().Children.Cast<GuiConnection>().FirstOrDefault();
            foreach (SAPFEWSELib.GuiSession session in connection?.Sessions) {
                session.StartRequest += DelegateOnStartRequest;
                session.FocusChanged += DelegateOnFocusChanged;
            }

        }

        public GuiComponent FindById(string path) {
            return activeSessionProvider.GetSession().FindById(path);
        }

        public string GetCurrentProgram() {
            return activeSessionProvider.GetSession().GetCurrentProgram();
        }

        public string GetCurrentScreen() {
            return activeSessionProvider.GetSession().GetCurrentScreen();
        }

        public void StartTransaction(string transaction) {
            activeSessionProvider.GetSession().FindById(transaction);
        }

        private void DelegateOnStartRequest(SAPFEWSELib.GuiSession currentSession) {
            StartRequest?.Invoke(activeSessionProvider.GetSession());
        }

        private void DelegateOnFocusChanged(SAPFEWSELib.GuiSession currentSession, GuiVComponent newFocusedControl) {
            FocusChanged?.Invoke(activeSessionProvider.GetSession(), newFocusedControl);
        }

        public override string ToString() {
            return activeSessionProvider.GetSession().ToString();
        }

        public event StartRequestHandler StartRequest;
        public event FocusChangedHandler FocusChanged;
    }
}
