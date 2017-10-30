using Engine.actions;
using Engine.controller.hotkeys;
using NUnit.Framework;
using System.Collections.Generic;

namespace Test.controller {

    [TestFixture]
    public class ParameterHashTest {

        [Test]
        public void ActionHashMap() {

            Action action;
            Dictionary<Hotkey, Action> actions = new Dictionary<Hotkey, Action>();

            Hotkey hotkey = new Hotkey(System.Windows.Forms.Keys.D, ModifierKeys.Control, ModifierKeys.Shift);
            actions.Add(hotkey, new ButtonPressAction(""));

            Hotkey hotkey2 = new Hotkey(System.Windows.Forms.Keys.D, ModifierKeys.Control, ModifierKeys.Shift);
            Hotkey hotkey3 = new Hotkey(System.Windows.Forms.Keys.D, ModifierKeys.Shift, ModifierKeys.Control);

            Assert.AreEqual(hotkey.GetHashCode(), hotkey2.GetHashCode());

            //Assert.IsTrue(hotkey.Equals(hotkey2));
            uint shift = (uint)ModifierKeys.Shift;

            Assert.AreEqual(hotkey.GetModifiersUInt(), (uint)ModifierKeys.Shift | (uint)ModifierKeys.Control);
            actions.TryGetValue(hotkey, out action);
            Assert.NotNull(action);

            actions.TryGetValue(hotkey2, out action);
            Assert.NotNull(action);

            actions.TryGetValue(hotkey3, out action);
            Assert.NotNull(action);
        }

        [Test]

        public void HotkeyEquality() {
            Hotkey hotkey = new Hotkey(System.Windows.Forms.Keys.D, ModifierKeys.Control);
            Hotkey hotkey2 = new Hotkey(System.Windows.Forms.Keys.D, ModifierKeys.Control);
            Assert.AreEqual(hotkey, hotkey2);

            hotkey = new Hotkey(System.Windows.Forms.Keys.D, ModifierKeys.Control, ModifierKeys.Shift);
            hotkey2 = new Hotkey(System.Windows.Forms.Keys.D, ModifierKeys.Control, ModifierKeys.Shift);
            Assert.AreEqual(hotkey, hotkey2);

            hotkey = new Hotkey(System.Windows.Forms.Keys.D, ModifierKeys.Shift, ModifierKeys.Control);
            hotkey2 = new Hotkey(System.Windows.Forms.Keys.D, ModifierKeys.Control, ModifierKeys.Shift);
            Assert.AreEqual(hotkey, hotkey2);

            hotkey = new Hotkey(System.Windows.Forms.Keys.D, ModifierKeys.Shift, ModifierKeys.Control);
            hotkey2 = new Hotkey(System.Windows.Forms.Keys.E, ModifierKeys.Control, ModifierKeys.Shift);
            Assert.AreNotEqual(hotkey, hotkey2);

            hotkey = new Hotkey(System.Windows.Forms.Keys.D, ModifierKeys.Shift, ModifierKeys.Control);
            hotkey2 = new Hotkey(System.Windows.Forms.Keys.D, ModifierKeys.Shift);
            Assert.AreNotEqual(hotkey, hotkey2);


        }
    }
}
