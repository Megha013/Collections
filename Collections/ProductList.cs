//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Collections
//{
//    public class ProductList
//    {
//        public class Product
//        {
//            public int Id { get; set; }
//            public string Name { get; set; }
//            public double Price { get; set; }

//            public Product(int id, string name, double price)
//            {
//                this.Id = id;
//                this.Name = name;
//                this.Price = price;
//            }
//            static void Main(string[] args)
//            {
//                List<Product> li = new List<Product>();
//                li.Add(new Product(12, "Choclate", 500));
//                li.Add(new Product(26, "Juice", 150));
//                li.Add(new Product(33, "Chips", 30));
//                li.Add(new Product(49, "Kurkure", 30));
//                li.Add(new Product(12, "Dairy Milk", 750));

//                foreach (var Product in li)
//                {
//                    Console.WriteLine($"Id:{Product.Id}, Name:{Product.Name}, Price:{Product.Price}");
//                }
//            }
//        }
//    }
//}
