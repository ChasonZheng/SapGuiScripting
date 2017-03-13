namespace SapGuiScripting.actions.parameterTypeSuggestion {
    public interface ParameterSignatureSuggestion {
        void Suggest(string parameterName, SuggestionConsumer consumer);
    }
}