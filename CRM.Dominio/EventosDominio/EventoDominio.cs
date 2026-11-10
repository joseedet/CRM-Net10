
namespace CRM.Dominio.EventosDominio;

namespace CRM.Dominio.EventosDominio;

public abstract class EventoDominio : IEventoDominio
{
    public DateTime FechaOcurrencia { get; }

    protected EventoDominio()
    {
        FechaOcurrencia = DateTime.UtcNow;
    }
}