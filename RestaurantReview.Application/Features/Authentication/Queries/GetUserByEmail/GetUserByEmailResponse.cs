namespace RestaurantReview.Application.Features.Authentication.Queries.GetUserByEmail
{
    public class GetUserByEmailResponse
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
    }
}
