using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public interface IDataResult<T> : IResult
    {
        // IDataResult: İşlem sonucunu, mesajı ve döndüreceği şeyi(List, Data vb) içeren bir yapıdır.
        T Data { get; }

    }
}
