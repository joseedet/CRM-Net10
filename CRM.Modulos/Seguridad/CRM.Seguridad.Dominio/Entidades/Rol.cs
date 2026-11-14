

namespace CRM.Seguridad.Dominio.Entidades;

public sealed class Rol 
{
    public Guid Id { get; private set; }
    public string Nombre { get; private set; }
    public string Descripcion { get; private set; } = string.Empty;   
   

    private Rol()
    {
    }

    public Rol(
        string nombre,
        string descripcion)
    {
        Id = Guid.NewGuid();

        Nombre = nombre;
       
        Descripcion = descripcion;
    }

    public void ActualizarDescripcion(
        string descripcion)
    {
        Descripcion = descripcion;
    }
}