using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

//SOLID
//Open Closed Principle

ProductTest();


//CategoryTest();

static void CategoryTest()
{
    CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

    foreach (var category in categoryManager.GetAll())
    {
        Console.WriteLine(category.CategoryName);
    }
}

static void ProductTest()
{
    ProductManager productManager = new ProductManager(new EfProductDal());


    //foreach (var product in productManager.GetAllByUnitPrice(20, 100))
    //{
    //    Console.WriteLine(product.ProductName);
    //}
    foreach (var product in productManager.GetProductDetails())
    {
        Console.WriteLine("{0} / {1}", product.ProductName, product.CategoryName);
    }
}