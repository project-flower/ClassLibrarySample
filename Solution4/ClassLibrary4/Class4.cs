using ClassLibrary1;
using ClassLibrary2;

namespace ClassLibrary4
{
    public class Class4
    {
        public Class2 class2;

        public Class4()
        {
            class2 = new Class2();
            class2.class1 = new Class1();
        }
    }
}
