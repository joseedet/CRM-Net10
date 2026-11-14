using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRM.Dominio.Entidades;

///<summary>    
/// Clase base abstracta que representa una entidad auditable en el dominio del sistema.
/// </summary>
///<remarks>
/// Esta clase proporciona una implementación base para todas las entidades del dominio que requieren auditoría, incluyendo propiedades para rastrear la creación, modificación y eliminación de la entidad, así como el usuario responsable de cada acción. La clase EntidadAuditable hereda de la clase Entidad y agrega funcionalidad específica para el seguimiento de cambios en el estado de la entidad, lo que facilita la auditoría y el cumplimiento de políticas de seguridad y control dentro del sistema.
/// </remarks>
public abstract class EntidadAuditable : Entidad
{
    ///<summary>    
    /// Obtiene o establece la fecha de creación de la entidad.
    /// </summary>
    ///<remarks>
    /// Esta propiedad almacena la fecha y hora en que la entidad fue creada, lo que permite rastrear cuándo se introdujo la entidad en el sistema. Es útil para auditorías y seguimiento de la actividad de la entidad a lo largo del tiempo.
    /// </remarks>
    public DateTime FechaCreacion { get; protected set; }

    ///<summary>    
    /// Obtiene o establece el usuario que creó la entidad.
    /// </summary>
    ///<remarks>
    /// Esta propiedad almacena el nombre o identificador del usuario que creó la entidad, lo que permite rastrear quién fue responsable de la creación de la entidad en el sistema. Es útil para auditorías y seguimiento de la actividad de la entidad a lo largo del tiempo.
    /// </remarks>
    public string UsuarioCreacion { get; protected set; } = string.Empty;

    ///<summary>    
    /// Obtiene o establece la fecha de modificación de la entidad.
    /// </summary>
    ///<remarks>
    /// Esta propiedad almacena la fecha y hora en que la entidad fue modificada por última vez, lo que permite rastrear cuándo se realizaron cambios en la entidad. Es útil para auditorías y seguimiento de la actividad de la entidad a lo largo del tiempo.
    /// </remarks>
    public DateTime? FechaModificacion { get; protected set; }

    ///<summary>    
    /// Obtiene o establece el usuario que modificó la entidad.     
    /// </summary>
    ///<remarks>
    /// Esta propiedad almacena el nombre o identificador del usuario que modificó la entidad por última vez, lo que permite rastrear quién fue responsable de los cambios en la entidad. Es útil para auditorías y seguimiento de la actividad de la entidad a lo largo del tiempo.
    /// </remarks>
    public string? UsuarioModificacion { get; protected set; }

    ///<summary>    
    /// Obtiene o establece un valor que indica si la entidad ha sido eliminada.
    /// </summary>
    ///<remarks>
    /// Esta propiedad indica si la entidad ha sido marcada como eliminada en el sistema. Un valor de true significa que la entidad ha sido eliminada, mientras que un valor de false indica que la entidad sigue activa. Esta propiedad es útil para implementar un enfoque de eliminación lógica, donde las entidades eliminadas no se eliminan físicamente de la base de datos, sino que se marcan como eliminadas para mantener un historial de cambios y permitir la recuperación de datos si es necesario.
    /// </remarks>
    public bool Eliminado { get; protected set; }

    ///<summary>    
    /// Obtiene o establece la fecha de eliminación de la entidad.
    /// </summary>
    ///<remarks>
    /// Esta propiedad almacena la fecha y hora en que la entidad fue eliminada, lo que permite rastrear cuándo se realizó la eliminación de la entidad. Es útil para auditorías y seguimiento de la actividad de la entidad a lo largo del tiempo.
    /// </remarks>
    public DateTime? FechaEliminacion { get; protected set; }

    ///<summary>    
    /// Obtiene o establece el usuario que eliminó la entidad.
    /// </summary>
    ///<remarks>
    /// Esta propiedad almacena el nombre o identificador del usuario que eliminó la entidad, lo que permite rastrear quién fue responsable de la eliminación de la entidad en el sistema. Es útil para auditorías y seguimiento de la actividad de la entidad a lo largo del tiempo.
    /// </remarks>
    public string? UsuarioEliminacion { get; protected set; }

    ///<summary>    
    /// Obtiene o establece el identificador del tenant al que pertenece la entidad.
    /// </summary>
    ///<remarks>
    /// Esta propiedad almacena el identificador del tenant al que pertenece la entidad, lo que permite diferenciar entre diferentes inquilinos o clientes dentro de un sistema multi-tenant. Es útil para garantizar que los datos de cada tenant estén aislados y sean accesibles solo para los usuarios autorizados de ese tenant, mejorando la seguridad y la gestión de datos en entornos multi-tenant.
    /// </remarks>
    public Guid? TenantId { get; protected set; }
    
    ///<summary>    
    /// Constructor protegido que inicializa una nueva instancia de la clase EntidadAuditable.
    /// </summary>
    ///<remarks>
    /// Este constructor es utilizado por las clases derivadas para inicializar las propiedades de auditoría, incluyendo la fecha de creación y el usuario que creó la entidad. La protección del constructor asegura que la clase EntidadAuditable no pueda ser instanciada directamente, sino que debe ser heredada por otras clases que representen entidades específicas en el dominio del sistema que requieran auditoría.
    /// </remarks>
    protected EntidadAuditable()
    {
        FechaCreacion = DateTime.UtcNow;
    }

    ///<summary>    
    /// Marca la entidad como eliminada, estableciendo las propiedades correspondientes de auditoría.
    /// </summary>
    ///<param name="usuario">El usuario que está eliminando la entidad.</param>
    ///<remarks>
    /// Este método permite a las entidades marcarse como eliminadas, estableciendo la propiedad Eliminado en true y registrando la fecha y el usuario responsable de la eliminación. Esto es útil para implementar un enfoque de eliminación lógica, donde las entidades eliminadas no se eliminan físicamente de la base de datos, sino que se marcan como eliminadas para mantener un historial de cambios y permitir la recuperación de datos si es necesario. La auditoría de la eliminación proporciona información valiosa para el seguimiento de la actividad de la entidad y el cumplimiento de políticas de seguridad y control dentro del sistema.
    /// </remarks>
    public virtual void MarcarComoEliminado(string usuario)
    {
        Eliminado = true;
        FechaEliminacion = DateTime.UtcNow;
        UsuarioEliminacion = usuario;
    }


    ///<summary>    
    /// Restaura la entidad eliminada, estableciendo las propiedades correspondientes de auditoría.
    /// </summary>
    ///<remarks>
    /// Este método permite a las entidades restaurarse después de haber sido marcadas como eliminadas, estableciendo la propiedad Eliminado en false y borrando la fecha y el usuario responsable de la eliminación. Esto es útil para revertir la eliminación lógica de una entidad y permitir que vuelva a estar activa en el sistema. La restauración de la entidad proporciona flexibilidad en la gestión de datos y permite a los usuarios recuperar información que puede haber sido eliminada por error o que necesita ser reactivada por cualquier motivo. La auditoría de la restauración proporciona información valiosa para el seguimiento de la actividad de la entidad y el cumplimiento de políticas de seguridad y control dentro del sistema.
    /// </remarks>
    public virtual void Restaurar()
    {
        Eliminado = false;
        FechaEliminacion = null;
        UsuarioEliminacion = null;
    }


    ///<summary>    
    /// Registra la modificación de la entidad, estableciendo las propiedades correspondientes de auditoría.
    /// </summary>
    ///<param name="usuario">El usuario que está modificando la entidad.</param>
    ///<remarks>
    /// Este método permite a las entidades registrar modificaciones, estableciendo la fecha y el usuario responsable de la modificación. Esto es útil para mantener un historial de cambios en la entidad y para auditar la actividad de los usuarios que realizan modificaciones en el sistema. La auditoría de las modificaciones proporciona información valiosa para el seguimiento de la actividad de la entidad y el cumplimiento de políticas de seguridad y control dentro del sistema, asegurando que los cambios realizados en las entidades sean rastreables y responsables.
    protected void RegistrarModificacion(string usuario)
    {
        FechaModificacion = DateTime.UtcNow;
        UsuarioModificacion = usuario;
    }
}