using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class ErrorDataResult<T>:DataResult<T>
    {
        public ErrorDataResult(string message,T data):base(message,false,data)
        {

        }
        public ErrorDataResult(T data):base(false,data)
        {

        }
    }
}
