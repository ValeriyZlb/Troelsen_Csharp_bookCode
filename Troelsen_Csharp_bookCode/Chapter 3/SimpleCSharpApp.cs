﻿using System;

namespace SimpleCSharpApp
{
    class Program
    {
        static int Main(string[] args)
        {
            Console.WriteLine("***** My First C# App *****");
            Console.WriteLine("Hello World!");
            Console.WriteLine();
            ShowEnvironmentDetails();
            DisplayMessage();
            Console.ReadLine();

            return -1;
        }
        static void ShowEnvironmentDetails()
        {
            foreach (string drive in Environment.GetLogicalDrives())
                Console.WriteLine("Drive: {0}", drive);

            Console.WriteLine("OS: {0}", Environment.OSVersion);

            Console.WriteLine("Number of processofrs: {0}", Environment.ProcessorCount);

            Console.WriteLine(".NET Version: {0}", Environment.Version);
        }
        static void DisplayMessage()
        {
            string userMessage = string.Format("100000 in hex is {0:x}", 100000);
            System.Windows.MessageBox.Show(userMessage);
        }
    }
}