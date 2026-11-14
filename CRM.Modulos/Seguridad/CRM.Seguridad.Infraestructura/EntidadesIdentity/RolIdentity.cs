using Microsoft.AspNetCore.Identity;

namespace CRM.Seguridad.Infraestructura.EntidadesIdentity;

/// <summary>
/// Entidad que representa un rol en el sistema de seguridad.
/// </summary>
/// <remarks>
/// Esta entidad se utiliza para definir los roles que pueden ser asignados a los usuarios dentro del sistema de seguridad. Cada rol tiene un identificador único, un nombre y una descripción que indica su propósito o función dentro del sistema.
/// </remarks>
public sealed class RolIdentity
    : IdentityRole<Guid>
{   

    /// <summary>
    /// Obtiene o establece la descripción del rol.
    /// </summary>
    /// <remarks>
    /// La descripción del rol proporciona información adicional sobre el propósito o la función del rol dentro del sistema de seguridad. Esta propiedad es opcional y puede ser utilizada para documentar el rol de manera más detallada.
    /// </remarks>
    public string Descripcion { get; set; } = string.Empty;
}