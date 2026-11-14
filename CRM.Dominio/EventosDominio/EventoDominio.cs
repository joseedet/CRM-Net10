
namespace CRM.Dominio.EventosDominio;

///<summary>    
/// Clase base abstracta que representa un evento de dominio en el sistema.
/// </summary>
/// <remarks>
/// Esta clase proporciona una implementación base para todos los eventos de dominio que se generan dentro del sistema. Los eventos de dominio son utilizados para notificar a otras partes del sistema sobre cambios importantes en el estado de las entidades, facilitando una arquitectura basada en eventos y promoviendo la separación de preocupaciones entre la lógica de negocio y la infraestructura del sistema. La clase EventoDominio establece una estructura común para todos los eventos de dominio, incluyendo la fecha de ocurrencia del evento, lo que permite un seguimiento y registro adecuado de los eventos generados en el sistema.
/// </remarks>
public abstract class EventoDominio : IEventoDominio
{
    ///<summary>    
    /// Obtiene la fecha y hora en que ocurrió el evento de dominio.
    /// </summary>
    ///<remarks>
    /// Esta propiedad almacena la fecha y hora en que el evento de dominio fue generado, lo que permite rastrear cuándo se produjeron cambios importantes en el estado de las entidades. Es útil para auditorías, seguimiento de la actividad del sistema y para garantizar que los eventos se procesen  en el orden correcto, asegurando la coherencia y la integridad de los datos en el sistema.
    /// </remarks>
    /// <value>
    /// La fecha y hora en que ocurrió el evento de dominio.
    /// </value>
    public DateTime FechaOcurrencia { get; }

    ///<summary>    
    /// Constructor protegido que inicializa una nueva instancia de la clase EventoDominio.
    /// </summary>
    ///<remarks>
    /// Este constructor es utilizado por las clases derivadas para establecer la propiedad FechaOcurrencia con la fecha y hora actual en formato UTC. La protección del constructor asegura que la clase EventoDominio no pueda ser instanciada directamente, sino que debe ser heredada por otras clases que representen eventos de dominio específicos en el sistema.
    /// </remarks>  
    protected EventoDominio()
    {
        FechaOcurrencia = DateTime.UtcNow;
    }
}