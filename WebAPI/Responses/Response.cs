using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Responses
{
    public class Response
    {
        private bool _success;
        private string _message = string.Empty;
        public bool Success => _success;
        public string Message => _message;

        public Response()
        {

        }
        public Response(bool success)
        {
            _success = success;
        }

        public Response(bool success, string message)
        {
            _success = success;
            _message = message;
        }

        public NotFoundObjectResult ResponseNotFound()
        {
            return new NotFoundObjectResult(this);
        }

        public OkObjectResult ResponseOk()
        {
            return new OkObjectResult(this);
        }

        public BadRequestObjectResult ResponseBadRequest()
        {
            return new BadRequestObjectResult(this);
        }
    }
}
