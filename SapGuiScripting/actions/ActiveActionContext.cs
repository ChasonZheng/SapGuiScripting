using SapGuiScripting.session;

namespace SapGuiScripting.actions {
    public class ActiveActionContext : ActionContext {
        private readonly GuiSessionProvider provider = new ActiveSessionProvider();
        public GuiSession GetSession() {
            return provider.GetSession();
        }
    }
}