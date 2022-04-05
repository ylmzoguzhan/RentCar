using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class SuccessDataResult<T>:DataResult<T>
    {
        public SuccessDataResult(string message,T data):base(message,true,data)
        {

        }
        public SuccessDataResult(T data):base(true,data)
        {

        }
    }
}
