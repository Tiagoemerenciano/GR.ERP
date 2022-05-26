namespace GR.ERP.Dominio.Funcionario
{
    public class Endereco : EntidadeAuditavel
    {
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string PontoReferencia { get; set; }
    }
}
