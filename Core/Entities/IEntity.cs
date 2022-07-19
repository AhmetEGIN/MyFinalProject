using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    // COre katmanı bizim evrensel katmanımızdır.
    // Yani bütün .Net projelerinde kullanılabilecek olan kodlar bu katmana yazılır
    // Core katmanı evrensel bir katman olduğu için hiçbir katmanı referans almaz



    // IEntity implement eden bir class bir veri tabanı tablosudur
    public interface IEntity
    {
    }
}
