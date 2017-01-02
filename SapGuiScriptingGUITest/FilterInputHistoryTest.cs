using SapGuiScripting.actions;
using SapGuiScriptingTest;
using Xunit;

namespace SapGuiScriptingGUITest
{
    public class FilterInputHistoryTest : TextProvider
    {
        public static void Main() {
            FilterInputHistoryTest test = new FilterInputHistoryTest();
            InputSetTextAction action = new InputSetTextAction(test, "/app/con[0]/ses[0]/wnd[0]/usr/lblRSYST-BNAME");
            HotKeyTest test2 = new HotKeyTest(action);
            test2.Run();
        }

        public string GetText()
        {
            return "yolo";
        }
    }
}
