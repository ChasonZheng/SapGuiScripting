using Engine.text;
using NUnit.Framework;

namespace Test {

    [TestFixture]
    public class RemoveTextBlockTest {

        [Test]
        public void TestToLeft() {

            RemoveTextBlockToLeft remove = new RemoveTextBlockToLeft('_');
            // Assert.AreEqual("/SNP/TE01_CL_", remove.Remove("/SNP/TE01_CL_SCENARIO"));
            Assert.AreEqual("A_", remove.Remove("A_B"));
            Assert.AreEqual("A", remove.Remove("A_"));

            Assert.AreEqual("A_", remove.Remove("A_", 0));
            Assert.AreEqual("A_B", remove.Remove("A_B", 0));

            Assert.AreEqual("A", remove.Remove("A_", 1));
            Assert.AreEqual("A", remove.Remove("A_A", 1));
            Assert.AreEqual("A_", remove.Remove("A_A", 2));
        }

        public void TestToRight() {

            //   TextTransform transform = new RemoveTextBlockToLeft();
            //   Assert.Equals(transform.Transform("/SNP/TE01_CL_SCENARIO"), "/SNP/TE01_CL");
            //   Assert.Equals(transform.Transform("/SNP/TE01_CL_"), "/SNP/TE01_CL");
        }

        private void Check() { }

    }
}
