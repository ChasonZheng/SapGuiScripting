using Engine.actions.parameterSignatureSuggestion.typeSuggestion;
using Engine.actions.parameterTypeSuggestion;
using NUnit.Framework;

namespace Test.parameterSignatureSuggestion {

    [TestFixture]
    public class ParameterSignatureSuggestionTest : SuggestionConsumer {

        private bool callByValue;
        private ParameterModifier modifier;
        private ParameterReference reference;
        private string type;


        [Test]
        public void ParameterSuggestion() {
            ParameterSignatureSuggestion suggestion = new MethodParameterSignatureSuggestion(null);
            callByValue = false;
            modifier = ParameterModifier.IMPORTITNG;
            reference = ParameterReference.TYPE_REF_TO;
            type = "ZPLU_CL_SCENARIO";
            suggestion.Suggest("ir_scenario", this);
        }

        public void SetCallByValue(bool hasCallByValue) {
            Assert.AreEqual(callByValue, hasCallByValue);
        }

        public void SetModifier(ParameterModifier modifier) {
            Assert.AreEqual(this.modifier, modifier);
        }

        public void SetReferenceType(ParameterReference referenceType) {
            Assert.AreEqual(this.reference, referenceType);
        }

        public void SetType(string type) {
            Assert.AreEqual(this.type, type);
        }

    }
}
