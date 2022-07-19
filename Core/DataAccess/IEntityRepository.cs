using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{// classlarımızı ve interfacelerimizi belirli bir namespace e koyarız

    // Generic constraint : generic kısıt. Yanlış veri girilmesini önlemek amacıyla kullanılır
    // class : referans tip olabilir demek
    // Herhangi bir class yazılmasın sadece belirlediğimiz class lar yazılsın istiyorsak onu da belirtmeliyiz
    // IEntity: IEntity olabilir ya da IEntity implemente eden bir nesne olabilir. Ancak IEntity tek başına bir işe yaramaz.
    // new() : newlenebilir olmalı anlamında. Eğer new() kullanmazsak tip kısmına IEntity de koyabiliriz. new() ile bu kullanımı da sınırlamış oluruz
    public interface IEntityRepository<T> where T : class,IEntity,new()
    {
        // filtre vermemizi sağlayan yapı Expressin ile gelir
        List<T> GetAll(Expression<Func<T,bool>> filter = null);  // filtre vermemişse tüm data isteniyor demektir
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
