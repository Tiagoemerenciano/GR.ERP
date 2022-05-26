namespace GR.ERP.Aplicacao.Interfaces.Funcionario
{
    public interface IFuncionarioService
    {
        Task CadastrarFuncionario(Dominio.Funcionario.Funcionario funcionario);
        Task ConsultarFuncionario(int id);
        Task ConsultarFuncionarios();
        Task ExcluirFuncionario();
    }
}
