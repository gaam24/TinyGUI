using System.Net;

namespace Tinify.Exceptions
{
    public sealed class ClientException : TinifyException
    {
        internal ClientException() : base()
        {
        }

        internal ClientException(string message, Exception? err = null) : base(message, err)
        {
        }

        internal ClientException(string message, string type, HttpStatusCode status) : base(message, type, status)
        {
        }
    }
}