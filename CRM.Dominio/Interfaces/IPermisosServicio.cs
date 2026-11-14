namespace CRM.Dominio.Interfaces;

///<summary>    
/// Interfaz que define los métodos para verificar los permisos de un usuario en el sistema.
/// </summary>
///<remarks>
/// Esta interfaz proporciona un contrato para los servicios que necesitan verificar si un usuario tiene ciertos permisos dentro del sistema. Implementar esta interfaz permite a los desarrolladores determinar de manera centralizada y consistente si un usuario tiene los permisos necesarios para realizar acciones específicas, facilitando la gestión de la seguridad y el control de acceso dentro del sistema. Esto es esencial para garantizar que las operaciones y funcionalidades del sistema se realicen de acuerdo con los permisos y roles asignados a cada usuario, asegurando la integridad y la seguridad de los datos y recursos del sistema.   
/// </remarks>
public interface IPermisosServicio
{
    ///<summary>    
    /// Método que verifica si el usuario tiene un permiso específico.
    /// </summary>
    ///<param name="permiso">El permiso que se desea verificar.</param>
    ///<returns>
    /// Devuelve true si el usuario tiene el permiso especificado; de lo contrario, devuelve false.
    /// </returns>
    ///<remarks>
    /// Este método permite a los desarrolladores verificar si el usuario autenticado tiene un permiso específico dentro del sistema, lo que es fundamental para controlar el acceso a funcionalidades y recursos específicos. Al implementar este método, los desarrolladores pueden determinar qué acciones puede realizar el usuario dentro del sistema, asegurando que solo los usuarios con los permisos adecuados puedan acceder a ciertas operaciones o áreas del sistema. Esto contribuye a la seguridad y la integridad del sistema, permitiendo una gestión efectiva de los roles y permisos de los usuarios, y garantizando que las políticas de acceso se apliquen de manera consistente en toda la aplicación.
    /// </remarks>
    bool TienePermiso(string permiso);
}