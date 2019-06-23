using System;

namespace Pattern02.Factories
{
   

    class Program
    {
        

        static void Main(string[] args)
        {
            //wrong usage
            //if (true)
            //{
            //    Icar car = new BMW();
            //}
            //else
            //{
            //    Icar car = new Pride();
            //}

            //Method 1
            Method_1.Icar pride = Method_1.SimpleFactory.GetInstance("Pride");
            pride.TurnOn();
            Method_1.Icar bmw = Method_1.SimpleFactory.GetInstance("BMW");
            bmw.TurnOn();

            //Method 2
            var carFactory = new Method_2.BMWFactoryMethod();
            var car = carFactory.CreateInstance();
            car.TurnOn();

            //Method 3
            var saipaFactory = new Method_3.SaipaFactory();
            var saipaCar = saipaFactory.Luxtury();
            saipaCar.TurnOn();
        }
    }
}
