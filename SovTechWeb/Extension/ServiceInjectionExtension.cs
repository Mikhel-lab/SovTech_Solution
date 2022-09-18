using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SovTechWeb.Service.Implementation;
using SovTechWeb.Service.Interface;
using SovTechWeb.Service.Response;
using System;
using System.Net.Http.Headers;
using System.Net.Mime;

namespace SovTechWeb.Extension
{
    public static class ServiceInjectionExtension
    {
        public static IServiceCollection AddInjections(this IServiceCollection services)
        {
            services.AddScoped(typeof(CategoriesResponse));
            services.AddScoped(typeof(CategoryDetailResponse));
            services.AddScoped(typeof(PeopleResponse));
            services.AddScoped(typeof(SearchDetailResponse));
            return services;
        }

        public static IServiceCollection AddHttpInjections(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddHttpClient<ISOvTechService, SovTechService>("GeneralService", client =>
            {
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(MediaTypeNames.Application.Json));
                client.BaseAddress = new Uri(configuration.GetValue<string>("SovTechService:BaseAddress"));
            });

           
            return services;
        }
    }
}
