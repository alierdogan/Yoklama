//using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI
{
    public class Result
    {
        private readonly bool _success;
        private readonly string _message;
        private readonly object _data;

        private Result(object data, string message)
        {
            if (data == null)
            {
                _success = false;
                _message = message != "" ? message : "Kayıt bulunamadı.";
            }
            else
            {
                _success = false;
                _message = "";
            }

            _data = data;
        }

        public static OkObjectResult ApiResult(object data, string message = "")
        {
            return new OkObjectResult(new Result(data, message));
        }

        public bool Success => _success;
        public string Message => _message;
        public object Data => _data;
    }
}
