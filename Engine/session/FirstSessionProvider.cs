namespace Engine.session {

    public class FirstSessionProvider : GuiSessionProvider {

        private GuiSessionProvider provider;

        public FirstSessionProvider() {
            this.provider = new NthSessionProvider(0);
        }

        public GuiSession GetSession() {
            return provider.GetSession();
        }
    }

}