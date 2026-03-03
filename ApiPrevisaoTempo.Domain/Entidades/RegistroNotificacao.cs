namespace Domain.Entidades;

public class RegistroNotificacao
{
    public Guid Id { get; private set; }
    public Guid UsuarioId { get; private set; }
    public string Cidade {get; private set;}
    public DateTime EnviadoEm {get; private set;}
    public string Mensagem { get; private set; }

    private RegistroNotificacao() { } //Contrutor vazio para o EF

    public RegistroNotificacao(Guid usuarioId, string cidade, string mensagem)
    {
        Id = Guid.NewGuid();
        UsuarioId = usuarioId;
        Cidade = cidade;
        Mensagem = mensagem;
        EnviadoEm = DateTime.UtcNow;
    }
}