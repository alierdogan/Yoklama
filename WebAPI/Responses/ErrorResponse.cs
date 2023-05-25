namespace WebAPI.Responses
{
    public class ErrorResponse : Response
    {
        public ErrorResponse() : base(success: false)
        {

        }

        public ErrorResponse(string message) : base(success: false, message: message)
        {

        }
    }
}
