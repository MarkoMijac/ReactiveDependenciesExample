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
    public class ClassA
    {
        private IReactor reactor = ReactorRegistry.Instance.GetOrCreateReactor("default");

        private int _x;

        public int X
        {
            get { return _x; }
            set 
            { 
                _x = value;
                reactor.Update(this);
            }
        }

        private int _y;

        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }

        public int Azuriraj_Y()
        {
            //Proizvoljna logika
            return X * 2;
        }

        public ClassA()
        {
            CreateDependencies();
        }

        private void CreateDependencies()
        {
            reactor.Let(() => Y).DependOn(() => X);
        }
    }
}
