using System.Net;

namespace Tinify.Exceptions
{
    public sealed class ServerException : TinifyException
    {
        internal ServerException() : base()
        {
        }

        internal ServerException(string message, Exception? err = null) : base(message, err)
        {
        }

        internal ServerException(string message, string type, HttpStatusCode status) : base(message, type, status)
        {
        }
    }
}