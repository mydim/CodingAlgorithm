
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingAlgorithm.Other
{
    public class Matrix<T> where T : new()
    {
        public static int count = 0;
        public T[,] values;

        public Matrix()
        {
            count++;
        }
    }

    public static class MatrixExtension
    {
        public static T getCalcResult<T>(this Matrix<T> mat) where T : new()
        {
            T result = new T();
            return result;
        }
    }

    public static class A
    {
        //public static T ReplaceChar<T>(this T value, string charToReplace) where T : new()
        //{
        //    return new T(value.ToString().Replace(charToReplace, "_"));
        //}
        public static void Meth()
        {
            Matrix<int> m = new Matrix<int>();
            int aNumber = m.getCalcResult();
            Console.WriteLine(aNumber); //outputs "0"

        }
    }

    public class TestClass
    {

        



        public static void RunCode()
        {
            //var a1 = 1;
            //a1.ReplaceChar("1");


            var a = new A();
            B b = new B();
            C c = new C();

            a.Test(); // output --> "A::Test()"
            b.Test(); // output --> "B::Test()"
            c.Test(); // output --> "C::Test()"

            a = new B();
            a.Test(); // output --> "A::Test()"

            b = new C();
            b.Test(); // output --> "B::Test()"

            Console.ReadKey();
        }


        class A
        {
            public virtual void Test() { Console.WriteLine("A::Test()"); }
        }

        class B : A
        {
            public override void Test() { Console.WriteLine("B::Test()"); }
        }

        class C : B
        {
            public void Test() { Console.WriteLine("C::Test()"); }
        }

    }
}
