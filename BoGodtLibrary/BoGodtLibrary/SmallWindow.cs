using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoGodtLibrary
{
    public class SmallWindow : IMasterWindow
    {
        bool IMasterWindow.CanWindowOpen()
        {
            return true;
        }

        EWindowType IMasterWindow.GetWindowType()
        {
            return EWindowType.Small;
        }

        bool IMasterWindow.IsWindowFrosted()
        {
            return false;
        }
    }
}
