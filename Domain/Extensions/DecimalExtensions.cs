using System.Globalization;

namespace Domain.Extensions;

public static class DecimalExtensions
{
    private static readonly CultureInfo CulturaBrasileira = new("pt-BR");
    public static string FormatarParaReal(this decimal valor) => valor.ToString("C", CulturaBrasileira);
}
