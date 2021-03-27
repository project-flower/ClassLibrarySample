using ClassLibrary1;
using ClassLibrary2;

namespace ClassLibrary3
{
    public class Class3
    {
        public Class2 class2;

        public Class3()
        {
            class2 = new Class2();
            class2.class1 = new Class1();
        }
    }
}
