using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReview.Application.ValidationResponse
{ 
public class BaseResponse
{
    public BaseResponse()
    {
        Success = true;
    }

    public BaseResponse(string message = null)
    {
        Success = true;
        Message = message;
    }

    public BaseResponse(string message, bool successs)
    {
        Success = successs;
        Message = message;

    }

    public bool Success { get; set; }
    public string Message { get; set; }
    public List<string> ValidationErrors { get; set; }
}
}