namespace SapGuiScripting.actions.filters {
    public interface ActionRuleset {
        bool IsAllowedToExecute(ActionContext context);
    }
}