using AutoMapper;
using ResturantReview.Domain.Infreastructure;
using ResturantReview.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ResturantReview.Application.Features.Resturants.Commands.CreateResturant
{
    public class CreateResturantHandler
    {
        //Innehåller kod för metoder, sparar detta sedan genom att kalla på Repository för sin klass

        //Får inte returnera en vanlig "Model" Måste Returner en ResponsTyp med innehållet man vill visa.
        private readonly IMapper _mapper;
        private readonly IResturantRepository _resturantRepository;

        public CreateResturantHandler()
        {
        }

        

        public CreateResturantHandler(IMapper mapper , IResturantRepository resturantRepository)
        {
            _mapper = mapper;
            _resturantRepository = resturantRepository;
        }

        public async Task<CreateResturantResponse>  CreateResturant(CreateResturantCommand createResturantCommand )
        {
            var resturant = new Resturant()
            {
                ResturantName = createResturantCommand.ResturantName,
                Category = createResturantCommand.Category,
                StreetPhoto = createResturantCommand.StreetPhoto,
                GoogleMapsPhoto = createResturantCommand.GoogleMapsPhoto,
                ResturantLink = createResturantCommand.ResturantLink,
                Reviews = new List<Review>(),
                ResturantID = Guid.NewGuid()

            };

            resturant = await _resturantRepository.AddAsync(resturant);

            var resturantRespone = _mapper.Map<CreateResturantResponse>(resturant);

            return resturantRespone;
        }

    }
}
