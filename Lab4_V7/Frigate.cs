using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_V7
{
    public class Frigate : Warship
    {
        public Frigate (int cap, int pas, int NumOfWeapons) : base(cap, pas, NumOfWeapons)
        {

        }

        public override void BOOM()
        {
            base.BOOM();
        }

   
    }
}
