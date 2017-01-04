namespace SapGuiScripting.actions.filters.ruleset {
    public class ProgramFilter : ActionRuleset {

        private readonly string allowedProgram;

        public ProgramFilter(string allowedProgram) {
            this.allowedProgram = allowedProgram;
        }

        public bool IsAllowedToExecute(ActionContext context) {
            return context.GetSession().GetCurrentProgram() == allowedProgram;
        }
    }
}