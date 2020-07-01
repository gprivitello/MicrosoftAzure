﻿using CarsIsland.Reservation.Infrastructure.Configuration;
using CarsIsland.Reservation.Infrastructure.Configuration.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace CarsIsland.Reservation.API.Core.DependencyInjection
{
    public static class ConfigurationServiceCollectionExtensions
    {
        public static IServiceCollection AddAppConfiguration(this IServiceCollection services, IConfiguration config)
        {
            services.Configure<RedisConfiguration>(config.GetSection("Redis"));
            services.AddSingleton<IValidateOptions<RedisConfiguration>, RedisConfigurationValidation>();
            var redisConfiguration = services.BuildServiceProvider().GetRequiredService<IOptions<RedisConfiguration>>().Value;
            services.AddSingleton<IRedisConfiguration>(redisConfiguration);

            return services;
        }
    }
}