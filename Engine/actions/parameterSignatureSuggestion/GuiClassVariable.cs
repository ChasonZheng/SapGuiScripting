using SAPFEWSELib;

namespace Engine.actions.parameterSignatureSuggestion {

    public class GuiClassVariable : SuggestionConsumer {

        private readonly int rowIndex;
        private readonly int nameIndex;
        private readonly int typeIndex;
        private readonly int visibilityIndex;
        private readonly int typingIndex;

        private readonly GuiTableControl table;

        public GuiClassVariable(GuiTableControl table, int rowIndex, int nameIndex, int typeIndex, int visibilityIndex, int typingIndex) {
            this.table = table;
            this.rowIndex = rowIndex;
            this.nameIndex = nameIndex;
            this.typeIndex = typeIndex;
            this.visibilityIndex = visibilityIndex;
            this.typingIndex = typingIndex;
        }

        public void SetType(string type) {
            SetCell(typeIndex, type);
        }

        public void SetVisiblity(VariableVisibility visibility) {
            SetCell(visibilityIndex, visibility.ToString());
        }

        public void SetTyping(VariableTyping typing) {
            SetCell(typingIndex, typing.ToString());
        }

        private void SetCell(int columnIndex, string value) {
            GuiTextField field = table.GetCell(rowIndex, columnIndex) as GuiTextField;
            field.Text = value;
        }
    }
}