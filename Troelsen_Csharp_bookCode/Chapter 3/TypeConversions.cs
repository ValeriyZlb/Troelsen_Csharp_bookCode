using System;

namespace TypeConversions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with type conversions *****");
            
            // Добавить две переменные типа short и вывести результат.
            short numb1 = 30000, numb2 = 30000;
            
            // Явно привести int к short (и разрешить потерю данных).
            short answer = (short)Add(numb1, numb2);
            Console.WriteLine("{0} + {1} = {2}", numb1, numb2, answer);
            NarrowingAttempt();
            ProcessBytes();

            Console.ReadLine();
        }
        static int Add(int x, int y)
        {
            return x + y;
        }
        static void NarrowingAttempt()
        {
            byte myByte = 0;
            int myInt = 200;

            // Явно привести int к byte (без потери данных).
            myByte = (byte)myInt;
            Console.WriteLine("Value of myByte: {0}", myByte);
        }
        static void ProcessBytes()
        {
            byte b1 = 100;
            byte b2 = 250;

            // На этот раз сообщить компилятору о необходимости добавления
            // кода CIL, неодходимого для генерации исключения, если возникает
            // переполнение или потеря значимости.
            try
            {
                checked
                {
                    byte sum = (byte)Add(b1, b2);
                    Console.WriteLine("sum = {0}", sum);
                }
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}