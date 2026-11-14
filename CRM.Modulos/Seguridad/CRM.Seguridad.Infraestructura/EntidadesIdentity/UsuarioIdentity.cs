using Microsoft.AspNetCore.Identity;

namespace CRM.Seguridad.Infraestructura.EntidadesIdentity;

/// <summary>
/// Entidad que representa un usuario en el sistema de seguridad.
/// </summary>
/// <remarks>
/// Esta entidad se utiliza para definir los usuarios que pueden acceder al sistema de seguridad. Cada usuario tiene un identificador único, un nombre, apellidos, estado de actividad, fecha de creación y fecha del último acceso. Esta información es esencial para la gestión de usuarios y la seguridad del sistema.
/// </remarks>
public sealed class UsuarioIdentity
    : IdentityUser<Guid>
{
    /// <summary>
    /// Obtiene o establece el nombre del usuario.
    /// </summary>  
    /// <remarks>
    /// El nombre del usuario es una propiedad obligatoria que representa el primer nombre del usuario dentro del sistema de seguridad. Esta propiedad tiene una longitud máxima de 150 caracteres y es utilizada para identificar al usuario de manera más personal y amigable.
    /// </remarks>
    public string Nombre { get; set; } = string.Empty;

    /// <summary>
    /// Obtiene o establece los apellidos del usuario.
    /// </summary>
    /// <remarks>
    /// Los apellidos del usuario son una propiedad obligatoria que representa los apellidos del usuario dentro del sistema de seguridad. Esta propiedad tiene una longitud máxima de 250 caracteres y se utiliza junto con el nombre para identificar al usuario de manera completa y formal.
    /// </remarks>
    public string Apellidos { get; set; } = string.Empty;

    /// <summary>   
    /// Obtiene o establece el estado de actividad del usuario.
    /// </summary>
    /// <remarks>
    /// La propiedad Activo indica si el usuario está activo o inactivo dentro del sistema de seguridad. Un usuario activo puede acceder al sistema, mientras que un usuario inactivo no tiene permisos de acceso. Esta propiedad es esencial para la gestión de usuarios y la seguridad del sistema.
    /// </remarks>
    public bool Activo { get; set; }

    /// <summary>
    /// Obtiene o establece la fecha de creación del usuario.
    /// </summary>
    /// <remarks>
    /// La propiedad FechaCreacion almacena la fecha y hora en que el usuario fue creado dentro del sistema de seguridad. Esta información es útil para auditorías y seguimiento de la actividad del usuario.
    /// </remarks>
    public DateTime FechaCreacion { get; set; }

    /// <summary>
    /// Obtiene o establece la fecha del último acceso del usuario.
    /// </summary>
    /// <remarks>
    /// La propiedad UltimoAcceso almacena la fecha y hora del último acceso del usuario al sistema de seguridad. Esta información es útil para monitorear la actividad del usuario y detectar posibles problemas de seguridad. Esta propiedad es opcional y puede ser nula si el usuario nunca ha accedido al sistema.
    /// </remarks>
    public DateTime? UltimoAcceso { get; set; }
}