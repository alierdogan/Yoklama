namespace WebAPI.Responses
{
    public class SuccessResponse : Response
    {
        public SuccessResponse() : base(success: true)
        {

        }
        public SuccessResponse(string message) : base(success: true, message: message)
        {

        }
    }
}
