using CQRSProject.Application.Services.WordMatrix;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace CQRSProject.Application;

/// <summary>
///     Provides extension methods for configuring dependency injection services.
/// </summary>
public static class DependencyInjection
{
    /// <summary>
    ///     Adds project-specific services to the provided <see cref="IServiceCollection"/>.
    /// </summary>
    /// <param name="services">The <see cref="IServiceCollection"/> To add services to.</param>
    /// <returns>The <see cref="IServiceCollection"/> With the added services.</returns>
    public static IServiceCollection AddProjectService(this IServiceCollection services)
    {
        services.AddValidatorsFromAssembly(ProjectAssemblyReference.Assembly);

        //CQRS CONFIG
        services.AddMediatR(mediatr =>
        {
            //Add all IRequestHandlers defined in this API
            mediatr.RegisterServicesFromAssembly(ProjectAssemblyReference.Assembly);
        });

        //register Logger Mapper
        services.AddSingleton<IWordMatrix, WordMatrix>();

        return services;
    }
}

