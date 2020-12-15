using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class ClassC
    {
        private ClassB _objB;

        public int Q { get; set; }
        public int P { get; set; }

        public ClassC(ClassB objB)
        {
            _objB = objB;
        }

        public int Azuriraj_Z()
        {
            if (_objB.W > 10)
            {
                return 10;
            }
            else
            {
                return _objB.W + _objB.Z + P;
            }
        }
    }
}
