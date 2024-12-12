using System.ComponentModel.Design;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace Task6C_
{
    internal class Program
    {
        #region problem 1
        struct point
        {
            int X { get; set; }
            int Y { get; set; }

            public point()
            {
                X = 0;
                Y = 0;
            }

            public point(int x, int y)
            {
                X = x;
                Y = y;
            }
            public override string ToString()
            {
                return $"({X} , {Y}) ";
            }
     
        }

        #endregion
        #region problem 2

        public class TypeA
        {
            private string F;

            internal int G ;

            public bool H ;
        }

        #endregion
        #region problem 3

        public struct employee
        {
            private int EmpId;
            private string Name;
            private double salary;

            public employee(int Id, string name, double sal)

            {
                EmpId = Id;
                Name = name;
                salary = sal;
            }
            public string getName() {
                return Name;
            }
            public void setName(string Name)
            {
                Name = Name;
            }
            public double salaryvalue 
            {
                get {return salary; }
                set { salary = value; }
            }

            public void showresult()
            {
                Console.WriteLine($"employeeId:{EmpId}, name:{Name} , slary :{salary}");
            }
        }



        #endregion
        #region problem 4
        struct point1
        {
            public int X;
           public  int Y;

            public point1(int x) 
            { 
                X=x;
                Y=0;
            }
            public point1(int x , int y)
            {
                X=x; Y=y;
            }

            public void showresult()
            {
                Console.WriteLine($"{X} , {Y}");
            }
        }
        #endregion
        #region problem 5 
        public struct point5
        {
            public int X;
            public int Y;

            public point5(int x, int y)
            {
                X=x; Y=y;
            }
        }

        public class Employee5
        {
            public string name5;
            public int Age;

            public Employee5(string namee, int age)
            {
                name5 = namee;
                Age = age;
            }   
        }

        class program
        {
            public static void UpdatePoint5(point5 p5)
            {
                p5.X = 10;
                p5.Y = 20;
                Console.WriteLine($"inside  {p5.X} , {p5.Y}");
            }

            public static void UpdateEmp(Employee5 emp)
            {
                emp.name5 = "ali";
                emp.Age= 30;
                Console.WriteLine($"insid {emp.name5} , {emp.Age}");
            }
       

       
        #endregion
        static void Main(string[] args)
        {
            #region problem 1
            //prolem 1
            point p1 = new point();
            Console.WriteLine(p1.ToString());
            // Question: Why can't a struct inherit from another struct or class in C#? 
            // Structs are designed to be lightweight and have a fixed size,
            // stored on the stack.
            #endregion
            #region promlem 2
            //problem 2

            TypeA obj1 = new TypeA();
            obj1.H = true;
            obj1.G = 1;
            //  obj1.F = "reem"; //error
            #endregion
            #region problem 3
            //problem 3

            employee emp1 = new employee(1 , " reem" , 7000);

            emp1.setName("sama");
            Console.WriteLine($"emplyess {emp1.getName}");
            Console.WriteLine($"salary {emp1.salaryvalue}");

            emp1.salaryvalue = 7500;
            Console.WriteLine($"update salary {emp1.salaryvalue}");
            emp1.showresult();
            //Question: Why is encapsulation critical in software design? 
            //Encapsulation ensures that sensitive data , increase maintance 
            #endregion
            #region problem 4
            //problem 4
            point1 p = new point1(5);
            p.showresult();
            point1 p2 = new point1( 6 , 7);
            p2.showresult();
                // Question: How does overriding methods like ToString() improve code readability? 
                //mproves code readability 
                //Helps in Debugging and  Cleaner and More Readable Code
                #endregion

            #region proplem 5
                // problem 5 
                point5 poinfive = new point5(100,200); //value type
               Console.WriteLine($"before {poinfive.X} , {poinfive.Y}");
        UpdatePoint5(poinfive);
                Console.WriteLine($"after {poinfive.X},{poinfive.Y}");

         Employee5 e = new Employee5("reem", 50); // ref type
               Console.WriteLine($"before {e.name5} , {e.Age}");
        UpdateEmp(e);
                Console.WriteLine($"after {e.name5}  , {e.Age}");

                // Question: How does memory allocation differ for structs and classes in C#?
// struct is value type >> in stack 
//class is ref type >> in heap
                #endregion
            }
        }
    }
    
}
#region part 2
//What is copy constructor ?
//special type of constructor >> create a new object as a copy of an existing object
//takes a reference to an object of the same class
//what is indexes
////special type of property that allows an object to be accessed like an array or a collection
#endregion