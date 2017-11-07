namespace Engine.actions.parameterSignatureSuggestion {

    public interface ParameterSignatureSuggestion {
        void Suggest(string parameterName, SuggestionConsumer consumer);
    }

}