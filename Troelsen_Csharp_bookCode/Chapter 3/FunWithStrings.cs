using System;
using System.Text;

namespace FunWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            BasicStringFunctionality();
            StringConcatenation();
            EscapeChars();
            DefiningVerbatimStrings();
            StringEquality();
            StringEqualitySpecifyngCompareRules();
            StringsAreImmutable();
            StringsAreImmutable2();
            FunWithStringBuilder();
            StringInterpolation();

            Console.ReadLine();
        }
        static void BasicStringFunctionality()
        {
            Console.WriteLine("=> Basic String functionality:");
            string firstName = "Freddy";
            Console.WriteLine("Value of firstName: {0}", firstName);
            Console.WriteLine("firstName has {0} characters.", firstName.Length);
            Console.WriteLine("firsftName in uppercase: {0}", firstName.ToUpper());
            Console.WriteLine("firsftName in lowercase: {0}", firstName.ToLower());
            Console.WriteLine("firstName contains the letter y?: {0}", firstName.Contains("y"));
            Console.WriteLine("firstName after replace: {0}", firstName.Replace("dy", ""));
            Console.WriteLine();
        }
        static void StringConcatenation()
        {
            Console.WriteLine("=> String concatenation:");
            string s1 = "Programming the ";
            string s2 = "PsychoDrill (PTP)";
            string s3 = s1 + s2;
            Console.WriteLine(s3);
            Console.WriteLine();
        }
        static void EscapeChars()
        {
            Console.WriteLine("=> Escape characters:\a");
            string strWithTabs = "Model\tColor\tSpeed\tPet Name\a ";
            Console.WriteLine(strWithTabs);

            Console.WriteLine("Everyone loves \"Hello World\"\a ");
            Console.WriteLine("C:\\MyApp\\bin\\Debug\a ");

            Console.WriteLine("All finished.\n\n\n\a ");
            Console.WriteLine();
        }
        static void DefiningVerbatimStrings()
        {
            Console.WriteLine(@"C:\MyApp\bin\Debug");
            string myLongString = @"This is a very
                very
                    very
                        long string";
            Console.WriteLine(myLongString);

            Console.WriteLine(@"Cerebus said ""Darrr! Pret-ty sun-sets""");

            Console.WriteLine();
        }
        static void StringEquality()
        {
            Console.WriteLine("=> String equality:");
            string s1 = "Hello!";
            string s2 = "Yo!";
            Console.WriteLine("s1 = {0}", s1);
            Console.WriteLine("s2 = {0}", s2);
            Console.WriteLine();

            Console.WriteLine("s1 == s2: {0}", s1 == s2);
            Console.WriteLine("s1 == Hello!: {0}", s1 == "Hello!");
            Console.WriteLine("s1 == HELLO!: {0}", s1 == "HELLO!");
            Console.WriteLine("s1 == hello!: {0}", s1 == "hello!");
            Console.WriteLine("s1.Equals(s2): {0}", s1.Equals(s2));
            Console.WriteLine("Yo.Equals(s2): {0}", "Yo!".Equals(s2));
            Console.WriteLine();
        }
        static void StringEqualitySpecifyngCompareRules()
        {
            Console.WriteLine("=> String equality (Case Insensitive:");
            string s1 = "Hello!";
            string s2 = "HELLO!";
            Console.WriteLine("s1 = {0}", s1);
            Console.WriteLine("s2 = {0}", s2);
            Console.WriteLine();

            Console.WriteLine("Default rules: s1 = {0}, s2 = {1}, s1.Equals(s2): {2}",
                s1, s2, s1.Equals(s2));
            Console.WriteLine("Ignore case: s1.Equals(s2, StringComparison.OrdinalIgnoreCase): {0}",
                s1.Equals(s2, StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("Ignore case, Invariant Culture: s1.Equals(s2, StringComparison.InvariantCultureIgnoreCase): {0}",
                s1.Equals(s2, StringComparison.InvariantCultureIgnoreCase));
            Console.WriteLine();
            Console.WriteLine("Default rules: s1 = {0}, s2 = {1}, s1.IndexOf(\"E\"): {2}",
                s1, s2, s1.IndexOf("E"));
            Console.WriteLine("Ignore case, Invarariant Culture: s1.IndexOf(\"E\", " +
                "StringComparison.InvariantCultureIgnoreCase): {0}",
                s1.IndexOf("E", StringComparison.InvariantCultureIgnoreCase));
            Console.WriteLine();
        }
        static void StringsAreImmutable()
        {
            string s1 = "This is my string.";
            Console.WriteLine("s1 = {0}", s1);

            string upperString = s1.ToUpper();
            Console.WriteLine("upperString = {0}", upperString);

            Console.WriteLine("s1 = {0}", s1);

            Console.WriteLine();
        }
        static void StringsAreImmutable2()
        {
            string s2 = "My other string";
            s2 = "New string value";
        }
        static void FunWithStringBuilder()
        {
            Console.WriteLine("=> Using the StringBuilder:");
            StringBuilder sb = new StringBuilder("**** Fantastic Games ****");
            sb.Append("\n");
            sb.AppendLine("Half-Life");
            sb.AppendLine("Morrowind");
            sb.AppendLine("Deus Ex" + "2");
            sb.AppendLine("System Shock");
            Console.WriteLine(sb.ToString());
            sb.Replace("2", " Invinsible War");
            Console.WriteLine(sb.ToString());
            Console.WriteLine("sb has {0} chars.", sb.Length);
            Console.WriteLine();
        }
        static void StringInterpolation()
        {
            Console.WriteLine("=> Using the StringInterpalation:");

            int age = 4;
            string name = "Soren";

            string greeting = string.Format("Hello {0} you are {1} years old.", name, age);

            string greeting2 = $"Hello {name} you are {age} years old.";

            Console.WriteLine(greeting);
            Console.WriteLine(greeting2);

            Console.WriteLine();
        }
    }
}