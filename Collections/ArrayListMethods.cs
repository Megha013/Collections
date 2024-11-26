//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net.Http.Headers;
//using System.Text;
//using System.Threading.Tasks;

//namespace Collections
//{
//    public class ArrayListMethods
//    {
//        static void Main(string[] args)
//        {
//            int[] arr = new int[] { 30, 40, 50 };
//            ArrayList li = new ArrayList();
//            li.Add(10);
//            li.Add(20);
//            li.Insert(1, 15);
//            li.AddRange(arr);
//            li.Remove(40);
//            li.RemoveAt(0);
//            li.RemoveRange(1, 3);
//            li.Sort();
//            li.Reverse();
//            Console.WriteLine(li.Contains(100));
//            Console.WriteLine(li.Contains(15));
//            li.Clear();
//            Console.WriteLine("Total elements : " + li.Count);
//            Console.WriteLine("Total capacity : " + li.Capacity);

//            foreach (var item in li)
//            {
//                Console.WriteLine(item);
//            }
//        }
//    }
//}
