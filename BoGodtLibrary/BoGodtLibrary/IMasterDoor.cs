using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoGodtLibrary
{
    public interface IMasterDoor
    {
        bool IsBackDoor();
        bool IsFrontDoor();
        Enum Material { get; }

    }
}
