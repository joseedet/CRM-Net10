namespace CRM.Seguridad.Dominio.Entidades;

public sealed class Usuario
{
    public Guid Id { get; private set; }

    public string Nombre { get; private set; }

    public string Apellidos { get; private set; }

    public string CorreoElectronico { get; private set; }

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

        CorreoElectronico = correoElectronico;

        Activo = true;

        FechaCreacion = DateTime.UtcNow;
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

    public void Activar()
    {
        Activo = true;
    }

    public void Desactivar()
    {
        Activo = false;
    }
}