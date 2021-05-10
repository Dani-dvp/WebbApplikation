using Microsoft.AspNetCore.Mvc;
<<<<<<< HEAD
=======
using RestaurantReview.Application.Features.Reviews.Commands.CreateReview;
using RestaurantReview.Application.Features.Reviews.Commands.DeleteReview;
using RestaurantReview.Application.Features.Reviews.Commands.UpdateReview;
using RestaurantReview.Application.Features.Reviews.Queries.GetReviewListQuery;
using RestaurantReview.Application.Features.Reviews.Queries.GetReviewsListQuery;
using ResturantReview.Application.Features.Resturants.Commands.CreateReview;
using ResturantReview.Application.Features.Reviews.Commands.CreateReview;
using ResturantReview.Application.Features.Reviews.Commands.DeleteReview;
using ResturantReview.Application.Features.Reviews.Commands.UpdateReview;
>>>>>>> main
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RestaurantReview.API.Controllers
{


    [Route("api/[controller]")]
    [ApiController]
    public class ReviewController : ControllerBase
    {
        private readonly ICreateReviewService _createReviewService;
        private readonly IDeleteReviewService _deleteReviewService;
        private readonly IUpdateReviewService _updateReviewService;
        private readonly IReviewListQueryService _reviewListQueryService;

        public ReviewController(ICreateReviewService createReviewService, IDeleteReviewService deleteReviewService, IReviewListQueryService reviewListQueryService)
        {
            _createReviewService = createReviewService;
            _deleteReviewService = deleteReviewService;
            _reviewListQueryService = reviewListQueryService;


        }

        [HttpPost("CreateReview")]

        public async Task<ActionResult<CreateReviewResponse>> CreateReviewController([FromBody] CreateReviewCommand createReviewCommand)
        {

            return Ok(await _createReviewService.CreateReview(createReviewCommand));


        }

        [HttpDelete("DeleteReview")]

        public async Task<ActionResult<Guid>> DeleteReviewController([FromBody] DeleteReviewCommand deleteReviewCommand)
        {

            return Ok(await _deleteReviewService.DeleteReview(deleteReviewCommand));


        }


        [HttpPut("UpdateReview")]
<<<<<<< HEAD

        public async Task<ActionResult<UpdateReviewResponse>> UpdateReviewController([FromBody] UpdateReviewCommand updateReviewCommand)
        {

            return Ok(await _updateReviewService.UpdateReview(updateReviewCommand));

        }
=======
    
    public async Task<ActionResult<UpdateReviewResponse>> UpdateReviewController([FromBody] UpdateReviewCommand updateReviewCommand)
    {

        return Ok(await _updateReviewService.UpdateReview(updateReviewCommand));

    }
>>>>>>> main
        [HttpGet("ReviewList")]
        public async Task<ActionResult<List<ReviewListQueryResponse>>> GetReviewListQueryController()
        {

            return Ok(await _reviewListQueryService.GetReviewList());

        }
    }
}
