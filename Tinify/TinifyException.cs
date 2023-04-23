using System.Net;
using Tinify.Exceptions;

namespace Tinify
{
    public class TinifyException : Exception
    {
        public HttpStatusCode Status { get; }

        internal TinifyException() : base()
        {
        }

        internal TinifyException(string message, Exception? err = null) : base(message, err)
        {
        }

        internal TinifyException(string message, string type, HttpStatusCode status) : base($"{message} (HTTP {status:D}/{type})")
        { Status = status; }

        internal static TinifyException Create(string message, string type, HttpStatusCode status)
        {
            return (int)status switch
            {
                401 or 429 => new AccountException(message, type, status),
                >= 400 and <= 499 => new ClientException(message, type, status),
                >= 500 and <= 599 => new ServerException(message, type, status),
                _ => new TinifyException(message, type, status)
            };
        }
    }
}