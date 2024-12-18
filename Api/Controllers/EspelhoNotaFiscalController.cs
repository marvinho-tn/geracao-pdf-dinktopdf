using Domain.Dtos;
using Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Api.Controllers;

[ApiController]
[Route("api/v1/espelho-notas")]
public class EspelhoNotaFiscalController(IPdfService PdfService,
                                         ILogger<EspelhoNotaFiscalController> Logger) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> Post([FromBody] EspelhoNotaFiscalDto model)
    {
        try
        {
            var espelhoNota = await PdfService.GerarPdfEspelhoNotaAsync(model);
            return File(espelhoNota, "application/pdf");
        }
        catch (Exception ex)
        {
            Logger.LogError(ex, "Falha ao gerar espelho nota. NumeroNota: {NumeroNota}", model.NumeroNota);
            return StatusCode((int)HttpStatusCode.InternalServerError, "Falha ao realizar operação");
        }
    }
}