using Application;
using Engine.actions;
using Engine.actions.removeTextBlockAction;
using Engine.controller.hotkeys;
using Engine.session;
using NUnit.Framework;
using System.Threading;
using System.Windows.Forms;

namespace UITest {

    [TestFixture]
    public class UITest : Action {

        [Test]
        public void Research() {

            Action action = new RemoveTextBlockToLeftAction('_');
            ApplicationConfig config = new ApplicationConfig();
            config.RegisterOnHotKey(action, ModifierKeys.Control, Keys.D);
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

    }

}
