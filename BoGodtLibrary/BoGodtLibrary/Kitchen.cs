using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoGodtLibrary
{
    public class Kitchen : MasterRoom
    {
        public override ERoomType GetRoomType()
        {
            return ERoomType.Kitchen;
        }
        public override bool IsNew()
        {
            return true;
        }

    }

}

