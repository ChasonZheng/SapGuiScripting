using Engine.session;

namespace Engine.actions {
    public class ActiveActionContext : ActionContext {
        private readonly GuiSessionProvider provider = new ActiveSessionProvider();
        public GuiSession GetSession() {
            return provider.GetSession();
        }
    }
}