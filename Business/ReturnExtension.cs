using Microsoft.AspNetCore.Mvc;

namespace Business
{
    public static class ReturnExtension
    {
        public static Result ReturnResult(this object value, string message = "")
        {
            return new Result(value,message);
        }
    }
}
