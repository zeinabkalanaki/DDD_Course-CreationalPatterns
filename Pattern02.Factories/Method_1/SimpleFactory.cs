using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern02.Factories.Method_1
{
    public interface Icar
    {
        void TurnOn();
        void TurnOff();
    }

    public class BMW : Icar
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

    public class Pride : Icar
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

    public class SimpleFactory
    {
        //this class do not pass "S"
        //چون فقط یک دلیل برای تغییر ندارد 
        //اما اگر کلاس پراید عوض شود مثلا کانستراکتور آن تغییر کند این کلاس هم ناچار به تغییراست
        //this class do not pass "O"
        //چون فقط اگه نوع جدیدی اضافه شد باید تغییر کند

        //مشکل دوم وابستگی ما به یک اینستنس ثابت از کلاس فکتوری

        public static Icar GetInstance(string carName)
        {
            Icar car = null;
            switch (carName)
            {
                case "BMW":
                    car = new BMW();
                    break;
                case "Pride":
                    car = new Pride();
                    break;
            }
            return car;
        }
    }
}
