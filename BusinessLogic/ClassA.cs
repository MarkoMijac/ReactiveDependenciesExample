using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class ClassA
    {
        private int _x;

        public int X
        {
            get { return _x; }
            set { _x = value; }
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
    }
}
