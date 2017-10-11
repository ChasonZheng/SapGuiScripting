using Engine.text;
using NUnit.Framework;

namespace Test {

    [TestFixture]
    public class RemoveTextBlockTest {

        [Test]
        public void TestToLeft() {

            RemoveTextBlockToLeft remove = new RemoveTextBlockToLeft(new TextBlockFinderToLeft('_'));

            Assert.AreEqual("A_", remove.Remove("A_", 0));
            Assert.AreEqual("_", remove.Remove("A_", 1));
            Assert.AreEqual("A", remove.Remove("A_", 2));
            Assert.AreEqual("AA", remove.Remove("A_A", 2));
            Assert.AreEqual("A_", remove.Remove("A_A", 3));
            Assert.AreEqual("A_A", remove.Remove("A_AA", 3));
            Assert.AreEqual("A_", remove.Remove("A_AA", 4));
            Assert.AreEqual("_A", remove.Remove("_A", 0));
            Assert.AreEqual("A", remove.Remove("_A", 1));
            Assert.AreEqual("_", remove.Remove("_A", 2));

            Assert.AreEqual("A_B", remove.Remove("A_B", 0));
            Assert.AreEqual("_B", remove.Remove("A_B", 1));
            Assert.AreEqual("AB", remove.Remove("A_B", 2));
            Assert.AreEqual("A_", remove.Remove("A_B", 3));

            Assert.AreEqual("AAAA", remove.Remove("AA_AA", 3));
            Assert.AreEqual("_A", remove.Remove("A_A", 1));
            Assert.AreEqual("AA", remove.Remove("A_A", 2));
            Assert.AreEqual("ZPLU_", remove.Remove("ZPLU_CL", 7));
        }

        [Test]
        public void TestToRight() {

            RemoveTextBlockToRight remove = new RemoveTextBlockToRight(new TextBlockFinderToRight('_'));
            Assert.AreEqual("_", remove.Remove("A_", 0));
            Assert.AreEqual("_B", remove.Remove("A_B", 0));
            Assert.AreEqual("A", remove.Remove("A_", 1));
            Assert.AreEqual("AA_", remove.Remove("AA_AA", 3));
            Assert.AreEqual("AA", remove.Remove("A_A", 1));
            Assert.AreEqual("A_", remove.Remove("A_A", 2));
        }

        private void Check() { }

    }
}
