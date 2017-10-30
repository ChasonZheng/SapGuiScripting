using Application.ui.config;
using Engine.actions;
using Engine.actions.filters;
using Engine.actions.filters.ruleset;
using Engine.controller.hotkeys;
using System.Windows.Forms;

//using Engine.actions;
//using Engine.actions.filters;
//using Engine.actions.filters.ruleset;

namespace Application {
    public class StartApplication {
        public static void Main(string[] args) {
            ApplicationConfig config = new ApplicationConfig();



            ButtonPressAction quickSearchAction = new ButtonPressAction("/usr/tabsCTS/tabpTAB_MTD/ssubCSS:SAPLSEOD:0253/btnPUSH_FIND");
            ProgramFilter programRuleset = new ProgramFilter("SAPLSEOD");

            ActionFilter filteredAction = new ActionFilter(quickSearchAction, programRuleset);

            config.RegisterOnHotKey(filteredAction, ModifierKeys.Control, Keys.D);
            config.Start();

        }
    }
}