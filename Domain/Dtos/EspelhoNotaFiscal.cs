namespace Domain.Dtos;

public class EspelhoNotaFiscal
{
    public string NumeroNota { get; set; }
    public DateTime DataHoraEmissao { get; set; }
    public string CodigoVerificacao { get; set; }
    public string MunicipioGaragem { get; set; }
    public string RpsNf { get; set; }
    public string SerieNf { get; set; }
    public string LinkValidacaoNotaFiscalPrefeitura { get; set; }
    public string DiscriminacaoServicos { get; set; }
    public decimal ValorTotalServico { get; set; }
    public string CodigoServico { get; set; }
    public decimal ValorTotalDeducoes { get; set; }
    public decimal BaseCalculo { get; set; }
    public decimal Aliquota { get; set; }
    public decimal ValorIss { get; set; }
    public decimal Credito { get; set; }

    public string PrestadorCpfCnpj { get; set; }
    public string PrestadorRazaoSocial { get; set; }
    public string PrestadorInscricaoMunicipal { get; set; }
    public string PrestadorLogradouro { get; set; }
    public string PrestadorBairro { get; set; }
    public string PrestadorCep { get; set; }
    public string PrestadorMunicipio { get; set; }
    public string PrestadorUF { get; set; }
    public string TomadorCpfCnpj { get; set; }
    public string TomadorRazaoSocial { get; set; }
    public string TomadorInscricaoMunicipal { get; set; }
    public string TomadorLogradouro { get; set; }
    public string TomadorBairro { get; set; }
    public string TomadorMunicipio { get; set; }
    public string TomadorUF { get; set; }
    public string TomadorEmail { get; set; }
    public string IntermediarioCpfCnpj { get; set; }
    public string IntermediarioRazaoSocial { get; set; }


}