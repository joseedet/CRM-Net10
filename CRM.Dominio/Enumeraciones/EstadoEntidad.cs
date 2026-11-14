namespace CRM.Dominio.Enumeraciones;

///<summary>    
/// Enumeración que representa los posibles estados de una entidad en el sistema.
/// </summary>
///<remarks>
/// Esta enumeración proporciona una forma estandarizada de representar los diferentes estados que una entidad puede tener dentro del sistema, facilitando la gestión y el control de las entidades en función de su estado. Los estados definidos aquí son utilizados para determinar la disponibilidad y la visibilidad de las entidades en diferentes contextos del sistema, asegurando que las operaciones se realicen de manera coherente y controlada.     
/// </remarks>
public enum EstadoEntidad
{
    Activo = 1,
    Inactivo = 2,
    Eliminado = 3
}