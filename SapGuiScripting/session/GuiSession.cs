using SAPFEWSELib;

namespace SapGuiScripting.session {
    public interface GuiSession {
        GuiComponent FindById(string path);
        string GetCurrentProgram();
        void StartTransaction(string transaction);

        //event ISapSessionEvents_StartRequestEventHandler StartRequest;
        //event ISapSessionEvents_FocusChangedEventHandler FocusChanged;

        event StartRequestHandler StartRequest;
        event FocusChangedHandler FocusChanged;
    }

    public delegate void StartRequestHandler(GuiSession session);
    public delegate void FocusChangedHandler(GuiSession session, GuiVComponent newFocusedComponent);
}
