using Domain.Dtos;

namespace Domain.Interfaces.Services;

public interface IPdfService
{
    Task<byte[]> GerarPdfEspelhoNotaAsync(EspelhoNotaFiscalDto dadosNotaFiscal);
}
