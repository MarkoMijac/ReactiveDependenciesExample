using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class ClassB
    {
        public int Z { get; set; }
        public int W { get; set; }

        private ClassA _objA;

        public ClassB(ClassA objA)
        {
            _objA = objA;
        }

        public int Azuriraj_Z()
        {
            //Proizvoljna logika koja ovisi o parametrima x, y, w.
            return _objA.X + _objA.Y + W;
        }
    }
}
