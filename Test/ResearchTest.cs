﻿using Engine.actions;
using Engine.controller.hotkeys;
using NUnit.Framework;
using System.Collections.Generic;
using Action = Engine.actions.Action;

namespace Test {

    [TestFixture]
    public class ResearchTest {

        [Test]
        public void Research() {

            // string text = "/SNP/TE01_CL_SCENARIO";
            // string result = text.Substring(text.IndexOfAny(new char[] { '_' }));
            //   Assert.AreEqual(result, "/SNP/TE01_CL_");
            Assert.AreEqual(2, "ABBC".LastIndexOfAny(new char[] { 'B' }, "ABBC".Length - 1 - 0));
        }

        [Test]
        public void Research2() {

            Action action;
            Dictionary<Hotkey, Action> actions = new Dictionary<Hotkey, Action>();

            Hotkey hotkey = new Hotkey(ModifierKeys.Control, System.Windows.Forms.Keys.D);
            actions.Add(hotkey, new ButtonPressAction(""));

            Hotkey hotkey2 = new Hotkey(ModifierKeys.Control, System.Windows.Forms.Keys.D);

            Assert.AreEqual(hotkey.GetHashCode(), hotkey2.GetHashCode());

            Assert.IsTrue(hotkey.Equals(hotkey2));


            actions.TryGetValue(hotkey, out action);
            Assert.NotNull(action);

            actions.TryGetValue(hotkey2, out action);
            Assert.NotNull(action);
        }
    }
}