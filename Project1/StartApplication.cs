﻿using System.Windows.Forms;
using SapGuiHotkeysApplication.hotkey;
using SapGuiScripting.actions;
using SapGuiScripting.actions.filters;
using SapGuiScripting.actions.filters.ruleset;

namespace SapGuiHotkeysApplication {
    public class StartApplication {
        public static void Main(string[] args) {
            ApplicationConfig config = new ApplicationConfig();


            ButtonPressAction quickSearchAction = new ButtonPressAction("/app/con[0]/ses[0]/wnd[0]/usr/tabsCTS/tabpTAB_MTD/ssubCSS:SAPLSEOD:0253/btnPUSH_FIND");
            ProgramFilter programRuleset = new ProgramFilter("SAPLSEOD");

            ActionFilter filteredAction = new ActionFilter(quickSearchAction, programRuleset);

            config.RegisterOnHotKey(filteredAction, ModifierKeys.Control, Keys.D);
            config.Start();

        }
    }
}