
namespace ShoppingCart.API.Errors
{
    public class ApiResponse
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }

        public ApiResponse(int statusCode, string? message = null)
        {
            StatusCode = statusCode;
            Message = message ?? GetDefaultMessageForStatusCode(statusCode);
        }

        private string GetDefaultMessageForStatusCode(int statusCode)
        {
            return statusCode switch
            {
                400 => "A bad request You have made.",
                401 => "Unauthorized, You're not.",
                404 => "Resource found, It was not.",
                500 => "Errors are path to the dark side. Errors lead to anger. Anger leads to hate. Hate leads to career change.",
                _ => "",
            };
        }
    }
}
