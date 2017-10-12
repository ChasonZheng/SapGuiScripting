using Application;
using Engine.actions;
using Engine.actions.removeTextBlockAction;
using Engine.controller.hotkeys;
using Engine.session;
using NUnit.Framework;
using SAPFEWSELib;
using System.Threading;
using System.Windows.Forms;

namespace UITest {

    [TestFixture]
    public class UITest : Action {

        [Test]
        public void Research() {

            ApplicationConfig config = new ApplicationConfig();

            // Action action = new RemoveTextBlockToLeftAction('_', '/');
            //config.RegisterOnHotKey(action, ModifierKeys.Control, Keys.Back);

            //action = new RemoveTextBlockToRightAction('_', '/');
            //config.RegisterOnHotKey(action, ModifierKeys.Control, Keys.Delete);

            Action action = new SelectTextBlockToLeftAction('_', '/');
            Hotkey hotkey = new Hotkey(Keys.Left, ModifierKeys.Control, ModifierKeys.Shift);
            config.RegisterOnHotKey(action, hotkey);
            config.Start();

        }

        public void Execute(ActionContext context) {

        }

        [Test]
        public void ResearchActiveWindow() {

            Thread.Sleep(500);
            //FirstSessionProvider provider = new FirstSessionProvider();
            GuiSessionProvider provider = new ActiveSessionProvider();

            Assert.IsNotEmpty(provider.GetSession().GetId());
            Assert.IsNotNull(provider.GetSession().GetInFocus());
            Assert.IsNotEmpty(provider.GetSession().GetInFocus().Id);

            Assert.IsNotNull(provider.GetSession().GetInFocus().Id);
            System.Console.WriteLine("Current focus: " + provider.GetSession().GetInFocus().Id);
            System.Console.WriteLine("Did it");
        }

        [Test]
        public void Research2() {

            Thread.Sleep(500);
            //FirstSessionProvider provider = new FirstSessionProvider();
            GuiSessionProvider provider = new ActiveSessionProvider();

            GuiCTextField field = (GuiCTextField)provider.GetSession().FindById("/app/con[0]/ses[0]/wnd[0]/usr/ctxtSEOCLASS-CLSNAME");
            System.Console.WriteLine(field.AccText);
            System.Console.WriteLine(field.AccLabelCollection);
            System.Console.WriteLine(field.DisplayedText);
            System.Console.WriteLine(field.Highlighted);
            GuiFrameWindow window = (GuiFrameWindow)provider.GetSession().FindById("/app/con[0]/ses[0]/wnd[0]");
        }

    }

}
