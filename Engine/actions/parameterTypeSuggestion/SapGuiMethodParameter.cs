using SAPFEWSELib;

namespace Engine.actions.parameterTypeSuggestion {
    public class SapGuiMethodParameter : SuggestionConsumer {
        private readonly GuiTextField typeField;
        private readonly GuiTextField modifierField;
        private readonly GuiCheckBox valueField;
        private readonly GuiTextField referenceTypeField;

        public SapGuiMethodParameter(GuiTextField typeField, GuiTextField modifierField, GuiCheckBox valueField, GuiTextField referenceTypeField) {
            this.typeField = typeField;
            this.modifierField = modifierField;
            this.valueField = valueField;
            this.referenceTypeField = referenceTypeField;
        }

        public void SetType(string type) {
            typeField.Text = type;
        }

        public void SetModifier(string modifier) {
            modifierField.Text = modifier;
        }

        public void SetCallByValue(bool hasCallByValue) {
            valueField.Text = hasCallByValue ? "X" : "";
        }

        public void SetReferenceType(string referenceType) {
            referenceTypeField.Text = referenceType;
        }
    }
}