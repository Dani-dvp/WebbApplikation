using RestaurantReview.Application.Features.Authentication.Commands.Register;
using RestaurantReview.Application.Features.Categories.Commands.AddRestaurantToCategory;
using RestaurantReview.Application.Features.Restaurants.Commands.AddCategoryToRestaurant;
using RestaurantReview.Domain.IRepositories;
using RestaurantReview.Domain.Models;
using System;
using System.Threading.Tasks;

namespace RestaurantReview.Application.Features.Seed.Commands.CreateSeed
{
    public class CreateSeedHandler : ICreateSeedService
    {
        private readonly IRestaurantRepository _restaurantRepository;
        private readonly IReviewRepository _reviewRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IAddCategoryToRestaurantService _addCategoryToRestaurantService;
        private readonly IAddRestaurantToCategoryService _addRestaurantToCategoryService;
        private readonly IRegistrationService _registrationService;

        public CreateSeedHandler(IRestaurantRepository restaurantRepository, IReviewRepository reviewRepository, ICategoryRepository categoryRepository, IAddCategoryToRestaurantService addCategoryToRestaurantService, IAddRestaurantToCategoryService addRestaurantToCategoryService, IRegistrationService registrationService)
        {
            _restaurantRepository = restaurantRepository;
            _reviewRepository = reviewRepository;
            _categoryRepository = categoryRepository;
            _addCategoryToRestaurantService = addCategoryToRestaurantService;
            _addRestaurantToCategoryService = addRestaurantToCategoryService;
            _registrationService = registrationService;
        }

        public async Task<string> CreateSeed()
        {

            var user1 = new RegistrationCommand { UserName = "roblindstrom", FirstName = "Robin", LastName = "Lindström", Email = "robin.lindstrom@live.se", Password = "Password123!" };
            var user2 = new RegistrationCommand { UserName = "kevDani", FirstName = "Kevin", LastName = "Dani", Email = "kevin1995dani@gmail.com", Password = "Password123!" };
            var user3 = new RegistrationCommand { UserName = "sebastian", FirstName = "Sebastian", LastName = "Tiger", Email = "sebbetiger@gmail.com", Password = "Password123!" };
            var user4 = new RegistrationCommand { UserName = "testuser", FirstName = "Test", LastName = "Person", Email = "test@example.com", Password = "Password123!" };

            var userResponse1 = await _registrationService.RegisterAsync(user1);
            var userResponse2 = await _registrationService.RegisterAsync(user2);
            var userResponse3 = await _registrationService.RegisterAsync(user3);
            var userResponse4 = await _registrationService.RegisterAsync(user4);



            var category1 = new Category { CategoryID = new Guid(), CategoryName = "SeaFood" };
            var category2 = new Category { CategoryID = new Guid(), CategoryName = "Pasta" };
            var category3 = new Category { CategoryID = new Guid(), CategoryName = "American" };
            var category4 = new Category { CategoryID = new Guid(), CategoryName = "Burgers" };
            var category5 = new Category { CategoryID = new Guid(), CategoryName = "Pizza" };
            var category6 = new Category { CategoryID = new Guid(), CategoryName = "ThaiFood" };
            var category7 = new Category { CategoryID = new Guid(), CategoryName = "Kebab" };
            var category8 = new Category { CategoryID = new Guid(), CategoryName = "Mexican" };
            var category9 = new Category { CategoryID = new Guid(), CategoryName = "Sushi" };
            var category10 = new Category { CategoryID = new Guid(), CategoryName = "StreetFood" };
            var category11 = new Category { CategoryID = new Guid(), CategoryName = "Vegetarian" };

            var restaurant1 = new Restaurant { RestaurantID = new Guid(), RestaurantName = "Sjömagasinet", RestaurantLink = "https://www.sjomagasinet.se/mat-och-vin/", MapURL = "https://satellites.pro/plan/Sweden_map#57.691608,11.909287,16", Description = "Sjömagasinet is beautifully located at Gothenburg's harbor entrance and has a past since 1775 as the East India Company's warehouse. The magazine has since been used by both customs officials and pilots. But Sjömagasinet has become best known for the fantastic cuisine signed by several well-known restaurateurs." };
            var restaurant2 = new Restaurant { RestaurantID = new Guid(), RestaurantName = "Restaurang Piga", RestaurantLink = "https://www.thefork.se/restaurang/piga-eriksberg-r443071", MapURL = "https://satellites.pro/plan/Sweden_map#57.699876,11.909459,16", Description = "Together with a knowledgeable dining team that professionally and easily guides you through the visit, our chefs work who uncompromisingly put the same care and love in each plate regardless of allergies or preferences." };
            var restaurant3 = new Restaurant { RestaurantID = new Guid(), RestaurantName = "Fiskekrogen", RestaurantLink = "http://www.fiskekrogen.se/", MapURL = "https://satellites.pro/plan/Sweden_map#57.705529,11.961343,16", Description = "Welcome to Fiskekrogen – in the hearth of Gothenburg!" };
            var restaurant4 = new Restaurant { RestaurantID = new Guid(), RestaurantName = "The Barn", RestaurantLink = "https://thebarn.se/", MapURL = "https://satellites.pro/plan/Sweden_map#57.704375,11.962748,15", Description = "AMERICAN FOOD CULTURE IN A LOCALLY PRODUCED SWEDISH WAY" };
            var restaurant5 = new Restaurant { RestaurantID = new Guid(), RestaurantName = "Restaurant Santé", RestaurantLink = "http://santerestaurang.se/", MapURL = "https://satellites.pro/plan/Sweden_map#57.709262,11.969390,18", Description = "With us you will find tasty and conscious food with inspiration from the Mediterranean to eat here or bring.Charcoal grilled, meze and fresh accessories with elements of organic, locally grown and seasonal ingredients, Santé offers food that is suitable for both lunch and dinner as well as drinks for all tastes." };
            var restaurant6 = new Restaurant { RestaurantID = new Guid(), RestaurantName = "Sushi Eriksberg", RestaurantLink = "http://www.sushieriksberg.se/", MapURL = "https://satellites.pro/plan/Sweden_map#57.698822,11.912291,16", Description = "We always serve fresh sushi. Enjoy the nice view of Älvsborgsbron and the harbour." };
            var restaurant7 = new Restaurant { RestaurantID = new Guid(), RestaurantName = "KFC Göteborg", RestaurantLink = "https://kfc.nu/hitta-oss/kfc-goteborg/", MapURL = "https://satellites.pro/plan/Sweden_map#57.705150,11.971257,16", Description = "Handbreaded and cooked on site in the restaurant - it is neither the easiest nor the fastest way to cook chicken, but for us at KFC, the most important thing is good quality." };
            var restaurant8 = new Restaurant { RestaurantID = new Guid(), RestaurantName = "City Kebab", RestaurantLink = "", MapURL = "https://satellites.pro/plan/Sweden_map#57.707478,11.970785,16", Description = "Kebab in central Gothenburg" };
            var restaurant9 = new Restaurant { RestaurantID = new Guid(), RestaurantName = "Bastard Burgers", RestaurantLink = "https://bastardburgers.com/", MapURL = "https://satellites.pro/plan/Sweden_map#57.707492,11.967899,17", Description = "We do stuff our own way and label it Like a Bastard™" };
            var restaurant10 = new Restaurant { RestaurantID = new Guid(), RestaurantName = "Bommen Restaurang & Bar", RestaurantLink = "http://www.bommen.nu/", MapURL = "https://satellites.pro/plan/Sweden_map#57.709578,11.964380,17", Description = "The restaurant is perfect for you who are going to visit the Gothenburg Opera and just as cozy for you who want a nice evening on the town." };

            var review1 = new Review { ReviewID = new Guid(), RestaurantID = restaurant1.RestaurantID, RestaurantName = restaurant1.RestaurantName, Rating = 5, ReviewText = "Had the most delicious seafood tower and even the non alcoholic sparkling wine was exquisite! Great service and beautiful interior.", CreatedAt = DateTime.Now, Restaurant = restaurant1, ApplicationUserId = userResponse1.ApplicationUserId };
            var review2 = new Review { ReviewID = new Guid(), RestaurantID = restaurant1.RestaurantID, RestaurantName = restaurant1.RestaurantName, Rating = 4, ReviewText = "Great restaurant with new owners. Still going strong.", CreatedAt = DateTime.Now, Restaurant = restaurant1, ApplicationUserId = userResponse2.ApplicationUserId };
            var review3 = new Review { ReviewID = new Guid(), RestaurantID = restaurant2.RestaurantID, RestaurantName = restaurant2.RestaurantName, Rating = 3, ReviewText = "Decent restaurant with new owners. Still going strong.", CreatedAt = DateTime.Now, Restaurant = restaurant2, ApplicationUserId = userResponse3.ApplicationUserId };
            var review4 = new Review { ReviewID = new Guid(), RestaurantID = restaurant3.RestaurantID, RestaurantName = restaurant3.RestaurantName, Rating = 5, ReviewText = "Amazing restaurant with new owners. Still going strong.", CreatedAt = DateTime.Now, Restaurant = restaurant3, ApplicationUserId = userResponse2.ApplicationUserId };
            var review5 = new Review { ReviewID = new Guid(), RestaurantID = restaurant4.RestaurantID, RestaurantName = restaurant4.RestaurantName, Rating = 5, ReviewText = "The best restaurant with new owners. Still going strong.", CreatedAt = DateTime.Now, Restaurant = restaurant4, ApplicationUserId = userResponse3.ApplicationUserId };
            var review6 = new Review { ReviewID = new Guid(), RestaurantID = restaurant5.RestaurantID, RestaurantName = restaurant5.RestaurantName, Rating = 2, ReviewText = "Wow restaurant with new owners. Still going strong.", CreatedAt = DateTime.Now, Restaurant = restaurant5, ApplicationUserId = userResponse1.ApplicationUserId };
            var review7 = new Review { ReviewID = new Guid(), RestaurantID = restaurant6.RestaurantID, RestaurantName = restaurant6.RestaurantName, Rating = 4, ReviewText = "Such amazing restaurant with new owners. Still going strong.", CreatedAt = DateTime.Now, Restaurant = restaurant6, ApplicationUserId = userResponse3.ApplicationUserId };
            var review8 = new Review { ReviewID = new Guid(), RestaurantID = restaurant7.RestaurantID, RestaurantName = restaurant7.RestaurantName, Rating = 3, ReviewText = "Amazing restaurant with new owners. Still going strong.", CreatedAt = DateTime.Now, Restaurant = restaurant7, ApplicationUserId = userResponse1.ApplicationUserId };
            var review9 = new Review { ReviewID = new Guid(), RestaurantID = restaurant8.RestaurantID, RestaurantName = restaurant8.RestaurantName, Rating = 5, ReviewText = "Omg restaurant with new owners. Still going strong.", CreatedAt = DateTime.Now, Restaurant = restaurant8, ApplicationUserId = userResponse2.ApplicationUserId };
            var review10 = new Review { ReviewID = new Guid(), RestaurantID = restaurant9.RestaurantID, RestaurantName = restaurant9.RestaurantName, Rating = 5, ReviewText = "the most amazing restaurant with new owners. Still going strong.", CreatedAt = DateTime.Now, Restaurant = restaurant9, ApplicationUserId = userResponse3.ApplicationUserId };
            var review11 = new Review { ReviewID = new Guid(), RestaurantID = restaurant10.RestaurantID, RestaurantName = restaurant10.RestaurantName, Rating = 1, ReviewText = "Not good restaurant with new owners. Very bad.", CreatedAt = DateTime.Now, Restaurant = restaurant10, ApplicationUserId = userResponse1.ApplicationUserId };
            var review12 = new Review { ReviewID = new Guid(), RestaurantID = restaurant9.RestaurantID, RestaurantName = restaurant9.RestaurantName, Rating = 2, ReviewText = "Such amazing restaurant with new owners. Still going strong.", CreatedAt = DateTime.Now, Restaurant = restaurant9, ApplicationUserId = userResponse1.ApplicationUserId };
            var review13 = new Review { ReviewID = new Guid(), RestaurantID = restaurant9.RestaurantID, RestaurantName = restaurant9.RestaurantName, Rating = 5, ReviewText = "The best amazing restaurant with new owners. Still going strong.", CreatedAt = DateTime.Now, Restaurant = restaurant9, ApplicationUserId = userResponse2.ApplicationUserId };
            var review14 = new Review { ReviewID = new Guid(), RestaurantID = restaurant9.RestaurantID, RestaurantName = restaurant9.RestaurantName, Rating = 3, ReviewText = "Double amazing restaurant with new owners. Still going strong.", CreatedAt = DateTime.Now, Restaurant = restaurant9, ApplicationUserId = userResponse4.ApplicationUserId };



            await _categoryRepository.AddAsync(category1);
            await _categoryRepository.AddAsync(category2);
            await _categoryRepository.AddAsync(category3);
            await _categoryRepository.AddAsync(category4);
            await _categoryRepository.AddAsync(category5);
            await _categoryRepository.AddAsync(category6);
            await _categoryRepository.AddAsync(category7);
            await _categoryRepository.AddAsync(category8);
            await _categoryRepository.AddAsync(category9);
            await _categoryRepository.AddAsync(category10);
            await _categoryRepository.AddAsync(category11);

            await _restaurantRepository.AddAsync(restaurant1);
            await _restaurantRepository.AddAsync(restaurant2);
            await _restaurantRepository.AddAsync(restaurant3);
            await _restaurantRepository.AddAsync(restaurant4);
            await _restaurantRepository.AddAsync(restaurant5);
            await _restaurantRepository.AddAsync(restaurant6);
            await _restaurantRepository.AddAsync(restaurant7);
            await _restaurantRepository.AddAsync(restaurant8);
            await _restaurantRepository.AddAsync(restaurant9);
            await _restaurantRepository.AddAsync(restaurant10);

            await _reviewRepository.AddAsync(review1);
            await _reviewRepository.AddAsync(review2);
            await _reviewRepository.AddAsync(review3);
            await _reviewRepository.AddAsync(review4);
            await _reviewRepository.AddAsync(review5);
            await _reviewRepository.AddAsync(review6);
            await _reviewRepository.AddAsync(review7);
            await _reviewRepository.AddAsync(review8);
            await _reviewRepository.AddAsync(review9);
            await _reviewRepository.AddAsync(review10);
            await _reviewRepository.AddAsync(review11);
            await _reviewRepository.AddAsync(review12);
            await _reviewRepository.AddAsync(review13);
            await _reviewRepository.AddAsync(review14);

            var addSeafoodToSjömagasinet = new AddCategoryToRestaurantCommand { CategoryName = category1.CategoryName, RestaurantName = restaurant1.RestaurantName };
            var addAmericanToBastardBurger = new AddCategoryToRestaurantCommand { CategoryName = category3.CategoryName, RestaurantName = restaurant9.RestaurantName };
            var addKebabToCityKebab = new AddCategoryToRestaurantCommand { CategoryName = category7.CategoryName, RestaurantName = restaurant8.RestaurantName };
            var addBurgersToBastardBurger = new AddCategoryToRestaurantCommand { CategoryName = category4.CategoryName, RestaurantName = restaurant9.RestaurantName };
            var addPastaToPiga = new AddCategoryToRestaurantCommand { CategoryName = category2.CategoryName, RestaurantName = restaurant2.RestaurantName };
            var addSushiToSushiEriksberg = new AddCategoryToRestaurantCommand { CategoryName = category9.CategoryName, RestaurantName = restaurant6.RestaurantName };
            var addStreetfoodToKFC = new AddCategoryToRestaurantCommand { CategoryName = category10.CategoryName, RestaurantName = restaurant7.RestaurantName };
            var addVegoToBommen = new AddCategoryToRestaurantCommand { CategoryName = category11.CategoryName, RestaurantName = restaurant10.RestaurantName };

            await _addCategoryToRestaurantService.AddCategoryToRestaurant(addSeafoodToSjömagasinet);
            await _addCategoryToRestaurantService.AddCategoryToRestaurant(addAmericanToBastardBurger);
            await _addCategoryToRestaurantService.AddCategoryToRestaurant(addKebabToCityKebab);
            await _addCategoryToRestaurantService.AddCategoryToRestaurant(addBurgersToBastardBurger);
            await _addCategoryToRestaurantService.AddCategoryToRestaurant(addPastaToPiga);
            await _addCategoryToRestaurantService.AddCategoryToRestaurant(addSushiToSushiEriksberg);
            await _addCategoryToRestaurantService.AddCategoryToRestaurant(addStreetfoodToKFC);
            await _addCategoryToRestaurantService.AddCategoryToRestaurant(addVegoToBommen);

            var addSeafoodToSjömagasinet2 = new AddRestaurantToCategoryCommand { CategoryName = category1.CategoryName, RestaurantName = restaurant1.RestaurantName };
            var addAmericanToBastardBurger2 = new AddRestaurantToCategoryCommand { CategoryName = category3.CategoryName, RestaurantName = restaurant9.RestaurantName };
            var addKebabToCityKebab2 = new AddRestaurantToCategoryCommand { CategoryName = category7.CategoryName, RestaurantName = restaurant8.RestaurantName };
            var addBurgersToBastardBurger2 = new AddRestaurantToCategoryCommand { CategoryName = category4.CategoryName, RestaurantName = restaurant9.RestaurantName };
            var addPastaToPiga2 = new AddRestaurantToCategoryCommand { CategoryName = category2.CategoryName, RestaurantName = restaurant2.RestaurantName };
            var addSushiToSushiEriksberg2 = new AddRestaurantToCategoryCommand { CategoryName = category9.CategoryName, RestaurantName = restaurant6.RestaurantName };
            var addStreetfoodToKFC2 = new AddRestaurantToCategoryCommand { CategoryName = category10.CategoryName, RestaurantName = restaurant7.RestaurantName };
            var addVegoToBommen2 = new AddRestaurantToCategoryCommand { CategoryName = category11.CategoryName, RestaurantName = restaurant10.RestaurantName };

            await _addRestaurantToCategoryService.AddRestaurantToCategory(addSeafoodToSjömagasinet2);
            await _addRestaurantToCategoryService.AddRestaurantToCategory(addAmericanToBastardBurger2);
            await _addRestaurantToCategoryService.AddRestaurantToCategory(addKebabToCityKebab2);
            await _addRestaurantToCategoryService.AddRestaurantToCategory(addBurgersToBastardBurger2);
            await _addRestaurantToCategoryService.AddRestaurantToCategory(addPastaToPiga2);
            await _addRestaurantToCategoryService.AddRestaurantToCategory(addSushiToSushiEriksberg2);
            await _addRestaurantToCategoryService.AddRestaurantToCategory(addStreetfoodToKFC2);
            await _addRestaurantToCategoryService.AddRestaurantToCategory(addVegoToBommen2);








            return "Created seed";
        }

    }
}
