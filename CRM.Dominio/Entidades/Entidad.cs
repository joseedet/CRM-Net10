using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRM.Dominio.EventosDominio;

namespace CRM.Dominio.Entidades;

public abstract class Entidad
{
    private readonly List<IEventoDominio> _eventosDominio = [];

    public Guid Id { get; protected set; }

    public IReadOnlyCollection<IEventoDominio> EventosDominio =>
        _eventosDominio.AsReadOnly();

    protected Entidad()
    {
        Id = Guid.NewGuid();
    }

    protected void AgregarEventoDominio(
        IEventoDominio eventoDominio)
    {
        _eventosDominio.Add(eventoDominio);
    }

    public void LimpiarEventosDominio()
    {
        _eventosDominio.Clear();
    }
}
