
namespace CRM.Dominio.Constantes;
/// <summary>
/// Contiene los esquemas de base de datos utilizados en la aplicación.
/// </summary> 
/// <remarks>
/// Esta clase proporciona constantes que representan los nombres de los esquemas de base de datos utilizados en la aplicación. Cada constante corresponde a un esquema específico que organiza las tablas relacionadas con diferentes módulos o funcionalidades de la aplicación.
/// </remarks>
public static class EsquemasBaseDatos
{
    /// <summary>
    /// Esquema de base de datos para la seguridad.
    /// </summary>  
    /// <remarks>
    /// Este esquema contiene las tablas relacionadas con la autenticación y autorización de usuarios, roles y permisos.
    /// </remarks>
    public const string Seguridad = "seguridad";

    /// <summary>
    /// Esquema de base de datos para los clientes.
    /// </summary>
    /// <remarks>
    /// Este esquema contiene las tablas relacionadas con la gestión de información de clientes.
    /// </remarks>
    public const string Clientes = "clientes";


    /// <summary>
    /// Esquema de base de datos para los contactos.
    /// </summary>
    /// <remarks>
    /// Este esquema contiene las tablas relacionadas con la gestión de información de contactos.
    /// </remarks>
    public const string Contactos = "contactos";

    /// <summary>
    /// Esquema de base de datos para el módulo comercial.
    /// </summary> 
    /// <remarks>
    /// Este esquema contiene las tablas relacionadas con la gestión de actividades comerciales, oportunidades de negocio y seguimiento de clientes.
    /// </remarks>

    public const string Comercial = "comercial";


    /// <summary>
    /// Esquema de base de datos para el módulo de actividades.
    /// </summary>  
    /// <remarks>
    /// Este esquema contiene las tablas relacionadas con la gestión de actividades, tareas y eventos dentro de la aplicación.
    /// </remarks>
    public const string Actividades = "actividades";


    /// <summary>
    /// Esquema de base de datos para el módulo de documentos.
    /// </summary>
    /// <remarks>
    /// Este esquema contiene las tablas relacionadas con la gestión de documentos, archivos y recursos asociados a diferentes entidades dentro de la aplicación.
    /// </remarks>
    public const string Documentos = "documentos";

    /// <summary>
    /// Esquema de base de datos para el módulo de auditoría.
    /// </summary> 
    /// <remarks>
    /// Este esquema contiene las tablas relacionadas con el registro de eventos, cambios y acciones realizadas dentro de la aplicación, permitiendo un seguimiento detallado de las actividades del sistema.
    /// </remarks
    public const string Auditoria = "auditoria";
}