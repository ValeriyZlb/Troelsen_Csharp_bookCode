using System;
using System.Numerics;

namespace BasicDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            LocalVarDeclarations();
            DefaultDeclarations();
            NewingDataTypes();
            ObjectFunctionality();
            DataTypeFunctionality();
            CharFunctionality();
            ParseFromStrings();
            ParseFromStringsWithTryParse();
            UseDatesAndTimes();
            UseBigInteger();
            DigitSeparators();
            BinaryLiterals();

            Console.ReadLine();
        }
        static void LocalVarDeclarations()
        {
            Console.WriteLine("=> Data Declarations:");

            int myInt = 0;
            string myString;
            myString = "This is my character data";

            bool b1 = true, b2 = false, b3 = b1;

            System.Boolean b4 = false;

            Console.WriteLine("Your data: {0}, {1}, {2}, {3}, {4}, {5}",
                    myInt, myString, b1, b2, b3, b4);
            Console.WriteLine();

        }
        static void DefaultDeclarations()
        {
            Console.WriteLine("=> Default Declarations:");
            int myInt = default;
            Console.WriteLine("{0}", myInt);
            Console.WriteLine();
        }
        static void NewingDataTypes()
        {
            Console.WriteLine("=> Using new to create variables:");
            bool b = new bool();
            int i = new int();
            double d = new double();
            DateTime dt = new DateTime();
            Console.WriteLine("{0}, {1}, {2}, {3}", b, i, d, dt);
            Console.WriteLine();
        }
        static void ObjectFunctionality()
        {
            Console.WriteLine("=> System.Object Functionality:");

            Console.WriteLine("12. GetHashCode() = {0}", 12.GetHashCode());
            Console.WriteLine("12.Equals(23) = {0}", 12.Equals(23));
            Console.WriteLine("12.ToString() = {0}", 12.ToString());
            Console.WriteLine("12.GetType() = {0}", 12.GetType());
            Console.WriteLine();
        }
        static void DataTypeFunctionality()
        {
            Console.WriteLine("=> Data type Finctionality:");

            Console.WriteLine("Max of int: {0}", int.MaxValue);
            Console.WriteLine("Min of int: {0}", int.MinValue);

            Console.WriteLine("Max of double: {0}", double.MaxValue);
            Console.WriteLine("Min of double: {0}", double.MinValue);
            Console.WriteLine("double.Epsilon: {0}", double.Epsilon);
            Console.WriteLine("double.PositiveInfinity: {0}", double.PositiveInfinity);
            Console.WriteLine("double.NegativeInfinity: {0}", double.NegativeInfinity);
            Console.WriteLine();
        }
        static void CharFunctionality()
        {
            Console.WriteLine("=> char type Functionality:");
            char myChar = 'a';
            Console.WriteLine("char.IsDigit('a'): {0}", char.IsDigit(myChar));
            Console.WriteLine("char.IsLetter('a'): {0}", char.IsLetter(myChar));
            Console.WriteLine("char.IsWhiteSpace('Hello There', 5): {0}", char.IsWhiteSpace("Hello There", 5));
            Console.WriteLine("char.IsWhiteSpace('Hello There', 6): {0}", char.IsWhiteSpace("Hello There", 6));
            Console.WriteLine("char.IsPunctuation('?'): {0}", char.IsPunctuation('?'));
            Console.WriteLine();

        }
        static void ParseFromStrings()
        {
            Console.WriteLine("=> Data type parsing:");
            bool b = bool.Parse("True");
            Console.WriteLine("Value of b: {0}", b);
            double d = double.Parse("99,884");
            Console.WriteLine("Value of d: {0}", d);
            int i = int.Parse("8");
            Console.WriteLine("Value of i: {0}", i);
            char c = char.Parse("w");
            Console.WriteLine("Value of c: {0}", c);
            Console.WriteLine();
        }
        static void ParseFromStringsWithTryParse()
        {
            Console.WriteLine("=> Data type parsing with TryParse:");
            if (bool.TryParse("True", out bool b))
                Console.WriteLine("Value of b: {0}", b);
            string value = "Hello";
            if (double.TryParse(value, out double d))
                Console.WriteLine("Value of d: {0}", d);
            else
                Console.WriteLine("Failure to convert the input ({0}) to a double", value);
            Console.WriteLine();
        }
        static void UseDatesAndTimes()
        {
            Console.WriteLine("=> Dates and Times:");

            DateTime dt = new DateTime(2015, 10, 17);

            Console.WriteLine("The day of {0} is {1}", dt.Date, dt.DayOfWeek);

            dt = dt.AddMonths(2);
            Console.WriteLine("Daylight savings: {0}", dt.IsDaylightSavingTime());

            TimeSpan ts = new TimeSpan(4, 30, 0);
            Console.WriteLine(ts);

            Console.WriteLine(ts.Subtract(new TimeSpan(0, 15, 0)));
            
            Console.WriteLine();
        }
        static void UseBigInteger()
        {
            Console.WriteLine("=> Use BigInteger:");
            BigInteger biggy = 
                BigInteger.Parse("9999999999999999999999999999999999999999999999");
            Console.WriteLine("Value of biggy if {0}", biggy);

            Console.WriteLine("Is biggy an even value?: {0}", biggy.IsEven);
            Console.WriteLine("Is biggy a power of two?: {0}", biggy.IsPowerOfTwo);
            BigInteger reallyBig = BigInteger.Multiply(biggy, 
                BigInteger.Parse("8888888888888888888888888888888888888888888"));
            Console.WriteLine("Value of reallyBig is {0}", reallyBig);
            Console.WriteLine();
        }
        static void DigitSeparators()
        {
            Console.WriteLine("=> Use Digit Separators:");
            Console.Write("Integer:");
            Console.WriteLine(123_456);
            Console.Write("Long:");
            Console.WriteLine(123_456_789L);
            Console.Write("Float:");
            Console.WriteLine(123_456.1234F);
            Console.Write("Double:");
            Console.WriteLine(123_456.12);
            Console.Write("Decimal:");
            Console.WriteLine(123_456.12M);
            Console.WriteLine();
        }
        private static void BinaryLiterals()
        {
            Console.WriteLine("=> Use Binary Literals:");
            Console.WriteLine("Sixteen: {0}", 0b0001_0000);
            Console.WriteLine("Thirty Two: {0}", 0b0010_0000);
            Console.WriteLine("Sixty Four: {0}", 0b0100_0000);
            Console.WriteLine();
        }
    }
}