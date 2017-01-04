using SAPFEWSELib;

namespace SapGuiScripting.actions.parameterTypeSuggestion {
    public class MethodParameterTypeSuggestion : ParameterTypeSuggestion {
        public string GetSuggestion(string parameterName) {
            switch (parameterName.ToUpper()) {
                case "IR_SCENARIO":
                    return "/SNP/TE01_CL_SCENARIO";
                default:
                    return "";
            }
        }
    }
}