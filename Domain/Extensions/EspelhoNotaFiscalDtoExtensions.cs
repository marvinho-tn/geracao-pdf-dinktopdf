using Domain.Dtos;

namespace Domain.Extensions;

public static class EspelhoNotaFiscalDtoExtensions
{
    public static Dictionary<string, string> ObterParametrosEspelhoNota(this EspelhoNotaFiscalDto dadosEspelhoNota, string logo)
    {
        if (dadosEspelhoNota is null) return [];

        return new Dictionary<string, string>
        {
            { "[logo]", logo},

            { "[municipio_garagem]" , dadosEspelhoNota.MunicipioGaragem},
            { "[rps_nota]" , ObterInformacoesExibicaoRps(dadosEspelhoNota)},

            { "[numero_nota]", dadosEspelhoNota.NumeroNota },
            { "[data_hora_emissao]", dadosEspelhoNota.DataHoraEmissao.ToString("dd/MM/yyyy hh:MM:ss")},
            { "[protocolo]", dadosEspelhoNota.CodigoVerificacao },

            { "[cpf_cnpj_prestador]", dadosEspelhoNota.PrestadorServico.CpfCnpj },
            { "[razao_social_prestador]", dadosEspelhoNota.PrestadorServico.RazaoSocial },
            { "[logradouro_prestador]", dadosEspelhoNota.PrestadorServico.Logradouro },
            { "[bairro_prestador]", dadosEspelhoNota.PrestadorServico.Bairro },
            { "[cep_prestador]", dadosEspelhoNota.PrestadorServico.Cep},
            { "[municipio_prestador]", dadosEspelhoNota.PrestadorServico.Municipio},
            { "[inscricao_municipal_prestador]", dadosEspelhoNota.PrestadorServico.InscricaoMunicipal},
            { "[uf_prestador]", dadosEspelhoNota.PrestadorServico.UF},

            { "[razao_social_tomador]", dadosEspelhoNota.Tomador.RazaoSocial},
            { "[cpf_cnpj_tomador]", dadosEspelhoNota.Tomador.CpfCnpj},
            { "[logradouro_tomador]", dadosEspelhoNota.Tomador.Logradouro},
            { "[bairro_tomador]", dadosEspelhoNota.Tomador.Bairro},
            { "[municipio_tomador]", dadosEspelhoNota.Tomador.Municipio},
            { "[uf_tomador]", dadosEspelhoNota.Tomador.UF},
            { "[inscricao_municipal_tomador]", dadosEspelhoNota.Tomador.InscricaoMunicipal},
            { "[email_tomador]", dadosEspelhoNota.Tomador.Email},

            { "[cpfcnpj_intermediario]", dadosEspelhoNota.Intermediario.CpfCnpj},
            { "[razao_social_intermediario]", dadosEspelhoNota.Intermediario.RazaoSocial},

            { "[servicos]", dadosEspelhoNota.DiscriminacaoServicos},

            { "[valor_total_servico]",dadosEspelhoNota.ValorTotalServico.FormatarParaReal()},
            { "[codigo_servico]", dadosEspelhoNota.CodigoServico},
            { "[valor_total_deducoes]",dadosEspelhoNota.ValorTotalDeducoes.FormatarParaReal()},
            { "[valor_base_calculo]",dadosEspelhoNota.BaseCalculo.FormatarParaReal()},
            { "[valor_aliquota]", $"{dadosEspelhoNota.Aliquota}%" },
            { "[valor_iss]",dadosEspelhoNota.ValorIss.FormatarParaReal()},
            { "[valor_credito]",dadosEspelhoNota.Credito.FormatarParaReal()},

            { "[link_nf]" , dadosEspelhoNota.LinkValidacaoNotaFiscalPrefeitura}
        };
    }

    private static string ObterInformacoesExibicaoRps(EspelhoNotaFiscalDto dadosEspelhoNota)
    {
        if (dadosEspelhoNota.MunicipioGaragem.Equals("Porto Alegre", StringComparison.OrdinalIgnoreCase))
        {
            return string.Empty;
        }

        return $"RPS Nº {dadosEspelhoNota.RpsNf}  Serie {dadosEspelhoNota.SerieNf}, Emitido em {dadosEspelhoNota.DataHoraEmissao:dd/MM/yyyy}";
    }
}
