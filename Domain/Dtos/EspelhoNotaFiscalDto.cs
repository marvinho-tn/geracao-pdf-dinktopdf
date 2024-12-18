namespace Domain.Dtos;

public class EspelhoNotaFiscalDto
{
    public EspelhoNotaFiscalDto()
    {

    }

    public EspelhoNotaFiscalDto(EspelhoNotaFiscal espelhoNotaFiscal)
    {
        NumeroNota = espelhoNotaFiscal.NumeroNota;
        DataHoraEmissao = espelhoNotaFiscal.DataHoraEmissao;
        CodigoVerificacao = espelhoNotaFiscal.CodigoVerificacao;
        MunicipioGaragem = espelhoNotaFiscal.MunicipioGaragem;
        RpsNf = espelhoNotaFiscal.RpsNf;
        SerieNf = espelhoNotaFiscal.SerieNf;
        LinkValidacaoNotaFiscalPrefeitura = espelhoNotaFiscal.LinkValidacaoNotaFiscalPrefeitura;
        DiscriminacaoServicos = espelhoNotaFiscal.DiscriminacaoServicos;
        ValorTotalServico = espelhoNotaFiscal.ValorTotalServico;
        CodigoServico = espelhoNotaFiscal.CodigoServico;
        ValorTotalDeducoes = espelhoNotaFiscal.ValorTotalDeducoes;
        BaseCalculo = espelhoNotaFiscal.BaseCalculo;
        Aliquota = espelhoNotaFiscal.Aliquota;
        ValorIss = espelhoNotaFiscal.ValorIss;
        Credito = espelhoNotaFiscal.Credito;
        PrestadorServico = new PrestadorServicoDto()
        {
            Bairro = espelhoNotaFiscal.PrestadorBairro,
            Cep = espelhoNotaFiscal.PrestadorCep,
            CpfCnpj = espelhoNotaFiscal.PrestadorCpfCnpj,
            InscricaoMunicipal = espelhoNotaFiscal.PrestadorInscricaoMunicipal,
            Logradouro = espelhoNotaFiscal.PrestadorLogradouro,
            Municipio = espelhoNotaFiscal.PrestadorMunicipio,
            RazaoSocial = espelhoNotaFiscal.PrestadorRazaoSocial,
            UF = espelhoNotaFiscal.PrestadorUF,
        };
        Tomador = new TomadorDto()
        {
            Bairro = espelhoNotaFiscal.TomadorBairro,
            CpfCnpj = espelhoNotaFiscal.TomadorCpfCnpj,
            Email = espelhoNotaFiscal.TomadorEmail,
            InscricaoMunicipal = espelhoNotaFiscal.TomadorInscricaoMunicipal,
            Logradouro = espelhoNotaFiscal.TomadorLogradouro,
            Municipio = espelhoNotaFiscal.TomadorMunicipio,
            RazaoSocial = espelhoNotaFiscal.TomadorRazaoSocial,
            UF = espelhoNotaFiscal.TomadorUF
        };
        Intermediario = new IntermediarioServicoDto()
        {
            CpfCnpj = espelhoNotaFiscal.IntermediarioCpfCnpj,
            RazaoSocial = espelhoNotaFiscal.IntermediarioRazaoSocial
        };
    }

    public string NumeroNota { get; set; }
    public DateTime DataHoraEmissao { get; set; }
    public string CodigoVerificacao { get; set; }
    public string MunicipioGaragem { get; set; }
    public string RpsNf { get; set; }
    public string SerieNf { get; set; }
    public string LinkValidacaoNotaFiscalPrefeitura { get; set; }
    public PrestadorServicoDto PrestadorServico { get; set; }
    public TomadorDto Tomador { get; set; }
    public IntermediarioServicoDto Intermediario { get; set; }
    public string DiscriminacaoServicos { get; set; }
    public decimal ValorTotalServico { get; set; }
    public string CodigoServico { get; set; }
    public decimal ValorTotalDeducoes { get; set; }
    public decimal BaseCalculo { get; set; }
    public decimal Aliquota { get; set; }
    public decimal ValorIss { get; set; }
    public decimal Credito { get; set; }
}