using Xunit;
using Engine.text;
namespace Test {
    class RemoveTextBlockTest {

        [Fact]
        public void Test() {
             
            TextTransform transform = new RemoveTextBlock();
            Assert.Equal(transform.Transform("/SNP/TE01_CL_SCENARIO"), "/SNP/TE01_CL");
        }


        private void Check() { }

    }
}
