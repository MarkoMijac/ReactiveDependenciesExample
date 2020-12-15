using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReframeCore;
using ReframeCore.Factories;
using ReframeCoreFluentAPI;

namespace BusinessLogic
{
    public class ClassC
    {
        private IReactor reactor = ReactorRegistry.Instance.GetReactor("default");

        private ClassB _objB;

        private int _q;

        public int Q
        {
            get { return _q; }
            set { _q = value; }
        }

        private int _p;

        public int P
        {
            get { return _p; }
            set { _p = value; }
        }

        public ClassC(ClassB objB)
        {
            _objB = objB;
            CreateDependencies();
        }

        private void CreateDependencies()
        {
            reactor.Let(() => Q).DependOn(() => _objB.W, () => _objB.Z, () => P);
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
