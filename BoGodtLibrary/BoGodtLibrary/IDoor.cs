using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoGodtLibrary
{
    interface IDoor
    {
        EDoorType GetDoorType();
        EDoorMaterial GetDoorMaterial();
        EColor GetColor();
        bool IsLockable();
    }
}
