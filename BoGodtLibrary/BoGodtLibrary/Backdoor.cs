using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoGodtLibrary
{
    public class Backdoor:MasterDoor
    {
        public override bool IsBackDoor()
        {
            return true;
        }
        public override bool IsFrontDoor()
        {
            return false;
        }
        public override Enum Material => throw new NotImplementedException();
    }
}
