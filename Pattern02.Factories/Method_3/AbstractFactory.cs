using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern02.Factories.Method_3
{
    //در دنیای واقعی هر کارخانه چندین دسته ماشین تولید می کند نه یک دسته

    //Pass "O"
    //با اضافه شدن ماشین جدید تغییر اتفاق نمی افتد

    //pass "S"
    //هر متد مسیول ساخت یک ماشین است

    public interface ICar
    {
        void TurnOn();
        void TurnOff();
    }

    public interface IAbstractFactory
    {
        //سه دسته محصول داریم
        ICar Luxtury();
        ICar Cross();
        ICar Sedan();
    }

    public class Pride : ICar
    {
        public void TurnOff()
        {
            throw new NotImplementedException();
        }

        public void TurnOn()
        {
            throw new NotImplementedException();
        }
    }

    public class PrideCross : ICar
    {
        public void TurnOff()
        {
            throw new NotImplementedException();
        }

        public void TurnOn()
        {
            throw new NotImplementedException();
        }
    }

    public class PrideZehdar : ICar
    {
        public PrideZehdar(string zehColor)
        {

        }
        public void TurnOff()
        {
            throw new NotImplementedException();
        }

        public void TurnOn()
        {
            throw new NotImplementedException();
        }
    }

    public class BMW : ICar
    {
        public void TurnOff()
        {
            throw new NotImplementedException();
        }

        public void TurnOn()
        {
            throw new NotImplementedException();
        }
    }

    public class BMW7 : ICar
    {
        public void TurnOff()
        {
            throw new NotImplementedException();
        }

        public void TurnOn()
        {
            throw new NotImplementedException();
        }
    }

    public class BMWX3 : ICar
    {
        public void TurnOff()
        {
            throw new NotImplementedException();
        }

        public void TurnOn()
        {
            throw new NotImplementedException();
        }
    }

    public class BMWFactory : IAbstractFactory
    {
        public ICar Cross()
        {
            return new BMWX3();
        }

        public ICar Luxtury()
        {
            return new BMW7();
        }

        public ICar Sedan()
        {
            return new BMW();
        }
    }

    public class SaipaFactory : IAbstractFactory
    {
        public ICar Cross()
        {
            return new PrideCross();
        }

        public ICar Luxtury()
        {
            return new PrideZehdar("black");
        }

        public ICar Sedan()
        {
            return new Pride();
        }
    }

}
