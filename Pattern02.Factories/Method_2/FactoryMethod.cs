using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern02.Factories.Method_2
{
    //مث متد قبل دیگر به یک نوع خاص فکتوری واسته نیستیم
    //و نسخه های مختلفی از فکتوری داریم
    //و می توانیم بسته به لاجیک این ایترفیس را اینجکت کنیم به برنامه

    //can pass "S"
    //دیگر یک تابع وظیفه ایجاد نمونه از کل ماشین ها را ندارد
    //کلاس پراید فاکتوری مسیول نمونه سازی از پراید است و باتغییر پراید فقط آن تغییر می کند

    //can pass "O"
    //اگر یگ ماشین جدید اضافه شود بقیه دست نمی خورد فقط یک فاکتوری جدید برایش می سازیم

    public interface Icar
    {
        void TurnOn();
        void TurnOff();
    }

    public interface ICarFactoryMethod
    {

        Icar CreateInstance();
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

    public class PrideFactoryMethod : ICarFactoryMethod
    {
        public Icar CreateInstance()
        {
            return new Pride();
        }
    }

    public class BMWFactoryMethod : ICarFactoryMethod
    {
        public Icar CreateInstance()
        {
            return new BMW();
        }
    }

}
