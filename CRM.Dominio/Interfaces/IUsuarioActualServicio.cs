namespace CRM.Dominio.Interfaces;

/// <summary>
/// Interfaz que define los métodos para obtener información sobre el usuario actual en el sistema. 
/// </summary>
/// <remarks>
/// Esta interfaz proporciona un contrato para los servicios que necesitan acceder a la información del usuario actual, incluyendo su identificador único y nombre de usuario. Implementar esta interfaz permite a los desarrolladores obtener de manera centralizada y consistente la información relevante sobre el usuario, facilitando la gestión de la seguridad y el control de acceso dentro del sistema. Esto es esencial para garantizar que las operaciones y funcionalidades del sistema se realicen de acuerdo con los permisos y roles asignados a cada usuario, asegurando la integridad y la seguridad de los datos y recursos del sistema.   
/// </remarks>  
public interface IUsuarioActualServicio
{
    /// <summary>
    /// Método que obtiene el identificador único del usuario actual.
    /// </summary>
    /// <remarks>
    /// Este método permite recuperar el identificador único del usuario que está actualmente autenticado en el sistema, lo que es esencial para asociar acciones y operaciones con un usuario específico. Al implementar este método, los desarrolladores pueden rastrear y registrar las actividades del usuario, facilitando la auditoría y el seguimiento de cambios dentro del sistema. Esto es importante para garantizar la responsabilidad y la trazabilidad de las acciones realizadas por los usuarios, así como para implementar controles de acceso basados en la identidad del usuario, asegurando que solo los usuarios autorizados puedan realizar ciertas operaciones.
    /// </remarks
    Guid ObtenerUsuarioId();

    /// <summary>
    /// Método que obtiene el nombre del usuario actual.
    /// </summary>
    /// <remarks>
    /// Este método permite recuperar el nombre del usuario que está actualmente autenticado en el sistema, lo que es útil para personalizar la experiencia del usuario y para mostrar información relevante en la interfaz de usuario. Al implementar este método, los desarrolladores pueden acceder al nombre del usuario para fines de presentación, notificaciones y comunicación dentro del sistema, mejorando la interacción y la usabilidad de la aplicación. Además, conocer el nombre del usuario actual facilita la identificación de los usuarios en registros y auditorías, contribuyendo a la transparencia y la responsabilidad en el uso del sistema.
    /// </remarks>
    string ObtenerNombreUsuario();
}