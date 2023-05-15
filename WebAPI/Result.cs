namespace WebAPI
{
    public class Result
    {
        private readonly bool _success;
        private readonly string _message;
        private readonly object _data;

        public Result(object data, string message)
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
