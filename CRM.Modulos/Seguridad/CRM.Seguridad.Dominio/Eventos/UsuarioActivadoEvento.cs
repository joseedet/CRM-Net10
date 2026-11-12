using CRM.Dominio.EventosDominio;

namespace CRM.Seguridad.Dominio.Eventos;

public sealed class UsuarioActivadoEvento
    : EventoDominio
{
    public Guid UsuarioId { get; }

    public UsuarioActivadoEvento(Guid usuarioId)
    {
        UsuarioId = usuarioId;
    }
}