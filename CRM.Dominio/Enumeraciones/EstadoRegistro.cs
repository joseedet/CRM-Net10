namespace CRM.Dominio.Enumeraciones;

///<summary>    
/// Enumeración que representa los posibles estados de un registro en el sistema.
/// </summary>
///<remarks>
/// Esta enumeración proporciona una forma estandarizada de representar los diferentes estados que un registro puede tener dentro del sistema, facilitando la gestión y el control de los registros en función de su estado. Los estados definidos aquí son utilizados para determinar la disponibilidad y la visibilidad de los registros en diferentes contextos del sistema, asegurando que las operaciones se realicen de manera coherente y controlada.     
/// </remarks>
public enum EstadoRegistro
{
    Activo = 1,
    Inactivo = 2
}