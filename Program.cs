using System;
using System.IO;

namespace CSharp23._09
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            ConcreteCreator1 concreteCreator1 = new ConcreteCreator1();
            ConcreteCreator2 concreteCreator2 = new ConcreteCreator2();
            StreamReader input = new StreamReader(@"C:\Users\dmaty\RiderProjects\CSharp23.09\test.txt");
            
            Test(ref concreteCreator1, ref concreteCreator2, ref input);
        }

        public static void Test(
            ref ConcreteCreator1 concreteCreator1,
            ref ConcreteCreator2 concreteCreator2,
            ref StreamReader input)
        {
            string line;
            while ((line = input.ReadLine()) != null)
            {
                line = line.Trim();

                Console.Write($"String - [{line}]\n");
                Console.Write($"ConcreteCreator1.AnOperation() = {concreteCreator1.AnOperation(line)}\n");
                Console.Write($"ConcreteCreator2.AnOperation() = {concreteCreator2.AnOperation(line)}\n\n");
                
            }
            
        }
    }
}