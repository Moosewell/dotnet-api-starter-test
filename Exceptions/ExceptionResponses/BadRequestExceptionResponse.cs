namespace dotnet_api_test.Exceptions.ExceptionResponses
{
    public class BadRequestExceptionResponse : HttpExceptionResponse
    {
        public BadRequestExceptionResponse(string msg, int statusCode = StatusCodes.Status400BadRequest) : base(statusCode, msg)
        {
            StatusCode = statusCode;
        }
    }
}