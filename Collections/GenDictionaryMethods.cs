//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Xml.Linq;

//namespace Collections
//{
//    public class GenDictionaryMethods
//    {
//        static void Main(string[] args)
//        {
//            Dictionary<int, string> dictionary = new Dictionary<int, string>();

//            dictionary[1] = "One";
//            dictionary[2] = "Two";
//            dictionary[3] = "Three";
//            dictionary.Remove(2);
//            Console.WriteLine("After removing key 2:");
//            Console.WriteLine($"Contains key 1? {dictionary.ContainsKey(1)}");
//            Console.WriteLine($"Contains value 'Three'? {dictionary.ContainsValue("Three")}");

//            foreach (var kvp in dictionary)
//            {
//                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
//            }
//        }
//    }
//}
