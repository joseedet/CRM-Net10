namespace CRM.Seguridad.Infraestructura.EntidadesIdentity;

/// <summary>
/// Entidad que representa un permiso en el sistema.
/// </summary>
/// <remarks>
/// Esta entidad se utiliza para definir los permisos que pueden ser asignados a los roles y usuarios dentro del sistema de seguridad. Cada permiso tiene un identificador único, un código que lo representa y un nombre descriptivo.
/// </remarks>
public sealed class PermisoEntity
{
    /// <summary>  
    /// Obtiene o establece el identificador único del permiso.  
    /// </summary>
    /// <remarks>
    /// Este identificador se utiliza para diferenciar de manera única cada permiso dentro del sistema.
    /// </remarks>
    public Guid Id { get; set; }

    /// <summary>
    /// Obtiene o establece el código del permiso.
    /// </summary>
    /// <remarks>
    /// El código del permiso es un identificador único que representa el permiso dentro del sistema.
    /// </remarks>
    public string Codigo { get; set; } = string.Empty;

    /// <summary>
    /// Obtiene o establece el nombre del permiso.
    /// </summary>
    /// <remarks>
    /// El nombre del permiso es una descripción legible que indica la función o acción que el permiso permite realizar dentro del sistema.
    /// </remarks>
    public string Nombre { get; set; } = string.Empty;
}