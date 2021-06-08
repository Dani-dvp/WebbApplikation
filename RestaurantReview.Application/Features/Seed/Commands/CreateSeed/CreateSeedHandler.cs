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



            var SeaFood = new Category { CategoryID = new Guid(), CategoryName = "SeaFood" };
            var Pasta = new Category { CategoryID = new Guid(), CategoryName = "Pasta" };
            var American = new Category { CategoryID = new Guid(), CategoryName = "American" };
            var Burgers = new Category { CategoryID = new Guid(), CategoryName = "Burgers" };
            var Pizza = new Category { CategoryID = new Guid(), CategoryName = "Pizza" };
            var ThaiFood = new Category { CategoryID = new Guid(), CategoryName = "ThaiFood" };
            var Kebab = new Category { CategoryID = new Guid(), CategoryName = "Kebab" };
            var Mexican = new Category { CategoryID = new Guid(), CategoryName = "Mexican" };
            var Sushi = new Category { CategoryID = new Guid(), CategoryName = "Sushi" };
            var StreetFood = new Category { CategoryID = new Guid(), CategoryName = "StreetFood" };
            var Vegetarian = new Category { CategoryID = new Guid(), CategoryName = "Vegetarian" };

            var Sjömagasinet = new Restaurant { TempImage = "https://upload.wikimedia.org/wikipedia/commons/e/e0/Sj%C3%B6magasinet%2C_framsidan.jpg", RestaurantID = new Guid(), RestaurantName = "Sjömagasinet", RestaurantLink = "https://www.sjomagasinet.se/mat-och-vin/", MapURL = "https://satellites.pro/plan/Sweden_map#57.691608,11.909287,16", Description = "Sjömagasinet is beautifully located at Gothenburg's harbor entrance and has a past since 1775 as the East India Company's warehouse. The magazine has since been used by both customs officials and pilots. But Sjömagasinet has become best known for the fantastic cuisine signed by several well-known restaurateurs." };
            var RestaurantPiga = new Restaurant { TempImage = "https://lh5.googleusercontent.com/p/AF1QipP7212Kwr2sbcL1yMEmrrGaMcTgEAXgHRotMwAh=w408-h306-k-no", RestaurantID = new Guid(), RestaurantName = "Restaurang Piga", RestaurantLink = "https://www.thefork.se/restaurang/piga-eriksberg-r443071", MapURL = "https://satellites.pro/plan/Sweden_map#57.699876,11.909459,16", Description = "Together with a knowledgeable dining team that professionally and easily guides you through the visit, our chefs work who uncompromisingly put the same care and love in each plate regardless of allergies or preferences." };
            var Fiskekrogen = new Restaurant { TempImage = "https://pbs.twimg.com/media/CjT2pJYWEAAtGzA?format=jpg&name=small", RestaurantID = new Guid(), RestaurantName = "Fiskekrogen", RestaurantLink = "http://www.fiskekrogen.se/", MapURL = "https://satellites.pro/plan/Sweden_map#57.705529,11.961343,16", Description = "Welcome to Fiskekrogen – in the hearth of Gothenburg!" };
            var TheBarn = new Restaurant { TempImage = "https://static.thatsup.co/content/img/article/17/feb/the-barn-skaffar-barn-och-%C3%B6ppnar-ny-bar.jpg", RestaurantID = new Guid(), RestaurantName = "The Barn", RestaurantLink = "https://thebarn.se/", MapURL = "https://satellites.pro/plan/Sweden_map#57.704375,11.962748,15", Description = "AMERICAN FOOD CULTURE IN A LOCALLY PRODUCED SWEDISH WAY" };
            var RestaurangSante = new Restaurant { TempImage = "https://media-cdn.tripadvisor.com/media/photo-s/11/03/71/35/sante-bar-kitchen.jpg", RestaurantID = new Guid(), RestaurantName = "Restaurant Santé", RestaurantLink = "http://santerestaurang.se/", MapURL = "https://satellites.pro/plan/Sweden_map#57.709262,11.969390,18", Description = "With us you will find tasty and conscious food with inspiration from the Mediterranean to eat here or bring.Charcoal grilled, meze and fresh accessories with elements of organic, locally grown and seasonal ingredients, Santé offers food that is suitable for both lunch and dinner as well as drinks for all tastes." };
            var SushiEriksberg = new Restaurant { TempImage = "https://static.thatsup.co/content/img/article/16/jan/guiden-till-g%C3%B6teborgs-b%C3%A4sta-sushirestauranger.jpg", RestaurantID = new Guid(), RestaurantName = "Sushi Eriksberg", RestaurantLink = "http://www.sushieriksberg.se/", MapURL = "https://satellites.pro/plan/Sweden_map#57.698822,11.912291,16", Description = "We always serve fresh sushi. Enjoy the nice view of Älvsborgsbron and the harbour." };
            var KFCGöteborg = new Restaurant { TempImage = "https://www.fastighetsvarlden.se/wp-content/uploads/2019/01/kfc.jpg", RestaurantID = new Guid(), RestaurantName = "KFC Göteborg", RestaurantLink = "https://kfc.nu/hitta-oss/kfc-goteborg/", MapURL = "https://satellites.pro/plan/Sweden_map#57.705150,11.971257,16", Description = "Handbreaded and cooked on site in the restaurant - it is neither the easiest nor the fastest way to cook chicken, but for us at KFC, the most important thing is good quality." };
            var CityKebab = new Restaurant { TempImage = "https://citykebabhalmstad.se/stores/16/images/1.jpg", RestaurantID = new Guid(), RestaurantName = "City Kebab", RestaurantLink = "", MapURL = "https://satellites.pro/plan/Sweden_map#57.707478,11.970785,16", Description = "Kebab in central Gothenburg" };
            var BastardBurgers = new Restaurant { TempImage = "https://images.ohmyhosting.se/nJWJAv1B1qLNXvlCIXAU8ZNM9ak=/804x1078/smart/filters:quality(85)/https%3A%2F%2Fbastardburgers.com%2Fwp-content%2Fuploads%2Fsites%2F6%2F2021%2F02%2Fbeyond_london-min.jpg", RestaurantID = new Guid(), RestaurantName = "Bastard Burgers", RestaurantLink = "https://bastardburgers.com/", MapURL = "https://satellites.pro/plan/Sweden_map#57.707492,11.967899,17", Description = "We do stuff our own way and label it Like a Bastard™" };
            var BommenRestaurang = new Restaurant { TempImage = "https://lh3.googleusercontent.com/proxy/bb7Ilqe7qx50LZ4fBBgat1z63KqtlJoJOQL5LvHmbyVUITPaReLORmMtkLjZFb6rSOW9ax-VdVU-Bcw1_VZ4yX1ct9fClwpqBEvFYPxrt3dV_c1W6W0EJDlyww", RestaurantID = new Guid(), RestaurantName = "Bommen Restaurang & Bar", RestaurantLink = "http://www.bommen.nu/", MapURL = "https://satellites.pro/plan/Sweden_map#57.709578,11.964380,17", Description = "The restaurant is perfect for you who are going to visit the Gothenburg Opera and just as cozy for you who want a nice evening on the town." };

            var review1 = new Review { ReviewID = new Guid(), RestaurantID = Sjömagasinet.RestaurantID, RestaurantName = Sjömagasinet.RestaurantName, Rating = 5, ReviewText = "Had the most delicious seafood tower and even the non alcoholic sparkling wine was exquisite! Great service and beautiful interior.", CreatedAt = DateTime.Now, Restaurant = Sjömagasinet, ApplicationUserId = userResponse1.ApplicationUserId,UserName = user1.UserName };
            var review2 = new Review { ReviewID = new Guid(), RestaurantID = Sjömagasinet.RestaurantID, RestaurantName = Sjömagasinet.RestaurantName, Rating = 4, ReviewText = "Great restaurant with new owners. Still going strong.", CreatedAt = DateTime.Now, Restaurant = Sjömagasinet, ApplicationUserId = userResponse2.ApplicationUserId, UserName=user2.UserName };
            var review3 = new Review { ReviewID = new Guid(), RestaurantID = RestaurantPiga.RestaurantID, RestaurantName = RestaurantPiga.RestaurantName, Rating = 3, ReviewText = "Decent restaurant with new owners. Still going strong.", CreatedAt = DateTime.Now, Restaurant = RestaurantPiga, ApplicationUserId = userResponse3.ApplicationUserId, UserName = user3.UserName };
            var review4 = new Review { ReviewID = new Guid(), RestaurantID = Fiskekrogen.RestaurantID, RestaurantName = Fiskekrogen.RestaurantName, Rating = 5, ReviewText = "Amazing restaurant with new owners. Still going strong.", CreatedAt = DateTime.Now, Restaurant = Fiskekrogen, ApplicationUserId = userResponse2.ApplicationUserId, UserName = user2.UserName };
            var review5 = new Review { ReviewID = new Guid(), RestaurantID = TheBarn.RestaurantID, RestaurantName = TheBarn.RestaurantName, Rating = 5, ReviewText = "The best restaurant with new owners. Still going strong.", CreatedAt = DateTime.Now, Restaurant = TheBarn, ApplicationUserId = userResponse3.ApplicationUserId, UserName = user3.UserName };
            var review6 = new Review { ReviewID = new Guid(), RestaurantID = RestaurangSante.RestaurantID, RestaurantName = RestaurangSante.RestaurantName, Rating = 2, ReviewText = "Wow restaurant with new owners. Still going strong.", CreatedAt = DateTime.Now, Restaurant = RestaurangSante, ApplicationUserId = userResponse1.ApplicationUserId, UserName = user1.UserName };
            var review7 = new Review { ReviewID = new Guid(), RestaurantID = SushiEriksberg.RestaurantID, RestaurantName = SushiEriksberg.RestaurantName, Rating = 4, ReviewText = "Such amazing restaurant with new owners. Still going strong.", CreatedAt = DateTime.Now, Restaurant = SushiEriksberg, ApplicationUserId = userResponse3.ApplicationUserId, UserName = user3.UserName };
            var review8 = new Review { ReviewID = new Guid(), RestaurantID = KFCGöteborg.RestaurantID, RestaurantName = KFCGöteborg.RestaurantName, Rating = 3, ReviewText = "Amazing restaurant with new owners. Still going strong.", CreatedAt = DateTime.Now, Restaurant = KFCGöteborg, ApplicationUserId = userResponse1.ApplicationUserId, UserName = user1.UserName };
            var review9 = new Review { ReviewID = new Guid(), RestaurantID = CityKebab.RestaurantID, RestaurantName = CityKebab.RestaurantName, Rating = 5, ReviewText = "Omg restaurant with new owners. Still going strong.", CreatedAt = DateTime.Now, Restaurant = CityKebab, ApplicationUserId = userResponse2.ApplicationUserId, UserName = user2.UserName };
            var review10 = new Review { ReviewID = new Guid(), RestaurantID = BastardBurgers.RestaurantID, RestaurantName = BastardBurgers.RestaurantName, Rating = 5, ReviewText = "the most amazing restaurant with new owners. Still going strong.", CreatedAt = DateTime.Now, Restaurant = BastardBurgers, ApplicationUserId = userResponse3.ApplicationUserId, UserName = user3.UserName };
            var review11 = new Review { ReviewID = new Guid(), RestaurantID = BommenRestaurang.RestaurantID, RestaurantName = BommenRestaurang.RestaurantName, Rating = 1, ReviewText = "Not good restaurant with new owners. Very bad.", CreatedAt = DateTime.Now, Restaurant = BommenRestaurang, ApplicationUserId = userResponse1.ApplicationUserId, UserName = user1.UserName };
            var review12 = new Review { ReviewID = new Guid(), RestaurantID = BastardBurgers.RestaurantID, RestaurantName = BastardBurgers.RestaurantName, Rating = 2, ReviewText = "Such amazing restaurant with new owners. Still going strong.", CreatedAt = DateTime.Now, Restaurant = BastardBurgers, ApplicationUserId = userResponse1.ApplicationUserId, UserName = user1.UserName };
            var review13 = new Review { ReviewID = new Guid(), RestaurantID = BastardBurgers.RestaurantID, RestaurantName = BastardBurgers.RestaurantName, Rating = 5, ReviewText = "The best amazing restaurant with new owners. Still going strong.", CreatedAt = DateTime.Now, Restaurant = BastardBurgers, ApplicationUserId = userResponse2.ApplicationUserId, UserName = user2.UserName };
            var review14 = new Review { ReviewID = new Guid(), RestaurantID = BastardBurgers.RestaurantID, RestaurantName = BastardBurgers.RestaurantName, Rating = 3, ReviewText = "Double amazing restaurant with new owners. Still going strong.", CreatedAt = DateTime.Now, Restaurant = BastardBurgers, ApplicationUserId = userResponse4.ApplicationUserId, UserName = user4.UserName };



            await _categoryRepository.AddAsync(SeaFood);
            await _categoryRepository.AddAsync(Pasta);
            await _categoryRepository.AddAsync(American);
            await _categoryRepository.AddAsync(Burgers);
            await _categoryRepository.AddAsync(Pizza);
            await _categoryRepository.AddAsync(ThaiFood);
            await _categoryRepository.AddAsync(Kebab);
            await _categoryRepository.AddAsync(Mexican);
            await _categoryRepository.AddAsync(Sushi);
            await _categoryRepository.AddAsync(StreetFood);
            await _categoryRepository.AddAsync(Vegetarian);

            await _restaurantRepository.AddAsync(Sjömagasinet);
            await _restaurantRepository.AddAsync(RestaurantPiga);
            await _restaurantRepository.AddAsync(Fiskekrogen);
            await _restaurantRepository.AddAsync(TheBarn);
            await _restaurantRepository.AddAsync(RestaurangSante);
            await _restaurantRepository.AddAsync(SushiEriksberg);
            await _restaurantRepository.AddAsync(KFCGöteborg);
            await _restaurantRepository.AddAsync(CityKebab);
            await _restaurantRepository.AddAsync(BastardBurgers);
            await _restaurantRepository.AddAsync(BommenRestaurang);

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

            var addSeafoodToSjömagasinet = new AddCategoryToRestaurantCommand { CategoryName = SeaFood.CategoryName, RestaurantName = Sjömagasinet.RestaurantName };
            var addAmericanToBastardBurger = new AddCategoryToRestaurantCommand { CategoryName = American.CategoryName, RestaurantName = BastardBurgers.RestaurantName };
            var addKebabToCityKebab = new AddCategoryToRestaurantCommand { CategoryName = Kebab.CategoryName, RestaurantName = CityKebab.RestaurantName };
            var addBurgersToBastardBurger = new AddCategoryToRestaurantCommand { CategoryName = Burgers.CategoryName, RestaurantName = BastardBurgers.RestaurantName };
            var addPastaToPiga = new AddCategoryToRestaurantCommand { CategoryName = Pasta.CategoryName, RestaurantName = RestaurantPiga.RestaurantName };
            var addSushiToSushiEriksberg = new AddCategoryToRestaurantCommand { CategoryName = Sushi.CategoryName, RestaurantName = SushiEriksberg.RestaurantName };
            var addStreetfoodToKFC = new AddCategoryToRestaurantCommand { CategoryName = StreetFood.CategoryName, RestaurantName = KFCGöteborg.RestaurantName };
            var addVegoToBommen = new AddCategoryToRestaurantCommand { CategoryName = Vegetarian.CategoryName, RestaurantName = BommenRestaurang.RestaurantName };
            var addStreetfoodToBastardBurger = new AddCategoryToRestaurantCommand { CategoryName = StreetFood.CategoryName, RestaurantName = BastardBurgers.RestaurantName };
            var addStreetfoodToTheBarn = new AddCategoryToRestaurantCommand { CategoryName = StreetFood.CategoryName, RestaurantName = TheBarn.RestaurantName };
            var addAmericanToTheBarn = new AddCategoryToRestaurantCommand { CategoryName = American.CategoryName, RestaurantName = TheBarn.RestaurantName };
            var addAmericanToKFC = new AddCategoryToRestaurantCommand { CategoryName = American.CategoryName, RestaurantName = KFCGöteborg.RestaurantName };
            var addPizzaToCityKebab = new AddCategoryToRestaurantCommand { CategoryName = Pizza.CategoryName, RestaurantName = CityKebab.RestaurantName };
            var addSeaFoodToEriksbergsSushi = new AddCategoryToRestaurantCommand { CategoryName = SeaFood.CategoryName, RestaurantName = SushiEriksberg.RestaurantName };
            var addVegetarianToPiga = new AddCategoryToRestaurantCommand { CategoryName = Vegetarian.CategoryName, RestaurantName = RestaurantPiga.RestaurantName };
            var addThaifoodtoBoomen = new AddCategoryToRestaurantCommand { CategoryName = ThaiFood.CategoryName, RestaurantName = BommenRestaurang.RestaurantName };

            await _addCategoryToRestaurantService.AddCategoryToRestaurant(addSeafoodToSjömagasinet);
            await _addCategoryToRestaurantService.AddCategoryToRestaurant(addAmericanToBastardBurger);
            await _addCategoryToRestaurantService.AddCategoryToRestaurant(addKebabToCityKebab);
            await _addCategoryToRestaurantService.AddCategoryToRestaurant(addBurgersToBastardBurger);
            await _addCategoryToRestaurantService.AddCategoryToRestaurant(addPastaToPiga);
            await _addCategoryToRestaurantService.AddCategoryToRestaurant(addSushiToSushiEriksberg);
            await _addCategoryToRestaurantService.AddCategoryToRestaurant(addStreetfoodToKFC);
            await _addCategoryToRestaurantService.AddCategoryToRestaurant(addVegoToBommen);
            await _addCategoryToRestaurantService.AddCategoryToRestaurant(addStreetfoodToBastardBurger);
            await _addCategoryToRestaurantService.AddCategoryToRestaurant(addStreetfoodToTheBarn);
            await _addCategoryToRestaurantService.AddCategoryToRestaurant(addAmericanToTheBarn);
            await _addCategoryToRestaurantService.AddCategoryToRestaurant(addAmericanToKFC);
            await _addCategoryToRestaurantService.AddCategoryToRestaurant(addPizzaToCityKebab);
            await _addCategoryToRestaurantService.AddCategoryToRestaurant(addVegetarianToPiga);
            await _addCategoryToRestaurantService.AddCategoryToRestaurant(addSeaFoodToEriksbergsSushi);
            await _addCategoryToRestaurantService.AddCategoryToRestaurant(addThaifoodtoBoomen);

            var addSeafoodToSjömagasinet2 = new AddRestaurantToCategoryCommand { CategoryName = SeaFood.CategoryName, RestaurantName = Sjömagasinet.RestaurantName };
            var addAmericanToBastardBurger2 = new AddRestaurantToCategoryCommand { CategoryName = American.CategoryName, RestaurantName = BastardBurgers.RestaurantName };
            var addKebabToCityKebab2 = new AddRestaurantToCategoryCommand { CategoryName = Kebab.CategoryName, RestaurantName = CityKebab.RestaurantName };
            var addBurgersToBastardBurger2 = new AddRestaurantToCategoryCommand { CategoryName = Burgers.CategoryName, RestaurantName = BastardBurgers.RestaurantName };
            var addPastaToPiga2 = new AddRestaurantToCategoryCommand { CategoryName = Pasta.CategoryName, RestaurantName = RestaurantPiga.RestaurantName };
            var addSushiToSushiEriksberg2 = new AddRestaurantToCategoryCommand { CategoryName = Sushi.CategoryName, RestaurantName = SushiEriksberg.RestaurantName };
            var addStreetfoodToKFC2 = new AddRestaurantToCategoryCommand { CategoryName = StreetFood.CategoryName, RestaurantName = KFCGöteborg.RestaurantName };
            var addVegoToBommen2 = new AddRestaurantToCategoryCommand { CategoryName = Vegetarian.CategoryName, RestaurantName = BommenRestaurang.RestaurantName };
            var addStreetfoodToBastardBurger2 = new AddRestaurantToCategoryCommand { CategoryName = StreetFood.CategoryName, RestaurantName = BastardBurgers.RestaurantName };
            var addStreetfoodToThebarn2 = new AddRestaurantToCategoryCommand { CategoryName = StreetFood.CategoryName, RestaurantName = TheBarn.RestaurantName };
            var addAmericanToTheBarn2 = new AddRestaurantToCategoryCommand { CategoryName = American.CategoryName, RestaurantName = TheBarn.RestaurantName };
            var addAmericanToKFC2 = new AddRestaurantToCategoryCommand { CategoryName = American.CategoryName, RestaurantName = KFCGöteborg.RestaurantName };
            var addPizzaToCityKebab2 = new AddRestaurantToCategoryCommand { CategoryName = Pizza.CategoryName, RestaurantName = CityKebab.RestaurantName };
            var addSeaFoodToEriksbergsSushi2 = new AddRestaurantToCategoryCommand { CategoryName = SeaFood.CategoryName, RestaurantName = SushiEriksberg.RestaurantName };
            var addVegetarianToPiga2 = new AddRestaurantToCategoryCommand { CategoryName = Vegetarian.CategoryName, RestaurantName = RestaurantPiga.RestaurantName };
            var addThaifoodtoBoomen2 = new AddRestaurantToCategoryCommand { CategoryName = ThaiFood.CategoryName, RestaurantName = BommenRestaurang.RestaurantName };


            await _addRestaurantToCategoryService.AddRestaurantToCategory(addSeafoodToSjömagasinet2);
            await _addRestaurantToCategoryService.AddRestaurantToCategory(addAmericanToBastardBurger2);
            await _addRestaurantToCategoryService.AddRestaurantToCategory(addKebabToCityKebab2);
            await _addRestaurantToCategoryService.AddRestaurantToCategory(addBurgersToBastardBurger2);
            await _addRestaurantToCategoryService.AddRestaurantToCategory(addPastaToPiga2);
            await _addRestaurantToCategoryService.AddRestaurantToCategory(addSushiToSushiEriksberg2);
            await _addRestaurantToCategoryService.AddRestaurantToCategory(addStreetfoodToKFC2);
            await _addRestaurantToCategoryService.AddRestaurantToCategory(addVegoToBommen2);
            await _addRestaurantToCategoryService.AddRestaurantToCategory(addStreetfoodToBastardBurger2);
            await _addRestaurantToCategoryService.AddRestaurantToCategory(addStreetfoodToThebarn2);
            await _addRestaurantToCategoryService.AddRestaurantToCategory(addAmericanToTheBarn2);
            await _addRestaurantToCategoryService.AddRestaurantToCategory(addAmericanToKFC2);
            await _addRestaurantToCategoryService.AddRestaurantToCategory(addPizzaToCityKebab2);
            await _addRestaurantToCategoryService.AddRestaurantToCategory(addSeaFoodToEriksbergsSushi2);
            await _addRestaurantToCategoryService.AddRestaurantToCategory(addVegetarianToPiga2);
            await _addRestaurantToCategoryService.AddRestaurantToCategory(addThaifoodtoBoomen2);








            return "Created seed";
        }

    }
}
