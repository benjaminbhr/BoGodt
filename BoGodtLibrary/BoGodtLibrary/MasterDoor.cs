using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoGodtLibrary
{
    public abstract class MasterDoor:IMasterDoor
    {
        public abstract bool IsBackDoor();
        public abstract bool IsFrontDoor();
        public abstract Enum Material { get; }
    }
}
