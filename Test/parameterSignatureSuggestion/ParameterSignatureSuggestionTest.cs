using Engine.actions.parameterTypeSuggestion;
using NUnit.Framework;

namespace Test.parameterSignatureSuggestion {
    [TestFixture]
    public class ParameterSignatureSuggestionTest : SuggestionConsumer {
        private string type;
        private string modifier;
        private string referenceType;
        private bool hasCallByValue;

        [Test]
        public void TestParameterSuggestion() {
            ParameterSignatureSuggestion suggestion = new MethodParameterSignatureSuggestion();
            suggestion.Suggest("A", this);
   //         Xunit.Assert.Null(type);
    //        Xunit.Assert.Null(modifier);
     //       Xunit.Assert.Null(referenceType);
    //        Xunit.Assert.False(hasCallByValue);

            suggestion.Suggest("ir_SCENARIO", this);
    //        Xunit.Assert.Null(type);
    //        Xunit.Assert.Equal(modifier, "Importing");
     //       Xunit.Assert.Equal(referenceType, "TYPE REF TO");
      //      Xunit.Assert.False(hasCallByValue);

            suggestion.Suggest("rt_SCENARIO", this);
        //    Xunit.Assert.Null(type);
       //     Xunit.Assert.Equal(modifier, "Returning");
       //     Xunit.Assert.Equal(referenceType, "TYPE");
        //    Xunit.Assert.True(hasCallByValue);

            suggestion.Suggest("rr", this);
        //    Xunit.Assert.Null(type);
        //    Xunit.Assert.Equal(modifier, "Returning");
        //    Xunit.Assert.Equal(referenceType, "TYPE REF TO");
        //    Xunit.Assert.True(hasCallByValue);

        }

        public void SetType(string type) {
            this.type = type;
        }

        public void SetModifier(string modifier) {
            this.modifier = modifier;

        }

        public void SetCallByValue(bool hasCallByValue) {
            this.hasCallByValue = hasCallByValue;
        }

        public void SetReferenceType(string referenceType) {
            this.referenceType = referenceType;

        }
    }
}