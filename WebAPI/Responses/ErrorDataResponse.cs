namespace WebAPI.Responses
{
    public class ErrorDataResponse<T> : DataResponse<T>
    {
        public ErrorDataResponse(T data) : base(success: false)
        {
            Data = data;
        }

        public ErrorDataResponse(T data, string message) : base(success: false, message: message)
        {
            Data = data;
        }
    }
}
