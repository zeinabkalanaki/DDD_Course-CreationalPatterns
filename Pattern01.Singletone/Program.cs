using System;

namespace Pattern01.Singletone
{
    class Program
    {
        static void Main(string[] args)
        {
            var instance = SingletoneClass.Instance;
        }
    }
}
