namespace Engine.actions.parameterTypeSuggestion {
    public class MethodParameterSignatureSuggestion : ParameterSignatureSuggestion {

        public void Suggest(string parameterName, SuggestionConsumer consumer) {
            if (parameterName.Length < 2) {
                return;
            }

            switch (parameterName.Substring(0, 1).ToUpper()) {
                case "I":
                    consumer.SetModifier("Importing");
                    break;
                case "E":
                    consumer.SetModifier("Exporting");
                    break;
                case "R":
                    consumer.SetModifier("Returning");
                    consumer.SetCallByValue(true);
                    break;
                case "C":
                    consumer.SetModifier("Changing");
                    break;
            }

            switch (parameterName.Substring(1, 1).ToUpper()) {
                case "V":
                case "S":
                case "T":
                    consumer.SetReferenceType("TYPE");
                    break;
                case "R":
                    consumer.SetReferenceType("TYPE REF TO");
                    break;
            }
        }
    }
}