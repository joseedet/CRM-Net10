namespace CRM.Dominio.Constantes;

///<summary>    
/// Clase estática que contiene constantes que representan los roles del sistema.   
/// </summary>
///<remarks>
/// Esta clase proporciona una forma centralizada de definir los roles del sistema, lo que facilita su  uso en toda la aplicación. Los roles definidos aquí se utilizan para controlar el acceso a diferentes funcionalidades y recursos dentro del sistema, asegurando que solo los usuarios con los permisos adecuados puedan realizar ciertas acciones.     
/// </remarks>

public static class RolesSistema
{
    /// <summary>
    /// Constante que representa el rol de Administrador en el sistema.
    /// </summary>
    /// <remarks>
    /// El rol de Administrador tiene permisos completos dentro del sistema, incluyendo la gestión de usuarios, roles y configuraciones. Este rol es esencial para la administración y mantenimiento del sistema.
    /// </remarks>
    public const string Administrador = "Administrador";

    /// <summary>
    /// Constante que representa el rol de Director Comercial en el sistema.
    /// </summary>
    /// <remarks>
    /// El rol de Director Comercial tiene permisos específicos relacionados con la gestión comercial y la supervisión de las actividades comerciales dentro del sistema. Este rol es crucial para la toma de decisiones estratégicas en el área comercial.
    /// </remarks>
    public const string DirectorComercial = "DirectorComercial";

    /// <summary>
    /// Constante que representa el rol de Comercial en el sistema.
    /// </summary>
    /// <remarks>
    /// El rol de Comercial tiene permisos relacionados con la gestión de clientes, ventas y actividades comerciales. Este rol es fundamental para la ejecución de las operaciones comerciales diarias dentro del sistema.
    /// </remarks>
    public const string Comercial = "Comercial";

    /// <summary>
    /// Constante que representa el rol de Consulta en el sistema.  
    /// </summary>
    /// <remarks>
    /// El rol de Consulta tiene permisos limitados para visualizar información del sistema sin realizar modificaciones.
    /// </remarks>
    public const string Consulta = "Consulta";
}