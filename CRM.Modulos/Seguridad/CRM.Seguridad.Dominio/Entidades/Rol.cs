using Microsoft.AspNetCore.Identity;

namespace CRM.Seguridad.Dominio.Entidades;

public sealed class Rol : IdentityRole<Guid>
{
    public string Descripcion { get; private set; } = string.Empty;

    private Rol()
    {
    }

    public Rol(
        string nombre,
        string descripcion)
    {
        Id = Guid.NewGuid();

        Name = nombre;

        NormalizedName = nombre.ToUpperInvariant();

        Descripcion = descripcion;
    }

    public void ActualizarDescripcion(
        string descripcion)
    {
        Descripcion = descripcion;
    }
}