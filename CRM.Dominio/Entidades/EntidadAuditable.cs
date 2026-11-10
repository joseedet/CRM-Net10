using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRM.Dominio.Entidades;

public abstract class EntidadAuditable : Entidad
{
    public DateTime FechaCreacion { get; protected set; }

    public string UsuarioCreacion { get; protected set; } = string.Empty;

    public DateTime? FechaModificacion { get; protected set; }

    public string? UsuarioModificacion { get; protected set; }

    public bool Eliminado { get; protected set; }

    public DateTime? FechaEliminacion { get; protected set; }

    public string? UsuarioEliminacion { get; protected set; }

    public Guid? TenantId { get; protected set; }

    protected EntidadAuditable()
    {
        FechaCreacion = DateTime.UtcNow;
    }

    public virtual void MarcarComoEliminado(string usuario)
    {
        Eliminado = true;
        FechaEliminacion = DateTime.UtcNow;
        UsuarioEliminacion = usuario;
    }

    public virtual void Restaurar()
    {
        Eliminado = false;
        FechaEliminacion = null;
        UsuarioEliminacion = null;
    }

    protected void RegistrarModificacion(string usuario)
    {
        FechaModificacion = DateTime.UtcNow;
        UsuarioModificacion = usuario;
    }
}