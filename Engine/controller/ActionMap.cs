using Engine.actions;
using Engine.controller.hotkeys;

namespace Engine.controller
{
    public interface ActionMap {
        void RegisterOnHotKey(Hotkey hotkey, Action action);
        void RegisterOnFocusChanged(FocusChangedContext context, Action action);
        void RegisterOnStartTransaction(NewTransactionContext context, Action action);

    }
}
