namespace CRM.Dominio.ObjetosValor;

///<summary>    
/// Representa un objeto de valor que encapsula la lógica de validación y normalización de direcciones dentro del dominio del sistema.
/// </summary>
///<remarks>
/// Esta clase proporciona una forma de manejar direcciones como objetos de valor, asegurando que se cumplan las reglas de validación y normalización definidas para este tipo de datos. Al encapsular la lógica de validación y normalización dentro de esta clase, se garantiza que todas las direcciones utilizadas en el sistema cumplan con los estándares y restricciones establecidos, evitando errores y inconsistencias en el manejo de datos relacionados con las direcciones. Esto es esencial para mantener la integridad de los datos y facilitar la gestión de la información de contacto dentro del sistema, asegurando que las direcciones sean válidas, consistentes y estén correctamente formateadas en todas las operaciones y procesos que involucren este tipo de información.  
/// </remarks>
public sealed class Direccion : ObjetoValor
{
    ///<summary>    
    /// Obtiene el valor de la calle de la dirección.
    /// </summary>
    /// 
    public string Calle { get; }

    
    public string Ciudad { get; }

    public string Provincia { get; }

    public string CodigoPostal { get; }

    public string Pais { get; }

    private Direccion()
    {
    }

    public Direccion(
        string calle,
        string ciudad,
        string provincia,
        string codigoPostal,
        string pais)
    {
        Calle = calle;
        Ciudad = ciudad;
        Provincia = provincia;
        CodigoPostal = codigoPostal;
        Pais = pais;
    }

    protected override IEnumerable<object?> ObtenerComponentesIgualdad()
    {
        yield return Calle;
        yield return Ciudad;
        yield return Provincia;
        yield return CodigoPostal;
        yield return Pais;
    }
}