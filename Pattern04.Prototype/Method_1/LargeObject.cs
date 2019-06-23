using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern04.Prototype.Method_1
{
    public class InnerClass
    {
        public int MyProperty { get; set; } 
    }
    public class LargeObject 
    {
        public LargeObject Clone()
        {
            return (LargeObject)MemberwiseClone(); //shalow copy
        }

        public int MyProperty { get; set; }
        public InnerClass MyInnerClass { get; set; } = new InnerClass();
    }
}
