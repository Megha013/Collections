//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Collections
//{
//    public class Product:IComparable
//    {
//        private int id;
//        private string name;
//        public Product(int id, string name)
//        {
//            this.id = id;
//            this.name = name;
//        }
//        public int Id
//        {
//            get { return id; }
//        }
//        public string Name
//        {
//            get { return name; }
//        }
//        public int CompareTo(object obj) // obj = virat
//        {
//            // runs of virat is in the obj object, need typecasting to get data
//            Product p1 = (Product)obj; // virat's object assign to p1
//            // this points to current object ie. object of rohit
//            if (this.id > p1.id)
//            {
//                return 1;
//            }
//            else if (this.id < p1.id)
//            {
//                return -1;
//            }
//            else
//            {
//                return 0;
//            }
//        }
//    }
//}
