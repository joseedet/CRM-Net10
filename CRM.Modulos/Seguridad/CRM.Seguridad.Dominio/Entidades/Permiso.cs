namespace CRM.Seguridad.Dominio.Entidades;

public sealed class Permiso
{
    public Guid Id { get; private set; }

    public string Codigo { get; private set; }

    public string Nombre { get; private set; }

    private Permiso()
    {
    }

    public Permiso(
        string codigo,
        string nombre)
    {
        Id = Guid.NewGuid();

        Codigo = codigo;

        Nombre = nombre;
    }

    public void ActualizarNombre(
        string nombre)
    {
        Nombre = nombre;
    }
}