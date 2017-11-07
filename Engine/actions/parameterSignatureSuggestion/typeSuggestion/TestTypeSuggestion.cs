namespace Engine.actions.parameterSignatureSuggestion.typeSuggestion {

    public class TestTypeSuggestion : ParameterTypeSuggestion {

        public string SuggestType(string parameterName) {
            return "ZPLU_CL_" + parameterName.Substring(3);
        }

    }
}
