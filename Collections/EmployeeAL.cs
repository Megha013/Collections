//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Collections
//{
//    public class EmployeeAL
//    {
//        public int Id { get; set; }
//        public string Name { get; set; }
//        public double Salary { get; set; }

//        static void Main(string[] args)
//        {
//            EmployeeAL em = new EmployeeAL { Id = 12, Name = "Ram", Salary = 40000 };
//            ArrayList li1 = new ArrayList();
//            li1.Add(new EmployeeAL { Id = 25, Name = "Shyam", Salary = 50000 });
//            li1.Add(new EmployeeAL { Id = 31, Name = "Laxman", Salary = 37000 });
//            li1.Add(em);

//            ArrayList li2 = new ArrayList();
//            {
//                new EmployeeAL { Id = 25, Name = "Shyam", Salary = 50000 };
//                new EmployeeAL { Id = 31, Name = "Laxman", Salary = 37000 };
//            };

//            foreach (EmployeeAL item in li2)
//            {
//                Console.WriteLine(item);
//            }

//            Stack st1 = new Stack();
//            st1.Push(em);
//            st1.Push(new EmployeeAL { Id = 39, Name = "Bharat", Salary = 35000 });
//        }
//    }
//}
