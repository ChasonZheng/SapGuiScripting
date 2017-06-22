using SAPFEWSELib;

namespace Engine.session {
    public class NullSession : GuiSession {
        public GuiComponent FindById(string path) {
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

        public override string ToString() {
            return "NullSession hier";
        }
        public event StartRequestHandler StartRequest;
        public event FocusChangedHandler FocusChanged;
    }
}