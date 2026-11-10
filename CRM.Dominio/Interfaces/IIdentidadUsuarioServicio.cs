namespace CRM.Dominio.Interfaces;

public interface IIdentidadUsuarioServicio
{
    bool EstaAutenticado();

    Guid ObtenerUsuarioId();

    string ObtenerNombreUsuario();

    IEnumerable<string> ObtenerPermisos();
}