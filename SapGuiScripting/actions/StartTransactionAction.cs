using GuiSession = SapGuiScripting.session.GuiSession;

namespace SapGuiScripting.actions {
    public class StartTransactionAction : Action{
        private readonly string transaction;

        public StartTransactionAction(string transaction) {
            this.transaction = transaction;
        }

        public void Execute(ActionContext context) {
            GuiSession session = context.GetSession();
            session.StartTransaction(transaction);
        }
    }
}