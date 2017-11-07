namespace Engine.actions.parameterSignatureSuggestion {

    public enum VariableVisibility {
        IMPORTITNG,
        EXPORTING,
        CHANGING,
        RETURNING,
        INSTANCE,
        STATIC
    }

    public enum VariableTyping {
        TYPE,
        TYPE_REF_TO
    }
    public interface SuggestionConsumer {
        void SetType(string type);
        void SetVisiblity(VariableVisibility visibility);
        void SetTyping(VariableTyping typing);
    }
}