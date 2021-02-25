using System.Configuration;
using AuthenticatorServices.Models;
using AuthenticatorServices.Services;
using AuthenticatorServices.Services.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AuthenticatorServices.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddAuthenticationServices(this IServiceCollection services, IConfigurationSection authorisationSettings)
        {
            services.Configure<AuthenticatorServiceModel>(authorisationSettings);
            services.AddSingleton<AuthenticatorServiceModel>();
            services.AddTransient<IAuthTokenService, AuthTokenService>();
            services.AddTransient<IAuthTokenService, AuthTokenService>();
            services.AddMemoryCache();
            services.AddLogging();
        }
    }
}

