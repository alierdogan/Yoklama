

namespace Business
{
    public class Result
    {
        private bool _success;
        private string _message;
        private object _data;

        public Result(object data, string message = "")
        {
            if (data == null)
            {
                _success = false;
                _message = message != "" ? message : "Kayıt bulunamadı.";
            }
            else
            {
                _success = true;
                _message = "";
            }

            _data = data;
        }

        public bool Success => _success;
        public string Message => _message;
        public object Data => _data;


        
    }
}
