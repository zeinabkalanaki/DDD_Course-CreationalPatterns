
namespace Pattern03.Builder
{
    class Program
    {
        //در فاکتوری راجع به ابسترکشن صحبت می گردیم(فقط با آی کار کارمی کردیم) فقط یه ماشین می خواستیم تا از خواص عمومی (نوع مهم نبود فقط روشن و خاموش شود) آن استفاده کنیم
        //کلاس بزرگی که ورودی های زیادی دارد
        //در ساندویچی ما جزییات رانمی گوییم فقط می گوییم دونر می خوام
        // و بسته به نوع ورودی خروجی متفاوت است
        // برای ساخت نمونه ترتیب مراحل ساخت نمونه آن  مهم است اول باید نون بذاریم بعد گوشت و ..

        static void Main(string[] args)
        {
            //Method 1
            Method_1.Sandwich sandwich = 
                new Method_1.Sandwich(Method_1.BreadType.Buget,
                                      Method_1.MeetType.Chicken,
                                      Method_1.CheezType.Margarit,
                                      new System.Collections.Generic.List<string>() { "Lettus" } );

            //var hambergur =  sandwich.Get();

            //Method 2
            //ورودی ها از مراحل جدا شده است
            Method_2.SandwichBuilder sandwichBuilder1 = new Method_2.SandwichBuilder(new Method_2.Hamberger());
            Method_2.Sandwich hambergur = sandwichBuilder1.Get();

            Method_2.SandwichBuilder sandwichBuilder2 = new Method_2.SandwichBuilder(new Method_2.Doner());
            Method_2.Sandwich doner = sandwichBuilder2.Get();

            System.Console.ReadKey();

        }
    }
}
