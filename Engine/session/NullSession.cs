using SAPFEWSELib;

namespace Engine.session {
    public class NullSession : GuiSession {
        public GuiComponent FindById(string path) {
            return null;
        }

        public GuiApplication GetApplication() {
            return null;
        }

        public string GetCurrentProgram() {
            return "Null";
        }

        public string GetCurrentScreen() {
            return "Null";
        }

        public void StartTransaction(string transaction) {
            
        }

        public string GetIndex() {
            return "0";
        }

        public string GetWindowIndex() {
            return "0";
        }

        public string GetConnectionIndex() {
            return "0";
        }

        public string GetId() {
            return "NULL";
        }

        public override string ToString() {
            return "NullSession hier";
        }

        public GuiVComponent GetInFocus() { 
            return null;
        }

        public event StartRequestHandler StartRequest;
        public event FocusChangedHandler FocusChanged;
    }
}