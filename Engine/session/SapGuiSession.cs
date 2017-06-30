using System;
using SAPFEWSELib;

namespace Engine.session {
    public class SapGuiSession : GuiSession {

        private readonly SAPFEWSELib.GuiSession session;

        public SapGuiSession(SAPFEWSELib.GuiSession session) {
            this.session = session;
        }


        public GuiComponent FindById(string path) {
            GuiComponent component = null;
            try {
                component = session.FindById(path);
            } catch (Exception e) {
                throw new InvalidPathException(path);
            }
            return component;
        }

        public string GetCurrentProgram() {
            return session.Info.Program;
        }

        public string GetCurrentScreen() {
            return session.Info.ScreenNumber.ToString();
        }

        public void StartTransaction(string transaction) {
            session.StartTransaction(transaction);
        }

        public string GetIndex() {
            return session.Info.SystemSessionId;
        }

        public string GetWindowIndex() {
            return session.ActiveWindow.Id;
        }

        public string GetConnectionIndex() {
            GuiConnection connection = (GuiConnection) session.Parent;
            return connection.Name;
        }

        public string GetId() {
            return session.Id;
        }

        public override string ToString() {
            return session.Name;
        }

        public event StartRequestHandler StartRequest;
        public event FocusChangedHandler FocusChanged;

    }
}