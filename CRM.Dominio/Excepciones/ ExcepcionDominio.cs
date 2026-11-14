namespace CRM.Dominio.Excepciones;

///<summary>    
/// Clase base abstracta para todas las excepciones de dominio en el sistema.
/// </summary>
///<remarks>
/// Esta clase proporciona una base para todas las excepciones que se producen dentro del dominio del sistema, permitiendo una gestión centralizada de los errores y facilitando la identificación de problemas específicos del dominio. Al heredar de esta clase, las excepciones de dominio pueden ser diferenciadas de otras excepciones en el sistema, lo que permite un manejo más preciso y específico de los errores relacionados con la lógica de negocio y las reglas del dominio. Esto es esencial para mantener la integridad del sistema y garantizar que los errores se manejen de manera adecuada, proporcionando información útil para la depuración y el mantenimiento del sistema.
public abstract class ExcepcionDominio : Exception
{
    ///<summary>    
    /// Constructor protegido que inicializa una nueva instancia de la clase ExcepcionDominio con un mensaje de error específico.
    /// </summary>
    ///<param name="mensaje">El mensaje de error que describe la excepción.</param>
    ///<remarks>
    /// Este constructor permite a las clases derivadas inicializar la excepción de dominio con un mensaje de error específico, proporcionando información detallada sobre la naturaleza del error que se ha producido. La protección del constructor asegura que la clase ExcepcionDominio no pueda ser instanciada directamente, sino que debe ser heredada por otras clases que representen excepciones específicas del dominio, lo que permite una gestión más precisa y controlada de los errores dentro del sistema.
    /// </remarks>  
    protected ExcepcionDominio(string mensaje)
        : base(mensaje)
    {
    }
}