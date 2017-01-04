namespace SapGuiScripting.actions.parameterTypeSuggestion {
    public class ParameterTypeSuggestionAction : Action {

        public void Execute(ActionContext context) {

            string parameterName = "";
            string suggestion = new MethodParameterTypeSuggestion().GetSuggestion(parameterName);

        }
    }
}