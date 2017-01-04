using System;

namespace SapGuiScripting.actions.filters {
    public class ActionFilter : ActionDecorator {
        private readonly ActionRuleset ruleset;

        public ActionFilter(Action origin, ActionRuleset ruleset) : base(origin) {
            this.ruleset = ruleset;
        }

        public override void Execute(ActionContext context) {
            if (this.ruleset.IsAllowedToExecute(context) == true) {
                base.Execute(context);
            }
        }
    }
}