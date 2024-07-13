using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Booking.SqlPersistence;

public static class DependencyInjection
{
    public static IServiceCollection AddPersistence(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddMySqlConnection(configuration);

        return services;
    }

    private static IServiceCollection AddMySqlConnection(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        return services;
    }
}