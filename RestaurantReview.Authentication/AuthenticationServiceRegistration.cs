using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using RestaurantReview.Domain.AuthenticationModels;
using System;
using System.Text;

namespace RestaurantReview.Authentication
{
    public static class AuthenticationServiceRegistration
    {
        public static void AddAuthenticationServices(this IServiceCollection services, IConfiguration configuration)
        {
           


        }
    }
}
