using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern03.Builder.Method_2
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
        public BreadType breadType;
        public MeetType meetType;
        public CheezType cheezType;
        public List<string> vegtables;
    }

    public class SandwichBuilder
    {
        private readonly SandwichIngrideients sandwichIngrideients;

        // مراحل
        public SandwichBuilder(SandwichIngrideients sandwichIngrideients)
        {
            this.sandwichIngrideients = sandwichIngrideients;

            sandwichIngrideients.SetBread();
            sandwichIngrideients.SetMeet();
            sandwichIngrideients.SetCheeze();
            sandwichIngrideients.SetVegtable();
        }

        public Sandwich Get()
        {
            return sandwichIngrideients.sandwich;
        }
    }

    public abstract class SandwichIngrideients
    {
        //ورودی
        public readonly Sandwich sandwich = new Sandwich();

        public abstract void SetBread();

        public abstract void SetMeet();

        public abstract void SetCheeze();

        public abstract void SetVegtable();

    }

    public class Hamberger : SandwichIngrideients
    {
        public override void SetBread()
        {
            sandwich.breadType = BreadType.Buget;
        }

        public override void SetCheeze()
        {
            sandwich.cheezType = CheezType.Margarit;
        }

        public override void SetMeet()
        {
            sandwich.meetType = MeetType.Beef;
        }

        public override void SetVegtable()
        {
            sandwich.vegtables = new List<string>()
            {
                "Lettus",
                "Onion"
            };
        }
    }

    public class Doner : SandwichIngrideients
    {
        public override void SetBread()
        {
            sandwich.breadType = BreadType.France;
        }

        public override void SetCheeze()
        {
            sandwich.cheezType = CheezType.Pitzza;
        }

        public override void SetMeet()
        {
            sandwich.meetType = MeetType.Pork;
        }

        public override void SetVegtable()
        {
            sandwich.vegtables = new List<string>()
            {
                "Lettus"
            };
        }
    }
}
