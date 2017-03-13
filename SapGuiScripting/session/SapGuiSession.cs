using System;
using SAPFEWSELib;

namespace SapGuiScripting.session {
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

        public override string ToString() {
            //return "faked";
            if (session == null) {
                System.Diagnostics.Debug.Write("NULL WIE KANN DAS SEIN :(");
            }
            return session.Name;
        }

        public event StartRequestHandler StartRequest;
        public event FocusChangedHandler FocusChanged;

    }
}