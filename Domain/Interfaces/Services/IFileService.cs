namespace Domain.Interfaces.Services;

public interface IFileService
{
    Task<string> ObterTemplateNotaFiscalAsync();
}
