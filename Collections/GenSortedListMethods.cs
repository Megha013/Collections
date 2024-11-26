//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Collections
//{
//    public class GenSortedListMethods
//    {
//        static void Main(string[] args)
//        {
//            SortedList<int, string> sortedList = new SortedList<int, string>();
//            sortedList.Add(3, "Three");
//            sortedList.Add(1, "One");
//            sortedList.Add(2, "Two");
       
//            sortedList.Remove(2);
//            Console.WriteLine("After removing key 2:");
          
//            Console.WriteLine($"Value at key 3: {sortedList[3]}");
//            Console.WriteLine("Final SortedList:");

//            foreach (var kvp in sortedList)
//            {
//                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
//            }
//        }
//    }
//}
