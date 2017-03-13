namespace SapGuiScripting.actions.parameterTypeSuggestion {
    public interface SuggestionConsumer {
        void SetType(string type);
        void SetModifier(string modifier);
        void SetCallByValue(bool hasCallByValue);
        void SetReferenceType(string referenceType);
    }
}