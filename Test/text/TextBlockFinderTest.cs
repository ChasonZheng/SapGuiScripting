using Engine.text;
using NUnit.Framework;

namespace Test.text {
    [TestFixture]
    public class TextBlockFinderTest {

        [Test]
        public void TestForUndercoreToLeftWithIndex() {
            TextBlockFinder finder = new TextBlockFinderToLeft('_');

            Assert.AreEqual(-1, finder.GetIndex("A", 0));
            Assert.AreEqual(-1, finder.GetIndex("A", 1));
            Assert.AreEqual(-1, finder.GetIndex("_A", 0));
            Assert.AreEqual(-1, finder.GetIndex("__A", 0));
            Assert.AreEqual(-1, finder.GetIndex("__A", 0));
            Assert.AreEqual(-1, finder.GetIndex("_", 0));
            Assert.AreEqual(0, finder.GetIndex("_", 1));
            Assert.AreEqual(1, finder.GetIndex("__", 2));
            Assert.AreEqual(0, finder.GetIndex("_A", 1));
            Assert.AreEqual(-1, finder.GetIndex("A_", 0));
            Assert.AreEqual(-1, finder.GetIndex("A_", 1));
            Assert.AreEqual(1, finder.GetIndex("A_", 2));
            Assert.AreEqual(1, finder.GetIndex("A_", 2));
            Assert.AreEqual(-1, finder.GetIndex("__A", 0));
            Assert.AreEqual(0, finder.GetIndex("__A", 1));
            Assert.AreEqual(1, finder.GetIndex("A_A", 2));
            Assert.AreEqual(1, finder.GetIndex("__A", 2));
            Assert.AreEqual(1, finder.GetIndex("_A", 2));
            Assert.AreEqual(-1, finder.GetIndex("A_AA", 1));
            Assert.AreEqual(1, finder.GetIndex("A_AA", 2));
            Assert.AreEqual(2, finder.GetIndex("A_AA", 3));
            Assert.AreEqual(2, finder.GetIndex("A_AA", 4));
            Assert.AreEqual(2, finder.GetIndex("A_AA", 5));
            Assert.AreEqual(-1, finder.GetIndex("AAA", 3));
            Assert.AreEqual(-1, finder.GetIndex("A____A", 1));
            Assert.AreEqual(1, finder.GetIndex("A____A", 2));
            Assert.AreEqual(2, finder.GetIndex("A____A", 3));
            Assert.AreEqual(3, finder.GetIndex("A____A", 4));

        }

        [Test]
        public void TestForUndercoreToRightWithIndex() {
            TextBlockFinder finder = new TextBlockFinderToRight('_');

            Assert.AreEqual(1, finder.GetIndex("A", 0));
            Assert.AreEqual(1, finder.GetIndex("_", 0));

            Assert.AreEqual(2, finder.GetIndex("_A", 1));
            Assert.AreEqual(2, finder.GetIndex("__", 1));

            Assert.AreEqual(1, finder.GetIndex("A", 0));
            Assert.AreEqual(1, finder.GetIndex("A", 1));
            Assert.AreEqual(1, finder.GetIndex("A", 2));
            Assert.AreEqual(1, finder.GetIndex("A_", 0));
            Assert.AreEqual(1, finder.GetIndex("_A", 0));
            Assert.AreEqual(2, finder.GetIndex("_A", 1));

            Assert.AreEqual(3, finder.GetIndex("_A_A", 2));

            Assert.AreEqual(1, finder.GetIndex("__", 0));
            Assert.AreEqual(2, finder.GetIndex("__", 1));

            Assert.AreEqual(1, finder.GetIndex("__A", 0));
            Assert.AreEqual(2, finder.GetIndex("__A", 1));
            Assert.AreEqual(3, finder.GetIndex("__A", 2));

            Assert.AreEqual(1, finder.GetIndex("A__A", 0));
            Assert.AreEqual(2, finder.GetIndex("A__A", 1));
            Assert.AreEqual(3, finder.GetIndex("A__A", 2));
            Assert.AreEqual(4, finder.GetIndex("A__A", 3));
            Assert.AreEqual(4, finder.GetIndex("A__A", 4));

            Assert.AreEqual(5, finder.GetIndex("A__AA", 4));
            Assert.AreEqual(5, finder.GetIndex("A__AA", 5));

        }

        [Test]
        public void TestForMultipleToLeft() {

            TextBlockFinder finder = new TextBlockFinderToLeft(new char[] { '/', '_' });
            Assert.AreEqual(-1, finder.GetIndex("//", 0));
            Assert.AreEqual(-1, finder.GetIndex("/_", 0));
            Assert.AreEqual(0, finder.GetIndex("/_", 1));
            Assert.AreEqual(1, finder.GetIndex("/_", 2));

        }

        [Test]
        public void TestForMultipleToRight() {

            TextBlockFinder finder = new TextBlockFinderToRight(new char[] { '/', '_' });
            Assert.AreEqual(1, finder.GetIndex("//", 0));
            Assert.AreEqual(1, finder.GetIndex("/_", 0));
            Assert.AreEqual(2, finder.GetIndex("/_", 1));

        }
    }
}
