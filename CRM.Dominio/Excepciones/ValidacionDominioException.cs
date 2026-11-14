namespace CRM.Dominio.Excepciones;

///<summary>    
/// Excepción que se lanza cuando ocurre una validación de dominio fallida en el sistema.
/// </summary>
///<remarks>
/// Esta excepción se utiliza para indicar que una operación o acción en el dominio del sistema no cumple con las reglas de negocio o restricciones definidas, lo que puede ocurrir durante la validación de datos o la ejecución de lógica de negocio. Al lanzar esta excepción, se proporciona información sobre la validación fallida, lo que facilita la depuración y el manejo de errores en la aplicación. Esta excepción es útil para garantizar que las operaciones que dependen de la validez de los datos puedan manejar adecuadamente los casos en los que la validación falla, permitiendo a los desarrolladores implementar lógica de control de errores y flujos alternativos en sus aplicaciones.  
/// </remarks>
public sealed class ValidacionDominioException : ExcepcionDominio
{
    public ValidacionDominioException(string mensaje)
        : base(mensaje)
    {
    }
}