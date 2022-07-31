using System;

namespace _05.DependencyInversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HomeIndex();
            CategoryIndex();
            CategoryIndex2();
        }
        #region BeforeDependencyInversionPrinciple
        //static void HomeIndex()
        //{
        //    CategoryRepositoryEf categoryRepositoryEf = new CategoryRepositoryEf();
        //    categoryRepositoryEf.GetCategories();
        //}
        //static void CategoryIndex()
        //{
        //    CategoryRepositoryEf categoryRepositoryEf = new CategoryRepositoryEf();
        //    categoryRepositoryEf.GetCategories();
        //}
        //static void CategoryIndex2()
        //{
        //    CategoryRepositoryEf categoryRepositoryEf = new CategoryRepositoryEf();
        //    categoryRepositoryEf.GetCategories();
        //}

        #endregion

        #region AfterDependencyInversionPrinciple

        static void HomeIndex()
        {
            Container container = new Container();
            container.GetInstance().GetCategories();
        }
        static void CategoryIndex()
        {
            Container container = new Container();
            container.GetInstance().GetCategories();
        }
        static void CategoryIndex2()
        {
            Container container = new Container();
            container.GetInstance().GetCategories();
        }

        #endregion
    }

    #region BeforeDependencyInversionPrinciple

    //class CategoryRepositoryEf
    //{
    //    public void GetCategories()
    //    {
    //        Console.WriteLine("Ef");
    //    }
    //}
    //class CategoryRepositoryDp
    //{
    //    public void GetCategories()
    //    {
    //        Console.WriteLine("Ef");
    //    }
    //}

    #endregion

    #region AfterDependencyInversionPrinciple

    class Container
    {
        public ICategoryRepository GetInstance()
        {
            return new CategoryRepositoryDp();
        }
    }
    interface ICategoryRepository
    {
        void GetCategories();
    }

    class CategoryRepositoryEf : ICategoryRepository
    {
        public void GetCategories()
        {
            Console.WriteLine("Ef");
        }
    }
    class CategoryRepositoryDp : ICategoryRepository
    {
        public void GetCategories()
        {
            Console.WriteLine("Dp");
        }
    }

    #endregion
}
