using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoGodtLibrary
{
    public class MediumWindow : IMasterWindow
    {
        public void CanWindowOpen(bool canwindowopen)
        {
        }

        public EWindowType GetWindowType()
        {
            return EWindowType.Medium;
        }

        public bool IsWindowFrosted(bool iswindowfrosted)
        {
            return iswindowfrosted;
        }
    }
}
