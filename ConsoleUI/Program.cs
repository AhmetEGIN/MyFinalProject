using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

//SOLID
//Open Closed Principle

ProductManager productManager = new ProductManager(new EfProductDal());


foreach (var product in productManager.GetAllByUnitPrice(20,100))
{ 
    Console.WriteLine(product.ProductName);
}







