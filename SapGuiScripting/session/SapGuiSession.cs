using System;
using SAPFEWSELib;

namespace SapGuiScripting.session {
    public class SapGuiSession : GuiSession {

        private readonly SAPFEWSELib.GuiSession session;

        public SapGuiSession(SAPFEWSELib.GuiSession session) {
            this.session = session;
            session.StartRequest += delegate {
                StartRequest?.Invoke(this);
            };
            session.FocusChanged += DelegateFocusChanged;
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

        public void StartTransaction(string transaction) {
            session.StartTransaction(transaction);
        }


        public void DelegateFocusChanged(SAPFEWSELib.GuiSession currentSession, GuiVComponent newFocusedControl) {
            FocusChanged?.Invoke(this, newFocusedControl);
        }

        public event StartRequestHandler StartRequest;
        public event FocusChangedHandler FocusChanged;

    }
}