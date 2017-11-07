namespace Engine.actions.parameterSignatureSuggestion {
    public interface ClassVariableColumnNameDefinition {
        string GetNameColumn();
        string GetTypingColumn();
        string GetVisibilityColumn();
        string GetTypeColumn();
    }

    public class MethodParameterColumnDefinition : ClassVariableColumnNameDefinition {
        public string GetNameColumn() {
            return "VSEOMEPARA-SCONAME";
        }

        public string GetTypeColumn() {
            return "VSEOMEPARA-TYPE";
        }

        public string GetTypingColumn() {
            return "DY_0352-CHA_TYPTYPE";
        }

        public string GetVisibilityColumn() {
            return "DY_0352-CHA_PARDECLTYP";
        }
    }

    public class ClassAttributeColumnDefinition : ClassVariableColumnNameDefinition {
        public string GetNameColumn() {
            return "DY_0252-CPDNAME";
        }

        public string GetTypeColumn() {
            return "VSEOATTRIB-TYPE";
        }

        public string GetTypingColumn() {
            return "DY_0252-CHA_TYPTYPE";
        }

        public string GetVisibilityColumn() {
            return "DY_0252-CHA_ATTDECLTYP";
        }
    }
}
