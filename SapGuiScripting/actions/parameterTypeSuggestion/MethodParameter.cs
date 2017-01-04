using SAPFEWSELib;

namespace SapGuiScripting.actions.parameterTypeSuggestion {
    public class MethodParameter {
        private readonly GuiTextField NameField;
        private readonly GuiTextField TypeField;
        private readonly GuiTextField ModifierField;
        private readonly GuiTextField ValueField;
        private readonly GuiTextField ReferenceTypeField;

        public MethodParameter(GuiTextField nameField, GuiTextField typeField, GuiTextField modifierField, GuiTextField valueField, GuiTextField referenceTypeField) {
            NameField = nameField;
            TypeField = typeField;
            ModifierField = modifierField;
            ValueField = valueField;
            ReferenceTypeField = referenceTypeField;
        }

        public void Evaluate() {
            EvaluateSignature();
        }

        private void EvaluateSignature() {
            if (NameField.Text.Length < 2) {
                return;
            }
            switch (NameField.Text.Substring(0, 1).ToUpper()) {
                case "I":
                    ModifierField.Text = "Importing";
                    break;
                case "E":
                    ModifierField.Text = "Exporting";
                    break;
                case "R":
                    ModifierField.Text = "Returning";
                    break;
                case "C":
                    ModifierField.Text = "Changing";
                    break;
            }

            switch (NameField.Text.Substring(1, 1).ToUpper()) {
                case "V":
                case "S":
                case "T":
                    ModifierField.Text = "TYPE";
                    ValueField.Text = "";
                    break;
                case "R":
                    ReferenceTypeField.Text = "TYPE REF TO";
                    ValueField.Text = "X";
                    break;
            }
        }
    }
}