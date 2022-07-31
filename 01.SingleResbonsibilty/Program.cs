using System;

namespace _01.SingleResbonsibilty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    #region BeforSingleResbonsibiltyPrinciple

    //public class Customer
    //{
    //    public string Name { get; set; }

    //    public bool ValidateName(string name)
    //    {
    //        return !string.IsNullOrWhiteSpace(name);
    //    }

    //    public void SayHello(string name)
    //    {
    //        Console.WriteLine("Hello " + name);
    //    }
    //}

    #endregion

    #region AfterSingleResbonsibiltyPrinciple

    public class Customer
    {
        public string Name { get; set; }
    }
    public class CustomerValidator
    {
        public bool ValidateName(string name)
        {
            return !string.IsNullOrWhiteSpace(name);
        }
    }
    public class CustomerManager
    {
        public void SayHello(string name)
        {
            Console.WriteLine("Hello " + name);
        }
    }

    #endregion
}
