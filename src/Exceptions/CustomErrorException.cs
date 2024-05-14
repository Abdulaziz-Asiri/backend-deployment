using System.Data.Common;

namespace sda_onsite_2_csharp_backend_teamwork.src.Exceptions
{
    public class CustomErrorException : DbException
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }

        public CustomErrorException(int status, string message)
        {
            StatusCode = status;
            Message = message;
        }


        static public CustomErrorException NotFound(string message)
        {
            return new CustomErrorException(404, message);
        }
        static public CustomErrorException Forbidden(string message)
        {
            return new CustomErrorException(401, message);
        }
    }
}