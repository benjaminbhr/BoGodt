using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoGodtLibrary
{
    public class FrontDoor:MasterDoor
    {
        public override bool IsBackDoor()
        {
            return false;
        }
        public override bool IsFrontDoor()
        {
            return true;
        }
        public override Enum Material => throw new NotImplementedException();
    }
}
