using Engine.actions.parameterSignatureSuggestion.typeSuggestion;

namespace Engine.actions.parameterSignatureSuggestion {

    public class MethodParameterSignatureSuggestion : ParameterSignatureSuggestion {

        private ParameterTypeSuggestion typeSuggestion;
        private TestTypeSuggestion testTypeSuggesetion = new TestTypeSuggestion();

        public MethodParameterSignatureSuggestion(ParameterTypeSuggestion typeSuggestion) {
            this.typeSuggestion = typeSuggestion;
        }

        public void Suggest(string parameterName, SuggestionConsumer consumer) {

            if (parameterName.Length < 2) {
                return;
            }

            parameterName = parameterName.ToUpper();

            consumer.SetVisiblity(GetVisiblity(parameterName));
            consumer.SetTyping(GetTyping(parameterName));
            //consumer.SetCallByValue(GetCallByValue(parameterName));
            consumer.SetType(testTypeSuggesetion.SuggestType(parameterName));
        }

        private VariableVisibility GetVisiblity(string parameterName) {
            switch (parameterName.Substring(0, 1)) {
                case "I":
                    return VariableVisibility.IMPORTITNG;
                case "E":
                    return VariableVisibility.EXPORTING;
                case "R":
                    return VariableVisibility.RETURNING;
                case "C":
                    return VariableVisibility.CHANGING;
                case "M":
                    return VariableVisibility.INSTANCE;
                case "S":
                    return VariableVisibility.STATIC;
                default:
                    return VariableVisibility.STATIC;
            }
        }

        private VariableTyping GetTyping(string parameterName) {
            switch (parameterName.Substring(1, 1).ToUpper()) {
                case "V":
                case "S":
                case "T":
                    return VariableTyping.TYPE;
                case "R":
                    return VariableTyping.TYPE_REF_TO;
                default:
                    return VariableTyping.TYPE;
            }
        }

        //   private bool GetCallByValue(string parameterName) {
        //      return parameterName.Substring(0, 1).Equals('R');
        //  }
    }
}