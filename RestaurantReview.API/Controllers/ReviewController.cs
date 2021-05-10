using Microsoft.AspNetCore.Mvc;
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

        public async Task<ActionResult<UpdateReviewResponse>> UpdateReviewController([FromBody] UpdateReviewCommand updateReviewCommand)
        {

            return Ok(await _updateReviewService.UpdateReview(updateReviewCommand));

        }
        [HttpGet("ReviewList")]
        public async Task<ActionResult<List<ReviewListQueryResponse>>> GetReviewListQueryController()
        {

            return Ok(await _reviewListQueryService.GetReviewList());

        }
    }
}
