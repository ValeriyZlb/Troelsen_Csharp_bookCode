using System;
using System.Linq;

namespace ImplicitlyTypedLocalVars
{
    class Program
    {
        static void Main(string[] args)
        {
            DeclareImplicitVars();
            GetAnInt();
            LinqQueryOverInt();

            Console.ReadLine();
        }
        static void DeclareImplicitVars()
        {
            // Неявно типизированные локальные переменные.
            var myInt = 0;
            var myBool = true;
            var myString = "Time, marches on...";

            // Вывести имена лежащих в основе типов.
            Console.WriteLine("myInt a: {0}", myInt.GetType().Name);    // Вывод типа myInt
            Console.WriteLine("myBool a: {0}", myBool.GetType().Name);  // Вывод типа myBool
            Console.WriteLine("myString a: {0}", myString.GetType().Name);  // Вывод типа myString
        }
        static int GetAnInt()
        {
            var retVal = 9;
            return retVal;
        }
        static void LinqQueryOverInt()
        {
            int[] numbers = { 10, 20, 30, 40, 1, 2, 3, 8 };

            // Запрос LINQ!
            var subset = from i in numbers where i < 10 select i;
            Console.Write("Values in subset: ");
            foreach (var i in subset)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();

            // К какому же типу относится subnet?
            Console.WriteLine("subnet is a: {0}", subset.GetType().Name);
            Console.WriteLine("subset is defined in: {0}", subset.GetType().Namespace);
        }
    }
}