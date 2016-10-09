using SAPFEWSELib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SapGuiScripting {
    public interface GuiSessionProvider {
        GuiSession GetSession();
    }
}
