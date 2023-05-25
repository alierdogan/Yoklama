namespace WebAPI.Responses
{
    public class DataResponse<T> : Response
    {
        public T Data { get; set; }
        public DataResponse()
        {

        }

        public DataResponse(bool success) : base(success)
        {

        }

        public DataResponse(bool success, string message) : base(success, message)
        {

        }
    }
}
