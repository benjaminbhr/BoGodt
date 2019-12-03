using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoGodtLibrary
{
    public class LargeWindow : IMasterWindow
    {
        public void CanWindowOpen(bool canwindowopen)
        {
        }

        public EWindowType GetWindowType()
        {
            return EWindowType.Large;
        }

        public bool IsWindowFrosted(bool iswindowfrosted)
        {
            return iswindowfrosted;
        }
    }
}
