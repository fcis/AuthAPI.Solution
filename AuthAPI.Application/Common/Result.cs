using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthAPI.Application.Common
{
    public class Result<T>
    {
        public bool Succeeded { get; private set; }
        public T? Data { get; private set; }
        public string? Message { get; private set; }

        public static Result<T> Success(T data, string message = "")
        {
            return new Result<T> { Succeeded = true, Data = data, Message = message };
        }

        public static Result<T> Failure(string message)
        {
            return new Result<T> { Succeeded = false, Message = message };
        }
    }
}
