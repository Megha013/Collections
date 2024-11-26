//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Collections
//{
//    public class GenericDemo<T>
//    {
//        private T data;
//        public void Add(T data)
//        {
//            this.data = data;
//        }
//        public T Get()
//        {
//            return this.data;
//        }
//    }
//    public class Program
//    {
//        static void Swap<T>(T a,T b)
//        {
//            T temp;
//            temp = a;
//            a = b;
//            b = temp;
//            Console.WriteLine($"a={a}, b={b}");
//        }
//        static void Main(string[] args)
//        {
//            GenericDemo<int> g1 = new GenericDemo<int>();
//            g1.Add(10);
//            Console.WriteLine(g1.Get());

//            GenericDemo<string> g2 = new GenericDemo<string>();
//            g2.Add("Pune");
//            Console.WriteLine(g2.Get());

//            GenericDemo<Product> g3 = new GenericDemo<Product>();
//            g2.Add("Pune");
//            Console.WriteLine(g3.Get());

//            Swap<int>(10, 20);
//            Swap<string>("Hello", "Hi");
//        }
//    }
//}
