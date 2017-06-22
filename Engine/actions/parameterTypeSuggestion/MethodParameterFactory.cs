using System.Collections.Generic;
using SAPFEWSELib;

namespace Engine.actions.parameterTypeSuggestion {
    public class MethodParameterFactory {
        private readonly GuiTableControl tableControl;

        public MethodParameterFactory(GuiTableControl tableControl) {
            this.tableControl = tableControl;
        }

        public List<SapGuiMethodParameter> CreateParameters() {
            GuiTableRow row = null;
            var resultList = new List<SapGuiMethodParameter>();
            var i = 0;
            SapGuiMethodParameter parameter = null;
            do {
                row = tableControl.GetAbsoluteRow(i);
                i++;
                parameter = CreateParameterByRow(row);
                if (parameter != null) {
                    resultList.Add(parameter);
                }
            } while (row !=  null);
            return resultList;
        }

        private SapGuiMethodParameter CreateParameterByRow(ISapTableRowTarget row) {
            GuiComponent parameterNameComponent = row.Item(1);
            GuiTextField parameterName = null;
            try {
                parameterName = (GuiTextField) parameterNameComponent;
            } catch (System.Exception) {
                return null;
            }
            if (parameterName.Text != "") {
                return new SapGuiMethodParameter(
                    (GuiTextField) row.Item(2),
                    (GuiTextField)row.Item(3),
                    (GuiCheckBox)row.Item(4),
                    (GuiTextField)row.Item(5)
                );
            }
            return null;
        }
    }
}