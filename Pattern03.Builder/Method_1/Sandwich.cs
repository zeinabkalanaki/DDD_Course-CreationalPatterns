using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern03.Builder.Method_1
{
    public enum BreadType
    {
        Buget,
        France
    }

    public enum MeetType
    {
        Chicken,
        Pork,
        Beef
    }

    public enum CheezType
    {
        Pitzza,
        Margarit
    }

    public class Sandwich
    {
        private readonly BreadType _breadType;
        private readonly MeetType _meetType;
        private readonly CheezType _cheezType;
        private readonly List<string> _vegtables;

        public Sandwich(
            BreadType breadType,
            MeetType meetType,
            CheezType cheezType,
            List<string> vegtables)
        {
            _breadType = breadType;
            _meetType = meetType;
            _cheezType = cheezType;
            _vegtables = vegtables;
        }

        public void Get()
        {
            Console.WriteLine("Sandwich with");
            Console.WriteLine(_breadType);
            Console.WriteLine(_meetType);
            Console.WriteLine(_cheezType);
            Console.WriteLine(_vegtables);
            Console.WriteLine(String.Join(',', _vegtables));

        }
    }
}
