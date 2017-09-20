using Microsoft.VisualStudio.TestTools.UnitTesting;
using Engine.text;
namespace Test {
    [TestClass]
    public class RemoveTextBlockTest {

        [TestMethod]
        public void Test() {
             
            TextTransform transform = new RemoveTextBlock();
            Assert.Equals(transform.Transform("/SNP/TE01_CL_SCENARIO"), "/SNP/TE01_CL");
            Assert.Equals(transform.Transform("/SNP/TE01_CL_"), "/SNP/TE01_CL");
        }

        private void Check() { }

    }
}
