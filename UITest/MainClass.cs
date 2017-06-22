using Engine.actions;
using Engine.actions.filters;
using Engine.actions.filters.ruleset;

namespace UITest {
    public class MainClass {
        public static void Main() {
            ButtonPressAction quickSearchAction = new ButtonPressAction("/app/con[0]/ses[0]/wnd[0]/usr/tabsCTS/tabpTAB_MTD/ssubCSS:SAPLSEOD:0253/btnPUSH_FIND");
            ProgramFilter programRuleset = new ProgramFilter("SAPLSEOD");

            ActionFilter filteredAction = new ActionFilter(quickSearchAction, programRuleset);
            HotKeyTest test = new HotKeyTest(filteredAction);
            test.Run();
        }
    }
}