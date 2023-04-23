using System.Net;

namespace Tinify.Exceptions
{
    public sealed class ConnectionException : TinifyException
    {
        internal ConnectionException() : base()
        {
        }

        internal ConnectionException(string message, Exception? err = null) : base(message, err)
        {
        }

        internal ConnectionException(string message, string type, HttpStatusCode status) : base(message, type, status)
        {
        }
    }
}