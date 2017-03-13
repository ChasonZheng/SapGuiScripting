using SapGuiScripting.actions.parameterTypeSuggestion;
using SAPFEWSELib;

namespace SapGuiScripting.actions {
    public class ParameterTypeSuggestionAction : Action {


        public void Execute(ActionContext context) {
            int index = GetCurrentIndex(context);
            GuiTextField typeField = (GuiTextField) context.GetSession().FindById("abc");
            GuiTextField modifierField = (GuiTextField)context.GetSession().FindById("abc"); ;
            GuiCheckBox valueField = (GuiCheckBox) context.GetSession().FindById("abc"); ;
            GuiTextField referenceTypeField = (GuiTextField)context.GetSession().FindById("abc"); ;
            SapGuiMethodParameter parameter = new SapGuiMethodParameter(
                typeField,
                modifierField,
                valueField,
                referenceTypeField
            );
            string parameterName = "ir_scenario";
            new MethodParameterSignatureSuggestion().Suggest(parameterName, parameter);
        }

        private int GetCurrentIndex(ActionContext context) {

            return 0;
            context.GetSession();
        }
    }
}