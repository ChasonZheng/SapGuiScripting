using Engine.actions.parameterSignatureSuggestion.typeSuggestion;

namespace Engine.actions.parameterTypeSuggestion {

    public class MethodParameterSignatureSuggestion : ParameterSignatureSuggestion {

        private ParameterTypeSuggestion typeSuggestion;
        private TestTypeSuggesetion testTypeSuggesetion = new TestTypeSuggesetion();

        public MethodParameterSignatureSuggestion(ParameterTypeSuggestion typeSuggestion) {
            this.typeSuggestion = typeSuggestion;
        }

        public void Suggest(string parameterName, SuggestionConsumer consumer) {

            if (parameterName.Length < 2) {
                return;
            }

            parameterName = parameterName.ToUpper();

            consumer.SetModifier(GetModifier(parameterName));
            consumer.SetReferenceType(GetReference(parameterName));
            consumer.SetCallByValue(GetCallByValue(parameterName));
            consumer.SetType(testTypeSuggesetion.SuggestType(parameterName));
        }

        private ParameterModifier GetModifier(string parameterName) {
            switch (parameterName.Substring(0, 1)) {
                case "I":
                    return ParameterModifier.IMPORTITNG;
                case "E":
                    return ParameterModifier.EXPORTING;
                case "R":
                    return ParameterModifier.RETURNING;
                case "C":
                    return ParameterModifier.CHANGING;
                case "M":
                    return ParameterModifier.INSTANCE;
                case "S":
                    return ParameterModifier.STATIC;
                default:
                    return ParameterModifier.STATIC;
            }
        }

        private ParameterReference GetReference(string parameterName) {
            switch (parameterName.Substring(1, 1).ToUpper()) {
                case "V":
                case "S":
                case "T":
                    return ParameterReference.TYPE;
                case "R":
                    return ParameterReference.TYPE_REF_TO;
                default:
                    return ParameterReference.TYPE;
            }
        }

        private bool GetCallByValue(string parameterName) {
            return parameterName.Substring(0, 1).Equals('R');
        }
    }
}