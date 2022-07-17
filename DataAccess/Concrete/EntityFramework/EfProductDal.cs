using DataAccess.Abstract;
using Entities.Concrete;
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
    public class EfProductDal : IProductDal
    {
        

        public void Add(Product entity)
        {
            // IDisposable pattern implementation of C#
            // using bittiği zaman belleği temizler. 
            using (NorthwindContext context = new NorthwindContext())
            {
                var addedEntity = context.Entry(entity);  // referansı yakalama kısmı
                addedEntity.State = EntityState.Added;  // Eklenecek nesne
                context.SaveChanges();  // işlemleri gerçekleştir ekle

            }
        }

        public void Delete(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Set<Product>().SingleOrDefault(filter);
            }
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return filter == null ? context.Set<Product>().ToList() : context.Set<Product>().Where(filter).ToList();
            }
        }

        public void Update(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();

            }
        }
    }
}
