namespace RestaurantReview.Application.Features.Authentication.Queries.CheckTokenIfValid
{
    public interface ICheckIfTokenIsValidService
    {
        public bool ValidateCurrentToken(string token);
    }
}
