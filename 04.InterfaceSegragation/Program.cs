using System;

namespace _04.InterfaceSegragation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    #region BeforeInterfaceSegragation

    //interface IRepository
    //{
    //    void Add();
    //    void OrderRepository();
    //    void ProductRepository();
    //}

    //class Product : IRepository
    //{
    //    public void Add()
    //    {
    //        Console.WriteLine("Added");
    //    }

    //    public void OrderRepository()
    //    {
    //        Console.WriteLine("Order");
    //    }

    //    public void ProductRepository()
    //    {
    //        Console.WriteLine("Product");
    //    }
    //}

    //class Order : IRepository
    //{
    //    public void Add()
    //    {
    //        Console.WriteLine("Added");
    //    }

    //    public void OrderRepository()
    //    {
    //        Console.WriteLine("Order");
    //    }

    //    public void ProductRepository()
    //    {
    //        Console.WriteLine("Product");
    //    }
    //}

    #endregion

    #region AfterInterfaceSegragation

    interface IRepository
    {
        void Add();
    }
    interface IProductRepository : IRepository
    {
        void ProductRepository();
    }
    interface IOrderRepository : IRepository
    {
        void OrderRepository();
    }

    class Product : IProductRepository
    {
        public void Add()
        {
            Console.WriteLine("Added");
        }

        public void ProductRepository()
        {
            Console.WriteLine("Product");
        }
    }
    class Order : IOrderRepository
    {
        public void Add()
        {
            Console.WriteLine("Added");
        }

        public void OrderRepository()
        {
            Console.WriteLine("Order");
        }
    }

    #endregion
}
