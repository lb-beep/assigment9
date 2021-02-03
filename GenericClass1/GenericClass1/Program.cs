using System;

namespace GenericClass1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyWork myVariable = new MyWork();
            myVariable.MyMethod<string>("String 1", "String 2");

            Console.WriteLine(myVariable.MyProperty1);
            Console.WriteLine(myVariable.MyProperty2);
            
        }
    }
}
public class MyWork
{
    public string MyProperty1 { get; set; }
    public string MyProperty2 { get; set; }

    public void MyMethod<T>(T parameter1, T parameter2)
    {
        this.MyProperty1 = parameter1.ToString();
        this.MyProperty2 = parameter2.ToString();
    }
}