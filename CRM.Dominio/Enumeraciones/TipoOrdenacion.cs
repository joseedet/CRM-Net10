namespace CRM.Dominio.Enumeraciones;

///<summary>    
/// Enumeración que representa los posibles tipos de ordenación de datos en el sistema.
/// </summary>
///<remarks>
/// Esta enumeración proporciona una forma estandarizada de representar los diferentes tipos de ordenación que se pueden aplicar a los datos dentro del sistema, facilitando la gestión y el control de la presentación de los datos en función del tipo de ordenación seleccionado. Los tipos definidos aquí son utilizados para determinar la dirección en la que se deben organizar los datos, asegurando que las operaciones de ordenación se realicen de manera coherente y controlada.     
/// </remarks>
public enum TipoOrdenacion
{
    Ascendente = 1,
    Descendente = 2
}