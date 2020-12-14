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

        public int Izracunaj_Q(int w, int z, int p)
        {
            if (w > 10)
            {
                return 10;
            }
            else
            {
                return w + z + p;
            }
        }
    }
}
