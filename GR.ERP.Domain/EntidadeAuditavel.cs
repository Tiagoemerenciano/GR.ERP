namespace GR.ERP.Dominio
{
    public abstract class EntidadeAuditavel
    {
        public virtual int Id { get; set; }
        public virtual DateTime DataCadastro { get; set; } = DateTime.Now;
        public virtual DateTime DataAtualizacao { get; set; } = DateTime.Now;
    }
}
