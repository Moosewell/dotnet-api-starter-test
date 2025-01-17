namespace dotnet_api_test.Exceptions.ExceptionResponses
{
    public class HttpExceptionResponse : Exception
    {
        protected HttpExceptionResponse(int statusCode, string msg) : base(msg)
        {
            StatusCode = statusCode;
        }

        public int StatusCode { get; protected init; }
    }
}