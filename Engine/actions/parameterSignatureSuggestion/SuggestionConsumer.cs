namespace Engine.actions.parameterTypeSuggestion {

    public enum ParameterModifier {
        IMPORTITNG,
        EXPORTING,
        CHANGING,
        RETURNING,
        INSTANCE,
        STATIC
    }

    public enum ParameterReference {
        TYPE,
        TYPE_REF_TO
    }
    public interface SuggestionConsumer {
        void SetType(string type);
        void SetModifier(ParameterModifier modifier);
        void SetCallByValue(bool hasCallByValue);
        void SetReferenceType(ParameterReference referenceType);
    }
}