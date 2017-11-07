using SAPFEWSELib;

namespace Engine.actions.parameterSignatureSuggestion {

    public class GuiClassVariable2 : SuggestionConsumer {

        private readonly GuiTableRow row;
        private readonly int nameIndex;
        private readonly int typeIndex;
        private readonly int visibilityIndex;
        private readonly int typingIndex;


        public GuiClassVariable2(GuiTableRow row, GuiTableControl table, ClassVariableColumnNameDefinition definition) :
            this(row, new ClassVariableColumnIndexDefinition(table, definition)) {
        }

        public GuiClassVariable2(GuiTableRow row, ClassVariableColumnIndexDefinition definition) :
            this(row,
                definition.GetNameColumn(),
                definition.GetTypeColumn(),
                definition.GetVisibilityColumn(),
                definition.GetTypingColumn()
            ) {
        }

        public GuiClassVariable2(GuiTableRow row, int nameIndex, int typeIndex, int visibilityIndex, int typingIndex) {
            this.row = row;
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
            GuiTextField field = row.ElementAt(columnIndex) as GuiTextField;
            field.Text = value;
        }
    }
}