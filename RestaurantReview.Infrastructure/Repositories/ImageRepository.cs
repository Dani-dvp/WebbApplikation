
using AutoMapper;
using RestaurantReview.Domain.IRepositories;
using RestaurantReview.Domain.Models;
using System.Threading.Tasks;

namespace RestaurantReview.Infrastructure.Repositories
{
    public class ImageRepository : BaseRepository<Image>, IImageRepository
    {
        protected new readonly MyDbContext _myDbContext;
        protected new readonly IMapper _mapper;
        public ImageRepository(MyDbContext myDbContext, IMapper mapper) : base(myDbContext)
        {
            _myDbContext = myDbContext;
            _mapper = mapper;
        }

        public Image Add(Image image)
        {
             _myDbContext.Images.Add(image);
             _myDbContext.SaveChangesAsync();

            return image;
        }


    }
}
