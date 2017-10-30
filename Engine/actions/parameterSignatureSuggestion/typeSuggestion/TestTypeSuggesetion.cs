namespace Engine.actions.parameterSignatureSuggestion.typeSuggestion {

    public class TestTypeSuggesetion : ParameterTypeSuggestion {

        public string SuggestType(string parameterName) {
            return "ZPLU_CL_" + parameterName.Substring(3);
        }

    }
}
