using Engine.actions.parameterSignatureSuggestion;
using Engine.actions.parameterSignatureSuggestion.typeSuggestion;
using Engine.session;
using NUnit.Framework;
using SAPFEWSELib;
using System.Collections.Generic;
using System.Linq;

namespace UITest {

    [TestFixture]
    class MethodParameterFactoryTest {

        [Test]
        public void CreateParameters() {
            FirstSessionProvider provider = new FirstSessionProvider();
            string id = "/app/con[0]/ses[0]/wnd[0]/usr/tabsCTS/tabpTAB_MTD/ssubCSS:SAPLSEOD:0352/tblSAPLSEODPC";


            GuiClassVariableFactory factory = new GuiClassVariableFactory(
                provider.GetSession().FindById(id) as GuiTableControl,
                new MethodParameterColumnDefinition()
            );
            List<SuggestionConsumer> list = factory.CreateParameters2();
            System.Console.WriteLine(list.Count);

            ParameterSignatureSuggestion suggestion = new MethodParameterSignatureSuggestion(new TestTypeSuggestion());

            suggestion.Suggest("IR_COMPONENT", list.ElementAt(5));

        }

    }
}
