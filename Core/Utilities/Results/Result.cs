using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {

        public Result(bool success, string message) : this(success)
        {
            // this, classın kendisini kastediyor. this(success) = Result(success) gibi
            // Readonly ler yani getler Constructor da set edilebilir.
            Message = message;
        }
        public Result(bool success)
        {
            Success = success;
        }

        // get ler constructor içinde set edilebilir
        public bool Success { get; }

        public string Message { get; }
    }
}
