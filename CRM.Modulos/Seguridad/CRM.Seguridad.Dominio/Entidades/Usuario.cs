using Microsoft.AspNetCore.Identity;

namespace CRM.Seguridad.Dominio.Entidades;

public sealed class Usuario : IdentityUser<Guid>
{
    public string Nombre { get; private set; } = string.Empty;

    public string Apellidos { get; private set; } = string.Empty;

    public bool Activo { get; private set; }

    public DateTime FechaCreacion { get; private set; }

    public DateTime? UltimoAcceso { get; private set; }

    private Usuario()
    {
    }

    public Usuario(
        string nombre,
        string apellidos,
        string correoElectronico)
    {
        Id = Guid.NewGuid();

        Nombre = nombre;

        Apellidos = apellidos;

        UserName = correoElectronico;

        Email = correoElectronico;

        NormalizedEmail = correoElectronico.ToUpperInvariant();

        NormalizedUserName = correoElectronico.ToUpperInvariant();

        FechaCreacion = DateTime.UtcNow;

        Activo = true;
    }

    public void ActualizarDatos(
        string nombre,
        string apellidos)
    {
        Nombre = nombre;
        Apellidos = apellidos;
    }

    public void RegistrarAcceso()
    {
        UltimoAcceso = DateTime.UtcNow;
    }

    public void Desactivar()
    {
        Activo = false;
    }

    public void Activar()
    {
        Activo = true;
    }
}