using DinkToPdf;
using DinkToPdf.Contracts;
using Domain.Dtos;
using Domain.Extensions;
using Domain.Interfaces.Services;
using System.Text;

namespace Application;

public class PdfService(IFileService fileService, IConverter converter) : IPdfService
{
    private readonly IFileService _fileService = fileService;

    public async Task<byte[]> GerarPdfEspelhoNotaAsync(EspelhoNotaFiscalDto dadosNotaFiscal)
    {
        var templateEspelhoNota = await _fileService.ObterTemplateNotaFiscalAsync();
        var logoBase64 = string.Empty;

        var parametrosEspelhoNota = dadosNotaFiscal.ObterParametrosEspelhoNota(logo: logoBase64);

        templateEspelhoNota = SubstituirParametros(templateEspelhoNota, parametrosEspelhoNota);

        return ConverterHtmlParaPdf(templateEspelhoNota);
    }

    private static string SubstituirParametros(string html, IDictionary<string, string> parametros)
    {
        var sb = new StringBuilder(html);

        foreach (var parametro in parametros)
        {
            sb.Replace(parametro.Key, parametro.Value);
        }

        return sb.ToString();
    }

    private byte[] ConverterHtmlParaPdf(string htmlContent)
    {
        var doc = new HtmlToPdfDocument()
        {
            GlobalSettings =
            {
                PaperSize = PaperKind.A4,
                Orientation = Orientation.Portrait,
                Margins = new MarginSettings() { Top = 5, Right = 5, Bottom = 5, Left = 7 },
                DPI = 320
            },
            Objects =
            {
                new ObjectSettings()
                {
                    HtmlContent = htmlContent,
                    PagesCount = true,
                    WebSettings = { DefaultEncoding = "utf-8" },
                }
            }
        };

        return converter.Convert(doc);
    }
}