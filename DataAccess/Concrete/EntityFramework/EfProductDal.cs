using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    // ORM : Veri tabanındaki tanloyu sanki class mış gibi ilişkilendirir. Bütün SQL leri Linq ile yapma imkanı sunan bir ortam
    // Veri tabanındaki nesneler ve kodlar arasında bir ilişki kurup veri tabanı işleri yapma süreci

    // Başkalarının yazdığı kodları ilerleyen zamanlarda kullanacağız. Bu kodların ortak koyulduğu ve 
    // yönetildiği ortam : NuGet (DataAccess üzerinde sağ tık Manage NuGet Packages)
    public class EfProductDal : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDal
    {
        public List<ProductDetailDto> GetProductDetails()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var result = from p in context.Products
                             join c in context.Categories
                             on p.CategoryId equals c.CategoryId
                             select new ProductDetailDto {ProductId = p.ProductId, ProductName = p.ProductName, 
                                 CategoryName = c.CategoryName, UnitPrice = p.UnitPrice, UnitsInStock = p.UnitsInStock };

                return result.ToList();
            }
        }
    }
}
