using Engine.session;

namespace Engine.actions {
    public class ActiveActionContext : ActionContext {

        //private readonly GuiSession activeSession = new ActiveSession(new ActiveSessionProvider());
        public GuiSession GetSession() {
            return new ActiveSession();
        }
    }
}