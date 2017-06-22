namespace Engine.actions.filters.ruleset {
    public class FocusChangedFilter : ActionRuleset {

        public bool IsAllowedToExecute(ActionContext context) {
            return true;
        }
    }
}