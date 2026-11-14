namespace CRM.Dominio.Interfaces;

///<summary>    
/// Interfaz que define los métodos para obtener información sobre la identidad del usuario autenticado en el sistema.
/// </summary>
///<remarks>
/// Esta interfaz proporciona un contrato para los servicios que necesitan acceder a la información de identidad del usuario autenticado, incluyendo su estado de autenticación, identificador único, nombre de usuario y permisos asociados. Implementar esta interfaz permite a los desarrolladores obtener de manera centralizada y consistente la información relevante sobre el usuario, facilitando la gestión de la seguridad y el control de acceso dentro del sistema. Esto es esencial para garantizar que las operaciones y funcionalidades del sistema se realicen de acuerdo con los permisos y roles asignados a cada usuario, asegurando la integridad y la seguridad de los datos y recursos del sistema.   
/// </remarks>
public interface IIdentidadUsuarioServicio
{
    ///<summary>    
    /// Método que indica si el usuario está autenticado en el sistema.
    /// </summary>
    ///<remarks>
    /// Este método permite verificar si el usuario actual ha sido autenticado correctamente en el sistema, lo que es fundamental para controlar el acceso a las funcionalidades y recursos del sistema. Al implementar este método, los desarrolladores pueden determinar si el usuario tiene una sesión activa y si puede realizar acciones que requieren autenticación, asegurando que solo los usuarios autorizados puedan acceder a ciertas áreas o realizar operaciones específicas. Esto contribuye a la seguridad general del sistema y a la protección de los datos y recursos sensibles.
    /// </remarks>
    bool EstaAutenticado();

    ///<summary>    
    /// Método que obtiene el identificador único del usuario autenticado.
    /// </summary>
    ///<remarks>
    /// Este método permite recuperar el identificador único del usuario que ha sido autenticado en el sistema, lo que es esencial para asociar acciones y operaciones con un usuario específico. Al implementar este método, los desarrolladores pueden rastrear y registrar las actividades del usuario, facilitando la auditoría y el seguimiento de cambios dentro del sistema. Esto es importante para garantizar la responsabilidad y la trazabilidad de las acciones realizadas por los usuarios, así como para implementar controles de acceso basados en la identidad del usuario, asegurando que solo los usuarios autorizados puedan realizar ciertas operaciones.
    /// </remarks>
    Guid ObtenerUsuarioId();

    ///<summary>    
    /// Método que obtiene el nombre del usuario autenticado.
    /// </summary>
    ///<remarks>
    /// Este método permite recuperar el nombre del usuario que ha sido autenticado en el sistema, lo que es útil para personalizar la experiencia del usuario y para mostrar información relevante en la interfaz de usuario. Al implementar este método, los desarrolladores pueden acceder al nombre del usuario para fines de presentación, notificaciones y comunicación dentro del sistema, mejorando la interacción y la usabilidad de la aplicación. Además, conocer el nombre del usuario autenticado facilita la identificación de los usuarios en registros y auditorías, contribuyendo a la transparencia y la responsabilidad en el uso del sistema.
    /// </remarks>
    string ObtenerNombreUsuario();

    ///<summary>    
    /// Método que obtiene los permisos asociados al usuario autenticado.
    /// </summary>
    ///<remarks>
    /// Este método permite recuperar la lista de permisos que están asociados al usuario autenticado en el sistema, lo que es fundamental para controlar el acceso a funcionalidades y recursos específicos. Al implementar este método, los desarrolladores pueden determinar qué acciones puede realizar el usuario dentro del sistema, asegurando que solo los usuarios con los permisos adecuados puedan acceder a ciertas operaciones o áreas del sistema. Esto contribuye a la seguridad y la integridad del sistema, permitiendo una gestión efectiva de los roles y permisos de los usuarios, y garantizando que las políticas de acceso se apliquen de manera consistente en toda la aplicación.
    /// </remarks>
    IEnumerable<string> ObtenerPermisos();
}