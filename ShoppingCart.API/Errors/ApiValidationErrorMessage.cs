namespace ShoppingCart.API.Errors
{
    public class ApiValidationErrorMessage : ApiResponse
    {
        public ApiValidationErrorMessage() : 
            base(400)
        {
        }
        public IEnumerable<string>? Errors { get; set; }
    }
}
