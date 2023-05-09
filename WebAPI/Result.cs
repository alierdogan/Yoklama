//using Microsoft.AspNetCore.Mvc;
namespace WebAPI
{
    public class Result
    {
        public Result(bool success, string error, object data)
        {
            Success = success;
            Error = error;
            Data = data;
        }
        public bool Success { get; set; }
        public string Error { get; set; }
        public object Data { get; set; }
    }
}
