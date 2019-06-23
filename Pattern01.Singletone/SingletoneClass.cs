using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern01.Singletone
{
    public class SingletoneClass
    {
        private SingletoneClass() //-->avoid creating instance
        {

        }

        private static readonly SingletoneClass _Instance = new SingletoneClass();
        public static SingletoneClass Instance
        {
            get
            {
                return _Instance;
            }
        }
    }
}
