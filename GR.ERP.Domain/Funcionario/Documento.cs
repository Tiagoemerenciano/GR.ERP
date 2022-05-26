namespace GR.ERP.Dominio.Funcionario
{
    public class Documento : EntidadeAuditavel
    {
        public string CPF { get; set; }
        public string? RG { get; set; }
    }
}
