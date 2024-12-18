using Application;
using DinkToPdf;
using DinkToPdf.Contracts;
using Domain.Interfaces.Services;

namespace Api.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection RegistrarDependenciaServicos(this IServiceCollection services)
    {
        services.AddSingleton(typeof(IConverter), new SynchronizedConverter(new PdfTools()));

        services.AddSingleton<IPdfService, PdfService>();
        services.AddTransient<IFileService, FileService>();

        return services;
    }
}
