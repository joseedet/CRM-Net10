using CRM.Dominio.EventosDominio;

namespace CRM.Seguridad.Dominio.Eventos;

public sealed class UsuarioCreadoEvento
    : EventoDominio
{
    public Guid UsuarioId { get; }

    public UsuarioCreadoEvento(Guid usuarioId)
    {
        UsuarioId = usuarioId;
    }
}