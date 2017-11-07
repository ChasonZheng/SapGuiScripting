using SAPFEWSELib;

namespace Engine.actions.parameterSignatureSuggestion {

    public class ClassVariableColumnIndexDefinition {

        private readonly int typingIndex = 0;
        private readonly int typeIndex = 0;
        private readonly int visibilityIndex = 0;
        private readonly int nameIndex = 0;

        public ClassVariableColumnIndexDefinition(GuiTableControl table, ClassVariableColumnNameDefinition definition) {

            for (int i = 0; i < table.Columns.Count; i++) {
                GuiVComponent component = table.GetCell(i, 0);
                string columnName = component.Name;
                if (columnName.Equals(definition.GetTypingColumn())) {
                    typingIndex = i;
                }
                if (columnName.Equals(definition.GetTypingColumn())) {
                    typeIndex = i;
                }
                if (columnName.Equals(definition.GetTypingColumn())) {
                    visibilityIndex = i;
                }
                if (columnName.Equals(definition.GetTypingColumn())) {
                    nameIndex = i;
                }
            }
        }

        public int GetNameColumn() {
            return nameIndex;
        }

        public int GetTypingColumn() {
            return typingIndex;
        }
        public int GetVisibilityColumn() {
            return visibilityIndex;
        }

        public int GetTypeColumn() {
            return typingIndex;
        }


    }
}
