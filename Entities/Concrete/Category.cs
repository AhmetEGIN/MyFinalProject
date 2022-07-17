using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    // Eğer bir class herhangi bir inhertance ya da interface implementasyonu almıyorsa ilerde problem yaşanabilir
    // Varlıkları gruplamamız lazım
    // 'IEntity' bu bir veri tabanı nesnesidir demek
    public class Category : IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        
    }
}
