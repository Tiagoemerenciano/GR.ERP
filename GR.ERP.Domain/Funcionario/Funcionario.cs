namespace GR.ERP.Dominio.Funcionario;

public class Funcionario : EntidadeAuditavel
{
    public string Nome { get; set; } = string.Empty;
    public Endereco Endereco { get; set; } = new();
    public Documento Documentos { get; set; } = new();
    public CredenciaisAcesso Credenciais { get; set; } = new();
}