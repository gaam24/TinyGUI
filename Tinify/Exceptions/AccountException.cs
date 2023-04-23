using System.Net;

namespace Tinify.Exceptions
{
    public sealed class AccountException : TinifyException
    {
        internal AccountException() : base()
        {
        }

        internal AccountException(string message, Exception? err = null) : base(message, err)
        {
        }

        internal AccountException(string message, string type, HttpStatusCode status) : base(message, type, status)
        {
        }
    }
}