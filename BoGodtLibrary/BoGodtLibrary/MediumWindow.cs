using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoGodtLibrary
{
    public class MediumWindow : IMasterWindow
    {
        bool IMasterWindow.CanWindowOpen()
        {
            return true;
        }

        EWindowType IMasterWindow.GetWindowType()
        {
            return EWindowType.Medium;
        }

        bool IMasterWindow.IsWindowFrosted()
        {
            return false;
        }
    }
}
