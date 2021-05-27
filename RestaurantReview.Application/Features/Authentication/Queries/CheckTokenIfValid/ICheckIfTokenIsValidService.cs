using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReview.Application.Features.Authentication.Queries.CheckTokenIfValid
{
    public interface ICheckIfTokenIsValidService
    {
        public bool ValidateCurrentToken(string token);
    }
}
