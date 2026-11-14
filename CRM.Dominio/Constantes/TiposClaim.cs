namespace CRM.Dominio.Constantes;

///<summary>    
/// Clase estática que contiene constantes que representan los tipos de claims utilizados en el sistema.
/// </summary>
///<remarks>
/// Esta clase proporciona una forma centralizada de definir los tipos de claims que se utilizan en el sistema de seguridad. Los claims son piezas de información sobre el usuario que se utilizan para controlar el acceso a diferentes funcionalidades y recursos dentro del sistema. Definir los tipos de claims como constantes facilita su uso y evita errores tipográficos al referirse a ellos en diferentes partes de la aplicación.
/// </remarks>
public static class TiposClaim
{
    /// <summary>
    /// Constante que representa el tipo de claim para el nombre del usuario.
    /// </summary>
    /// <remarks>
    /// Este tipo de claim se utiliza para almacenar el nombre del usuario en el sistema de seguridad. Es una pieza de información importante que puede ser utilizada para personalizar la experiencia del usuario y para mostrar su nombre en diferentes partes de la aplicación.
    /// </remarks>
    public const string Permiso = "Permiso";
}