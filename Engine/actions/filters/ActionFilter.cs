namespace Engine.actions.filters {

    public class ActionFilter : ActionDecorator {
        private readonly ActionRuleset ruleset;

        public ActionFilter(Action origin, ActionRuleset ruleset) : base(origin) {
            this.ruleset = ruleset;
        }

        public override void Execute(ActionContext context) {
            if (ruleset.IsAllowedToExecute(context)) {
                base.Execute(context);
            }
        }
    }
}