using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonsApp
{
    class MyDelegate
    {
        public void MyDelegate1(int i, string str);

        public static void main()
        {
            MyDelegate delInstance = new MyDelegate1(MyFunction);
            delInstance.BeginInvoke(100, " I am in Delagte Thread", null, null);

            for (int i = 0; i < 100; i++)
                Console.WriteLine("I am in a Main Thread{0}", i);
        }

        public static void MyFunction(int count, string str)
        {
            for (int i = 0; i < count; i++)
                Console.WriteLine(str + "{0}", i);
        }
    }
}
