using System;
namespace LambdaCSharp
{
    class MyClass
    {
        //public static void DoTask()
        //{
        //    List<int> numbers = new List<int>() { 83, 32, 17, 54, 8, 96, 63};
        //    List<int> result = numbers.FindAll((p)=> { return (p % 2 == 0); });
        //    foreach(int  ele in result)
        //    {
        //        Console.WriteLine($"{ele}");
        //        //Console.WriteLine($"Even numbers from list are = {ele}");
        //    }
        //}
        public static void MyTask()
        {
           Func<int, int, int> f1 = new Func<int, int, int>(AddNumbers1);
            int result = f1(20, 25);
            Console.WriteLine($"{result}");

            Action<int, int> f2 = new Action<int, int>(AddNumbers2);
            f2(55, 70);

            Predicate<int> p1 =new Predicate<int>(IsEven);
            Console.WriteLine($"{p1(32)}");

        }
        public static int AddNumbers1(int p1, int p2)
        {
            return p1 + p2; 
        }
        public static void AddNumbers2(int p1, int p2)
        {
            int result= p1 + p2;
            Console.WriteLine($"{p1} +{p2} = {result}");    
        }
        public static bool IsEven(int p)
        {
            return(p % 2 == 0);
        }

    }
}
