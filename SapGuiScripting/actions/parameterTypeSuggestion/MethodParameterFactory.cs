using System.Collections.Generic;
using SAPFEWSELib;

namespace SapGuiScripting.actions.parameterTypeSuggestion {
    public class MethodParameterFactory {
        private readonly GuiTableControl tableControl;

        public MethodParameterFactory(GuiTableControl tableControl) {
            this.tableControl = tableControl;
        }

        public List<MethodParameter> CreateParameters() {
            GuiTableRow row = null;
            var resultList = new List<MethodParameter>();
            var i = 0;
            MethodParameter parameter = null;

            do {
                row = tableControl.GetAbsoluteRow(i);
                i++;
                parameter = createParameterByRow(row);
                if (parameter != null) {
                    resultList.Add(parameter);
                }
            } while (row !=  null);
            return resultList;
        }

        private MethodParameter createParameterByRow(GuiTableRow row) {
            GuiComponent component = row.Item(1);
            GuiTextField textField = null;
            try {
                 textField = (GuiTextField) component;
            } catch (System.Exception) {
                return null;
            }
            if (textField.Text != "") {

            }
            return null;
        }
    }
}