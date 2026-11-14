namespace CRM.Dominio.Excepciones;

///<summary>    
/// Excepción que se lanza cuando no se encuentra una entidad específica en el sistema.
/// </summary>
///<remarks>
/// Esta excepción se utiliza para indicar que una entidad esperada no se ha encontrado en el sistema, lo que puede ocurrir durante operaciones de búsqueda o recuperación de datos. Al lanzar esta excepción, se proporciona información sobre la entidad que no se encontró y su identificador, lo que facilita la depuración y el manejo de errores en la aplicación. Esta excepción es útil para garantizar que las operaciones que dependen de la existencia de una entidad específica puedan manejar adecuadamente los casos en los que la entidad no está presente, permitiendo a los desarrolladores implementar lógica de control de errores y flujos altern  ativos en sus aplicaciones.  
/// </remarks>
public sealed class EntidadNoEncontradaException : ExcepcionDominio
{
    ///<summary>    
    /// Inicializa una nueva instancia de la clase EntidadNoEncontradaException con un mensaje de error específico que indica que no se encontró la entidad.
    /// </summary>
    ///<param name="entidad">El nombre de la entidad que no se encontró.</param>
    ///<param name="id">El identificador de la entidad que no se encontró.</param>
    ///<remarks>
    /// Este constructor permite crear una instancia de la excepción EntidadNoEncontradaException proporcionando el nombre de la entidad y su identificador, generando un mensaje de error que describe la situación. Esto es útil para informar a los desarrolladores y usuarios sobre la ausencia de la entidad esperada, permitiendo una gestión más precisa de los errores y facilitando la depuración de problemas relacionados con la búsqueda o recuperación de datos en el sistema. La información proporcionada en el mensaje de error ayuda a identificar rápidamente la entidad que no se encontró y su contexto, mejorando la capacidad de respuesta ante errores y la implementación de flujos alternativos en la aplicación.
    /// </remarks>
    public EntidadNoEncontradaException(string entidad, Guid id)
        : base($"No se encontró la entidad '{entidad}' con identificador '{id}'.")
    {
    }

    ///<summary>    
    /// Inicializa una nueva instancia de la clase EntidadNoEncontradaException con un mensaje de error específico.
    /// </summary>
    ///<param name="mensaje">El mensaje de error que describe la excepción.</param>
    ///<remarks>
    /// Este constructor permite crear una instancia de la excepción EntidadNoEncontradaException proporcionando un mensaje de error específico que describe la situación de que no se encontró la entidad. Esto es útil para informar a los desarrolladores y usuarios sobre la ausencia de la entidad esperada, permitiendo una gestión más precisa de los errores y facilitando la depuración de problemas relacionados con la búsqueda o recuperación de datos en el sistema. La información proporcionada en el mensaje de error ayuda a identificar rápidamente la entidad que no se encontró y su contexto, mejorando la capacidad de respuesta ante errores y la implementación de flujos alternativos en la aplicación.
    /// </remarks>
    public EntidadNoEncontradaException(string mensaje)
        : base(mensaje)
    {
    }
}