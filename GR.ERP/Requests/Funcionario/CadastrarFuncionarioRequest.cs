namespace GR.ERP.Api.Requests.Funcionario
{
    public class CadastrarFuncionarioRequest
    {
        public string Nome { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string? PontoReferencia { get; set; }
        public string CPF { get; set; }
        public string? RG { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
    }
}
