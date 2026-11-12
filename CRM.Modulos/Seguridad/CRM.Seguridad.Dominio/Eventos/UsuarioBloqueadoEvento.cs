using CRM.Dominio.EventosDominio;

namespace CRM.Seguridad.Dominio.Eventos;

public sealed class UsuarioBloqueadoEvento
    : EventoDominio
{
    public Guid UsuarioId { get; }

    public UsuarioBloqueadoEvento(Guid usuarioId)
    {
        UsuarioId = usuarioId;
    }
}