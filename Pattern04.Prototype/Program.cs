using System;

namespace Pattern04.Prototype
{
    class Program
    {
        //زمانی که یک کلاس بزرگ داریم و نمونه سازی از آن سخت است
        //یک بار از آن نمونه ساخته و دفعات بعد از همان یک نمونه ساخته شده کپی می کنیم
        static void Main(string[] args)
        {
            //Method 1 
            //copy all member execpt of static and private member
            //is shallow copy just copy value type member and share refrence Type member between instances

            Method_1.LargeObject largeObject = new Method_1.LargeObject();

            var instance1 = largeObject.Clone();
            instance1.MyProperty++;
            instance1.MyInnerClass.MyProperty++;

            Console.WriteLine("instance1.MyProperty : " + instance1.MyProperty);
            Console.WriteLine("instance1.MyInnerClass.MyProperty : " + instance1.MyInnerClass.MyProperty);

            var instance2 = largeObject.Clone();
            instance2.MyProperty++;
            instance2.MyInnerClass.MyProperty++;

            Console.WriteLine("instance2.MyProperty : " + instance2.MyProperty);
            Console.WriteLine("instance2.MyInnerClass.MyProperty : " + instance2.MyInnerClass.MyProperty);

            var instance3 = largeObject.Clone();
            instance3.MyProperty++;
            instance3.MyInnerClass.MyProperty++;

            Console.WriteLine("instance3.MyProperty : " + instance3.MyProperty);
            Console.WriteLine("instance3.MyInnerClass.MyProperty : " + instance3.MyInnerClass.MyProperty);

            Console.ReadLine();
        }
    }
}
