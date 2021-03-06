﻿using Engine.actions;
using Engine.session;
using SAPFEWSELib;
using Moq;
using NUnit.Framework;

namespace Test.actions {
    [TestFixture]
    public class LoginTest {
        [Test]
        public void TestLogin() {

            var contextMock = new Mock<ActionContext>();
            FirstSessionProvider sessionProvider = new FirstSessionProvider();
            contextMock.Setup(context => context.GetSession()).Returns(sessionProvider.GetSession());
            var textMock = new Mock<TextProvider>();

            //User
            textMock.Setup(provider => provider.GetText()).Returns("plunz");
            new InputSetTextAction(textMock.Object, "/app/con[0]/ses[0]/wnd[0]/usr/txtRSYST-BNAME").Execute(contextMock.Object);

            //PW
            textMock.Setup(provider => provider.GetText()).Returns("epic321");
            new InputSetTextAction(textMock.Object, "/app/con[0]/ses[0]/wnd[0]/usr/pwdRSYST-BCODE").Execute(contextMock.Object);

            //Login
            new ButtonPressAction("/app/con[0]/ses[0]/wnd[0]/tbar[0]/btn[0]").Execute(contextMock.Object);

        }
    }
}