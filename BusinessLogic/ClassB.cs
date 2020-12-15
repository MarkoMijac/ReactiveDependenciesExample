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
    public class ClassB
    {
        private IReactor reactor = ReactorRegistry.Instance.GetOrCreateReactor("default");

        public int Z { get; set; }

        private int _w;

        public int W
        {
            get { return _w; }
            set 
            { 
                _w = value;
                reactor.Update(this);
            }
        }

        private ClassA _objA;

        public ClassB(ClassA objA)
        {
            _objA = objA;
            CreateDependencies();
        }

        private void CreateDependencies()
        {
            reactor.Let(() => Z).DependOn(() => _objA.X, () => _objA.Y, () => W);
        }

        public int Azuriraj_Z()
        {
            //Proizvoljna logika koja ovisi o parametrima x, y, w.
            return _objA.X + _objA.Y + W;
        }
    }
}
