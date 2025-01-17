namespace dotnet_api_test.Exceptions.ExceptionResponses
{
    public class NotFoundRequestExceptionResponse : HttpExceptionResponse
    {
        public NotFoundRequestExceptionResponse(string msg, int statusCode = StatusCodes.Status404NotFound) : base(statusCode, msg)
        {
            StatusCode = statusCode;
        }
    }
}