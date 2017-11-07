using SAPFEWSELib;
using System.Collections.Generic;

namespace Engine.actions.parameterSignatureSuggestion {

    public class GuiClassVariableFactory {
        private readonly GuiTableControl table;
        private readonly ClassVariableColumnIndexDefinition definition;

        public GuiClassVariableFactory(GuiTableControl table, ClassVariableColumnNameDefinition definition) {
            this.table = table;
            this.definition = new ClassVariableColumnIndexDefinition(table, definition);
        }

        public List<SuggestionConsumer> CreateParameters2() {
            List<SuggestionConsumer> result = new List<SuggestionConsumer>();
            foreach (GuiTableRow row in table.Rows) {
                result.Add(new GuiClassVariable2(row, definition));
            }
            return result;
        }
    }
}
