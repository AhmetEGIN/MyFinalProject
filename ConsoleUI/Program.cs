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
    var result = productManager.GetProductDetails();

    //if (result.Success)
    //{
    //    foreach (var product in result.Data)
    //    {
    //        Console.WriteLine("{0} / {1}", product.ProductName, product.CategoryName);
    //    }
    //}
    //else
    //{
    //    Console.WriteLine(result.Message);
    //}
    var result2 = productManager.Add(new Product { CategoryId = 5, ProductName = "a", UnitPrice = 12, UnitsInStock = 12 });
    Console.WriteLine(result2.Message);


    //foreach (var product in productManager.GetAllByUnitPrice(20, 100))
    //{
    //    Console.WriteLine(product.ProductName);
    //}
}