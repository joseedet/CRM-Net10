namespace CRM.Dominio.Enumeraciones;

///<summary>    
/// Enumeración que representa los posibles tipos de exportación de datos en el sistema.
/// </summary>
///<remarks>
/// Esta enumeración proporciona una forma estandarizada de representar los diferentes formatos de exportación de datos que se pueden utilizar dentro del sistema, facilitando la gestión y el control de las exportaciones en función del tipo seleccionado. Los tipos definidos aquí son utilizados para determinar el formato de salida de los datos exportados, asegurando que las operaciones de exportación se realicen de manera coherente y controlada.     
/// </remarks>
public enum TipoExportacion
{
    Excel = 1,
    Csv = 2,
    Pdf = 3
}