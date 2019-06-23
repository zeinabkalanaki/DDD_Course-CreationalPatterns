using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern04.Prototype.Method_2
{
    public interface ICloneable<T>
    {
        T Clone();
    }
    public class InnerClass
    {
        public int MyProperty { get; set; }
    }
    public class LargeObject : ICloneable<LargeObject>
    {
        public int MyProperty { get; set; }
        public InnerClass MyInnerClass { get; set; } = new InnerClass();

        public LargeObject Clone()
        {
            //For deep copy must serialize
            return (LargeObject)MemberwiseClone();
        }

       
    }
}
