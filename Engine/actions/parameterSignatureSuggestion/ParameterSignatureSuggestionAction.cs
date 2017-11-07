using SAPFEWSELib;

namespace Engine.actions.parameterSignatureSuggestion {
    public class ParameterTypeSuggestionAction : Action {


        public void Execute(ActionContext context) {
            int index = GetCurrentIndex(context);
            GuiTextField typeField = (GuiTextField)context.GetSession().FindById("abc");
            GuiTextField modifierField = (GuiTextField)context.GetSession().FindById("abc"); ;
            GuiCheckBox valueField = (GuiCheckBox)context.GetSession().FindById("abc"); ;
            GuiTextField referenceTypeField = (GuiTextField)context.GetSession().FindById("abc"); ;
            //   GuiClassVariable parameter = new GuiClassVariable(
            //         typeField,
            //        modifierField,
            //         valueField,
            //        referenceTypeField
            //     );
            string parameterName = "ir_scenario";
            //new MethodParameterSignatureSuggestion().Suggest(parameterName, parameter);
        }

        private int GetCurrentIndex(ActionContext context) {

            return 0;
            context.GetSession();
        }
    }
}