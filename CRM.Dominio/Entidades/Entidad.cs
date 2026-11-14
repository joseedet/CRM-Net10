using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRM.Dominio.EventosDominio;

namespace CRM.Dominio.Entidades;

///<summary>    
/// Clase base abstracta que representa una entidad en el dominio del sistema.
/// </summary>
///<remarks>
/// Esta clase proporciona una implementación base para todas las entidades del dominio, incluyendo un identificador único y la capacidad de manejar eventos de dominio. Las entidades son objetos que tienen una identidad única y pueden contener lógica de negocio. La clase Entidad permite a las entidades registrar eventos de dominio que pueden ser utilizados para notificar a otras partes del sistema sobre cambios importantes en el estado de la entidad.
/// </remarks>
public abstract class Entidad
{
    ///<summary>    
    /// Lista de eventos de dominio asociados a la entidad.
    /// </summary>
    ///<remarks>
    /// Esta lista almacena los eventos de dominio que se han generado como resultado de cambios en el estado de la entidad. Los eventos de dominio son utilizados para notificar a otras partes del sistema sobre cambios importantes en la entidad, permitiendo una arquitectura basada en eventos y facilitando la integración con otros componentes del sistema.
    /// </remarks>
    private readonly List<IEventoDominio> _eventosDominio = [];
    
    ///<summary>    
    /// Obtiene el identificador único de la entidad.
    /// </summary>
    ///<remarks>
    /// Este identificador es utilizado para diferenciar de manera única cada entidad dentro del sistema.
    /// </remarks>          
    public Guid Id { get; protected set; }

    ///<summary>    
    /// Obtiene una colección de eventos de dominio asociados a la entidad.
    /// </summary>
    ///<remarks>
    /// Esta propiedad proporciona acceso de solo lectura a la lista de eventos de dominio que se han generado como resultado de cambios en el estado de la entidad. Permite a otras partes del sistema inspeccionar los eventos de dominio sin permitir modificaciones directas a la lista, asegurando la integridad de los eventos registrados.
    /// </remarks>  
    public IReadOnlyCollection<IEventoDominio> EventosDominio =>
        _eventosDominio.AsReadOnly();

    ///<summary>    
    /// Constructor protegido que inicializa una nueva instancia de la clase Entidad.
    /// </summary>
    ///<remarks>
    /// Este constructor es utilizado por las clases derivadas para inicializar la propiedad Id con un valor único generado automáticamente. La protección del constructor asegura que la clase Entidad no pueda ser instanciada directamente, sino que debe ser heredada por otras clases que representen entidades específicas en el dominio del sistema.
    /// </remarks>
    protected Entidad()
    {
        Id = Guid.NewGuid();
    }

    ///<summary>    
    /// Agrega un evento de dominio a la lista de eventos asociados a la entidad.
    /// </summary>
    ///<param name="eventoDominio">El evento de dominio que se va a agregar.</param>
    ///<remarks>
    /// Este método permite a las entidades registrar eventos de dominio que se han generado como resultado de cambios en su estado. Los eventos de dominio son utilizados para notificar a otras partes del sistema sobre cambios importantes en la entidad, facilitando una arquitectura basada en eventos y promoviendo la separación de preocupaciones entre la lógica de negocio y la infraestructura del sistema.
    /// </remarks>
    protected void AgregarEventoDominio(
        IEventoDominio eventoDominio)
    {
        _eventosDominio.Add(eventoDominio);
    }

    ///<summary>    
    /// Limpia la lista de eventos de dominio asociados a la entidad.
    /// </summary>
    ///<remarks>
    /// Este método permite a las entidades eliminar todos los eventos de dominio que se han registrado, asegurando que la lista de eventos esté vacía después de que se hayan procesado o manejado. Esto es útil para evitar la acumulación de eventos antiguos y garantizar que solo se mantengan los eventos relevantes para el estado actual de la entidad.
    /// </remarks>
    public void LimpiarEventosDominio() 
    {
        _eventosDominio.Clear();
    }
}
