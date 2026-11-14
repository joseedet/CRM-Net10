namespace CRM.Dominio.Enumeraciones;

///<summary>    
/// Enumeración que representa los posibles tipos de operación de auditoría en el sistema.
/// </summary>      
/// <remarks>
/// Esta enumeración proporciona una forma estandarizada de representar los diferentes tipos de operaciones que pueden ser auditadas dentro del sistema, facilitando la gestión y el control de las auditorías en función del tipo de operación realizada. Los tipos definidos aquí son utilizados para determinar la naturaleza de las acciones realizadas por los usuarios en el sistema, asegurando que las operaciones de auditoría se realicen de manera coherente y controlada.     
/// </remarks>
public enum TipoOperacionAuditoria
{
    Crear = 1,
    Modificar = 2,
    Eliminar = 3,
    Restaurar = 4,
    Consultar = 5,
    Login = 6,
    Logout = 7
}