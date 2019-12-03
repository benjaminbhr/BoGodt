using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoGodtLibrary
{
    public interface IMasterWindow
    {
        EWindowType GetWindowType();
        void CanWindowOpen(bool canwindowopen);
        bool IsWindowFrosted(bool iswindowfrosted);
    }
}
