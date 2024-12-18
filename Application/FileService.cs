using Domain.Interfaces.Services;

namespace Application;

public class FileService : IFileService
{
    private static string _templateNotaFiscalCache;

    public async Task<string> ObterTemplateNotaFiscalAsync()
    {
        _templateNotaFiscalCache ??= await CarregarTemplateNotaFiscalAsync();
        return _templateNotaFiscalCache;
    }

    private static async Task<string> CarregarTemplateNotaFiscalAsync()
    {
        var caminhoTemplateEspelhoNota = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "template-espelho-nota-fiscal" +
            ".html");
        return await File.ReadAllTextAsync(caminhoTemplateEspelhoNota);
    }
}
