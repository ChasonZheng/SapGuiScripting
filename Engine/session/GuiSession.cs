﻿using SAPFEWSELib;

namespace Engine.session {
    public interface GuiSession {
        GuiComponent FindById(string path);
        string ToString();
        string GetCurrentProgram();
        string GetCurrentScreen();
        void StartTransaction(string transaction);
        string GetId();
        GuiVComponent GetInFocus();

        event StartRequestHandler StartRequest;
        event FocusChangedHandler FocusChanged;
    }

    public delegate void StartRequestHandler(GuiSession session);
    public delegate void FocusChangedHandler(GuiSession session, GuiVComponent newFocusedComponent);
}
