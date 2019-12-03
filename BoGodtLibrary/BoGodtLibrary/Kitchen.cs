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
        public void AddWindows()
        {
            if (MaxWindows >= 10)
            {
                throw new System.ArgumentException("Too many windows added!");
            }
            else
            {
                windows.Add(new SmallWindow());
                
                
                MaxWindows++;
            }
        }

        int MaxWindows = 0;


    }

}

