namespace Domain.Entidades;

public class Usuario
{
    public Guid Id { get; private set; }
    public string Nome { get; private set; }
    public string CidadeResidencia { get; private set; }
    public string? CidadeTrabalho { get; private set; }
    public TimeOnly HorarioNotificacao { get; private set; }
    public bool Ativo { get; private set; }
    
    private Usuario() { } //Isso server para o EF (Porque o EF Core precisa conseguir instanciar a entidade quando ele lê dados do banco.)
    
    public Usuario(
        string nome,
        string telefone,
        string cidadeResidencia,
        string? cidadCidadeTrabalho,
        TimeOnly horarioNotificacao)
    {
        Id = Guid.NewGuid();
        nome = nome;
        telefone = telefone;
        CidadeResidencia = cidadeResidencia;
        CidadeTrabalho = cidadCidadeTrabalho;
        HorarioNotificacao = horarioNotificacao;
        Ativo = true;
    }

    public void Desativar()
    {
        Ativo = false;
    }

    public void AtualizarHorario(TimeOnly novoHorario)
    {
        HorarioNotificacao = novoHorario;
    }
}