namespace CRM.Dominio.Constantes;

/// <summary>
/// Contiene los permisos del sistema utilizados en la aplicación.
/// </summary>
/// <remarks>
/// Esta clase proporciona constantes que representan los permisos del sistema utilizados en la aplicación. Cada constante corresponde a un permiso específico que se puede asignar a los usuarios para controlar su acceso a diferentes funcionalidades y módulos de la aplicación.
/// </remarks>
public static class PermisosSistema
{
    #region Usuarios

    /// <summary>
    /// Permiso para ver la lista de usuarios.
    /// </summary> 
    /// <remarks>
    /// Este permiso permite a los usuarios ver la lista de usuarios registrados en el sistema.
    /// </remarks>
    public const string UsuariosVer = "Usuarios.Ver";

    /// <summary>
    /// Permiso para crear nuevos usuarios.
    /// </summary>
    /// <remarks>
    /// Este permiso permite a los usuarios crear nuevos usuarios en el sistema.
    /// </remarks>
    public const string UsuariosCrear = "Usuarios.Crear";

    /// <summary>
    /// Permiso para editar usuarios existentes.
    /// </summary>
    /// <remarks>
    /// Este permiso permite a los usuarios editar la información de los usuarios existentes en el sistema.
    /// </remarks>
    public const string UsuariosEditar = "Usuarios.Editar";

    /// <summary>
    /// Permiso para eliminar usuarios.
    /// </summary>
    /// <remarks>
    /// Este permiso permite a los usuarios eliminar usuarios del sistema.
    /// </remarks>
    public const string UsuariosEliminar = "Usuarios.Eliminar";

    /// <summary>
    /// Permiso para restaurar usuarios eliminados.
    /// </summary>
    /// <remarks>
    /// Este permiso permite a los usuarios restaurar usuarios que han sido eliminados del sistema.
    /// </remarks>
    public const string UsuariosRestaurar = "Usuarios.Restaurar";

    /// <summary>
    /// Permiso para activar usuarios.
    /// </summary>
    /// <remarks>
    /// Este permiso permite a los usuarios activar cuentas de usuario que han sido desactivadas.
    /// </remarks>
    public const string UsuariosActivar = "Usuarios.Activar";

    /// <summary>
    /// Permiso para desactivar usuarios.
    /// </summary>
    /// <remarks>
    /// Este permiso permite a los usuarios desactivar cuentas de usuario, impidiendo que puedan iniciar sesión en el sistema.
    /// </remarks>
    public const string UsuariosDesactivar = "Usuarios.Desactivar";

    #endregion

    #region Roles

    /// <summary>
    /// Permiso para ver la lista de roles.
    /// </summary>
    /// <remarks>
    /// Este permiso permite a los usuarios ver la lista de roles disponibles en el sistema.
    /// </remarks>
    public const string RolesVer = "Roles.Ver";

    /// <summary>
    /// Permiso para crear nuevos roles.
    /// </summary>
    /// <remarks>
    /// Este permiso permite a los usuarios crear nuevos roles en el sistema.
    /// </remarks>
    public const string RolesCrear = "Roles.Crear";

    /// <summary>
    /// Permiso para editar roles existentes.
    /// </summary>
    /// <remarks>
    /// Este permiso permite a los usuarios editar la información de los roles existentes en el sistema.
    /// </remarks>
    public const string RolesEditar = "Roles.Editar";

    /// <summary>
    /// Permiso para eliminar roles.
    /// </summary>
    /// <remarks>
    /// Este permiso permite a los usuarios eliminar roles del sistema.
    /// </remarks>
    public const string RolesEliminar = "Roles.Eliminar";

    /// <summary>
    /// Permiso para asignar roles a los usuarios.      
    /// </summary>
    /// <remarks>
    /// Este permiso permite a los usuarios asignar roles a otros usuarios, otorgándoles los permisos y privilegios asociados a esos roles.
    /// </remarks>
    public const string RolesAsignar = "Roles.Asignar";

    #endregion

    #region Permisos
    
    /// <summary>
    /// Permiso para ver la lista de permisos.
    /// </summary>
    /// <remarks>
    /// Este permiso permite a los usuarios ver la lista de permisos disponibles en el sistema.
    /// </remarks>
    public const string PermisosVer = "Permisos.Ver";

    /// <summary>
    /// Permiso para asignar permisos a los roles.
    /// </summary>
    /// <remarks>
    /// Este permiso permite a los usuarios asignar permisos a los roles, definiendo qué acciones y funcionalidades pueden realizar los usuarios que pertenecen a esos roles.
    /// </remarks>
    public const string PermisosAsignar = "Permisos.Asignar";

    #endregion

    #region Clientes

    /// <summary>   
    /// Permiso para ver la lista de clientes.
    /// </summary>
    /// <remarks>
    /// Este permiso permite a los usuarios ver la lista de clientes registrados en el sistema.
    /// </remarks>
    public const string ClientesVer = "Clientes.Ver";

    /// <summary>
    /// Permiso para crear nuevos clientes. 
    /// </summary>
    /// <remarks>
    /// Este permiso permite a los usuarios crear nuevos clientes en el sistema.
    /// </remarks>
    public const string ClientesCrear = "Clientes.Crear";

    /// <summary>
    /// Permiso para editar clientes existentes.
    /// </summary>
    /// <remarks>
    /// Este permiso permite a los usuarios editar la información de los clientes existentes en el sistema.
    /// </remarks>
    public const string ClientesEditar = "Clientes.Editar";

    /// <summary>
    /// Permiso para eliminar clientes.
    /// </summary>
    /// <remarks>
    /// Este permiso permite a los usuarios eliminar clientes del sistema.
    /// </remarks>
    public const string ClientesEliminar = "Clientes.Eliminar";

    /// <summary>
    /// Permiso para restaurar clientes eliminados.
    /// </summary>
    /// <remarks>
    /// Este permiso permite a los usuarios restaurar clientes que han sido eliminados del sistema.
    /// </remarks>
    public const string ClientesRestaurar = "Clientes.Restaurar";

    /// <summary>
    /// Permiso para exportar la lista de clientes.
    /// </summary>
    /// <remarks>
    /// Este permiso permite a los usuarios exportar la lista de clientes a un formato de archivo, como CSV o Excel, para su análisis o uso fuera del sistema.
    /// </remarks>
    public const string ClientesExportar = "Clientes.Exportar";

    #endregion

    #region Clasificaciones Cliente

    /// <summary>   
    /// Permiso para ver la lista de clasificaciones de clientes.
    /// </summary>
    /// <remarks>
    /// Este permiso permite a los usuarios ver la lista de clasificaciones de clientes disponibles en el sistema, lo que les ayuda a categorizar y organizar a los clientes según diferentes criterios.
    /// </remarks>    
    public const string ClasificacionesClienteVer = "ClasificacionesCliente.Ver";

    /// <summary>
    /// Permiso para crear nuevas clasificaciones de clientes.
    /// </summary>
    /// <remarks>
    /// Este permiso permite a los usuarios crear nuevas clasificaciones de clientes en el sistema, lo que les permite definir categorías adicionales para organizar a los clientes según sus necesidades comerciales.
    /// </remarks
    public const string ClasificacionesClienteCrear = "ClasificacionesCliente.Crear";

    /// <summary>
    /// Permiso para editar clasificaciones de clientes existentes.
    /// </summary>
    /// <remarks>
    /// Este permiso permite a los usuarios editar la información de las clasificaciones de clientes existentes en el sistema, lo que les permite actualizar o modificar las categorías según sea necesario.
    /// </remarks
    public const string ClasificacionesClienteEditar = "ClasificacionesCliente.Editar";

    /// <summary>
    /// Permiso para eliminar clasificaciones de clientes.
    /// </summary>
    /// <remarks>
    /// Este permiso permite a los usuarios eliminar clasificaciones de clientes del sistema, lo que les permite eliminar categorías que ya no son relevantes o necesarias para la organización de los clientes.
    /// </remarks>
    public const string ClasificacionesClienteEliminar = "ClasificacionesCliente.Eliminar";

    #endregion

    #region Contactos

    /// <summary>   
    /// Permiso para ver la lista de contactos.
    /// </summary>
    /// <remarks>
    /// Este permiso permite a los usuarios ver la lista de contactos registrados en el sistema.
    /// </remarks>
    public const string ContactosVer = "Contactos.Ver";

    /// <summary>
    /// Permiso para crear nuevos contactos.    
    /// </summary>
    /// <remarks>
    /// Este permiso permite a los usuarios crear nuevos contactos en el sistema.
    /// </remarks>
    public const string ContactosCrear = "Contactos.Crear";

    /// <summary>
    /// Permiso para editar contactos existentes.
    /// </summary>
    /// <remarks>
    /// Este permiso permite a los usuarios editar la información de los contactos existentes en el sistema.
    /// </remarks>
    public const string ContactosEditar = "Contactos.Editar";

    /// <summary>
    /// Permiso para eliminar contactos.
    /// </summary>
    /// <remarks>
    /// Este permiso permite a los usuarios eliminar contactos del sistema.
    /// </remarks>
    public const string ContactosEliminar = "Contactos.Eliminar";

    /// <summary>
    /// Permiso para restaurar contactos eliminados.
    /// </summary>
    /// <remarks>
    /// Este permiso permite a los usuarios restaurar contactos que han sido eliminados del sistema.
    /// </remarks>
    public const string ContactosRestaurar = "Contactos.Restaurar";

    /// <summary>
    /// Permiso para exportar la lista de contactos.        
    /// </summary>
    /// <remarks>
    /// Este permiso permite a los usuarios exportar la lista de contactos a un formato de archivo, como CSV o Excel, para su análisis o uso fuera del sistema.
    /// </remarks>
    public const string ContactosExportar = "Contactos.Exportar";

    #endregion

    #region Oportunidades

    /// <summary>
    /// Permiso para ver la lista de oportunidades.
    /// </summary>
    /// <remarks>
    /// Este permiso permite a los usuarios ver la lista de oportunidades registradas en el sistema.
    /// </remarks>
    public const string OportunidadesVer = "Oportunidades.Ver";

    /// <summary>
    /// Permiso para crear nuevas oportunidades.
    /// </summary>
    /// <remarks>
    /// Este permiso permite a los usuarios crear nuevas oportunidades en el sistema.
    /// </remarks>
    public const string OportunidadesCrear = "Oportunidades.Crear";

    /// <summary>
    /// Permiso para editar oportunidades existentes.
    /// </summary>
    /// <remarks>       
    /// Este permiso permite a los usuarios editar la información de las oportunidades existentes en el sistema.
    /// </remarks>
    public const string OportunidadesEditar = "Oportunidades.Editar";

    /// <summary>
    /// Permiso para eliminar oportunidades.    
    /// </summary>
    /// <remarks>
    /// Este permiso permite a los usuarios eliminar oportunidades del sistema.
    /// </remarks>
    public const string OportunidadesEliminar = "Oportunidades.Eliminar";

    /// <summary>
    /// Permiso para restaurar oportunidades eliminadas.
    /// </summary>
    /// <remarks>
    /// Este permiso permite a los usuarios restaurar oportunidades que han sido eliminadas del sistema.
    /// </remarks>
    public const string OportunidadesRestaurar = "Oportunidades.Restaurar";

    /// <summary>
    /// Permiso para exportar la lista de oportunidades.
    /// </summary>
    /// <remarks>
    /// Este permiso permite a los usuarios exportar la lista de oportunidades a un formato de archivo, como CSV o Excel, para su análisis o uso fuera del sistema.
    /// </remarks>
    public const string OportunidadesExportar = "Oportunidades.Exportar";

    #endregion

    #region Pipeline

    /// <summary>
    /// Permiso para ver el pipeline de oportunidades.
    /// </summary>
    /// <remarks>
    /// Este permiso permite a los usuarios ver el pipeline de oportunidades, que muestra el estado y progreso de las oportunidades a lo largo del proceso de ventas.
    /// </remarks>
    public const string PipelineVer = "Pipeline.Ver";

    /// <summary>
    /// Permiso para editar el pipeline de oportunidades.
    /// </summary>
    /// <remarks>
    /// Este permiso permite a los usuarios editar el pipeline de oportunidades, lo que les permite actualizar el estado y progreso de las oportunidades a medida que avanzan en el proceso de ventas.
    /// </remarks>
    public const string PipelineEditar = "Pipeline.Editar";

    #endregion

    #region Comercial
    
    /// <summary>
    /// Permiso para cerrar oportunidades como ganadas.
    /// </summary>
    /// <remarks>
    /// Este permiso permite a los usuarios cerrar oportunidades como ganadas, indicando que se ha logrado un acuerdo o venta exitosa con el cliente.
    /// </remarks>
    public const string ComercialCerrarGanada = "Comercial.CerrarGanada";

    /// <summary>
    /// Permiso para cerrar oportunidades como perdidas.
    /// </summary>
    /// <remarks>
    /// Este permiso permite a los usuarios cerrar oportunidades como perdidas, indicando que no se ha logrado un acuerdo o venta con el cliente.
    /// </remarks>
    public const string ComercialCerrarPerdida = "Comercial.CerrarPerdida";

    /// <summary>
    /// Permiso para reabrir oportunidades cerradas.
    /// </summary>
    /// <remarks>
    /// Este permiso permite a los usuarios reabrir oportunidades que han sido cerradas, ya sea como ganadas o perdidas, para continuar el seguimiento o realizar cambios en la oportunidad.
    /// </remarks>
    public const string ComercialReabrir = "Comercial.Reabrir";

    #endregion

    #region Actividades

    /// <summary>
    /// Permiso para ver la lista de actividades.
    /// </summary>
    /// <remarks>
    /// Este permiso permite a los usuarios ver la lista de actividades registradas en el sistema.
    /// </remarks>
    public const string ActividadesVer = "Actividades.Ver";

    /// <summary>
    /// Permiso para crear nuevas actividades.
    /// </summary>
    /// <remarks>
    /// Este permiso permite a los usuarios crear nuevas actividades en el sistema.
    /// </remarks>
    public const string ActividadesCrear = "Actividades.Crear";

    /// <summary>
    /// Permiso para editar actividades existentes.     
    /// </summary>
    /// <remarks>
    /// Este permiso permite a los usuarios editar la información de las actividades existentes en el sistema.
    /// </remarks>
    public const string ActividadesEditar = "Actividades.Editar";

    /// <summary>
    /// Permiso para eliminar actividades.
    /// </summary>
    /// <remarks>
    /// Este permiso permite a los usuarios eliminar actividades del sistema.
    /// </remarks>
    public const string ActividadesEliminar = "Actividades.Eliminar";

    /// <summary>
    /// Permiso para exportar la lista de actividades.
    /// </summary>
    /// <remarks>
    /// Este permiso permite a los usuarios exportar la lista de actividades a un formato de archivo, como CSV o Excel, para su análisis o uso fuera del sistema.
    /// </remarks>
    public const string ActividadesRestaurar = "Actividades.Restaurar";

    /// <summary>
    /// Permiso para exportar la lista de actividades.
    /// </summary>
    /// <remarks>
    /// Este permiso permite a los usuarios exportar la lista de actividades a un formato de archivo, como CSV o Excel, para su análisis o uso fuera del sistema.
    /// </remarks>
    public const string ActividadesExportar = "Actividades.Exportar";

    /// <summary>
    /// Permiso para completar actividades.
    /// </summary>
    /// <remarks>
    /// Este permiso permite a los usuarios marcar actividades como completadas, indicando que se ha finalizado la tarea o acción asociada a la actividad.
    /// </remarks>
    public const string ActividadesCompletar = "Actividades.Completar";

    /// <summary>
    /// Permiso para reabrir actividades completadas.
    /// </summary>
    /// <remarks>
    /// Este permiso permite a los usuarios reabrir actividades que han sido completadas, permitiendo continuar el seguimiento o realizar cambios en la actividad.
    /// </remarks>
    public const string ActividadesReabrir = "Actividades.Reabrir";

    #endregion

    #region Documentos

    /// <summary>
    /// Permiso para ver la lista de documentos.    
    /// </summary>
    /// <remarks>
    /// Este permiso permite a los usuarios ver la lista de documentos registrados en el sistema.
    /// </remarks>
    public const string DocumentosVer = "Documentos.Ver";

    /// <summary>
    /// Permiso para crear nuevos documentos.
    /// </summary>
    /// <remarks>
    /// Este permiso permite a los usuarios crear nuevos documentos en el sistema.
    /// </remarks>
    public const string DocumentosCrear = "Documentos.Crear";

    /// <summary>
    /// Permiso para editar documentos existentes.  
    /// </summary>
    /// <remarks>
    /// Este permiso permite a los usuarios editar la información de los documentos existentes en el sistema.
    /// </remarks>
    public const string DocumentosEditar = "Documentos.Editar";

    /// <summary>
    /// Permiso para eliminar documentos.
    /// </summary>  
    /// <remarks>
    /// Este permiso permite a los usuarios eliminar documentos del sistema.
    /// </remarks>
    public const string DocumentosEliminar = "Documentos.Eliminar";

    /// <summary>
    /// Permiso para restaurar documentos eliminados.
    /// </summary>
    /// <remarks>
    /// Este permiso permite a los usuarios restaurar documentos que han sido eliminados del sistema.
    /// </remarks>
    public const string DocumentosRestaurar = "Documentos.Restaurar";

    /// <summary>
    /// Permiso para descargar documentos.
    /// </summary>
    /// <remarks>
    /// Este permiso permite a los usuarios descargar documentos desde el sistema, permitiéndoles obtener una copia local del archivo para su uso fuera de la aplicación.
    /// </remarks>
    public const string DocumentosDescargar = "Documentos.Descargar";

    /// <summary>
    /// Permiso para exportar la lista de documentos.
    /// </summary>
    /// <remarks>
    /// Este permiso permite a los usuarios exportar la lista de documentos a un formato de archivo, como CSV o Excel, para su análisis o uso fuera del sistema.
    /// </remarks>  
    public const string DocumentosExportar = "Documentos.Exportar";

    #endregion

    #region Auditoria

    /// <summary>
    /// Permiso para ver la lista de auditoría.
    /// </summary>
    /// <remarks>
    /// Este permiso permite a los usuarios ver la lista de eventos de auditoría registrados en el sistema, lo que les permite realizar un seguimiento de las acciones y cambios realizados por los usuarios.
    /// </remarks>
    public const string AuditoriaVer = "Auditoria.Ver";

    /// <summary>
    /// Permiso para exportar la lista de auditoría.
    /// </summary>
    /// <remarks>
    /// Este permiso permite a los usuarios exportar la lista de eventos de auditoría a un formato de archivo, como CSV o Excel, para su análisis o uso fuera del sistema.
    /// </remarks>
    public const string AuditoriaExportar = "Auditoria.Exportar";

    /// <summary>
    /// Permiso para ver los accesos de auditoría.
    /// </summary>
    /// <remarks>
    /// Este permiso permite a los usuarios ver los registros de accesos de auditoría, lo que les permite realizar un seguimiento de los intentos de inicio de sesión y accesos a la aplicación.
    /// </remarks>
    public const string AuditoriaVerAccesos = "Auditoria.VerAccesos";

    /// <summary>
    /// Permiso para ver los cambios de auditoría.
    /// </summary>
    /// <remarks>
    /// Este permiso permite a los usuarios ver los registros de cambios de auditoría, lo que   les permite realizar un seguimiento de las modificaciones realizadas en los datos y configuraciones del sistema.                
    /// </remarks>
    public const string AuditoriaVerCambios = "Auditoria.VerCambios";

    /// <summary>
    /// Permiso para ver la seguridad de auditoría.     
    /// </summary>
    /// <remarks>
    /// Este permiso permite a los usuarios ver los registros de seguridad de auditoría, lo que les permite realizar un seguimiento de las acciones relacionadas con la seguridad, como cambios en permisos, roles y configuraciones de seguridad del sistema.
    /// </remarks>
    public const string AuditoriaVerSeguridad = "Auditoria.VerSeguridad";

    #endregion

    #region Dashboard

    /// <summary>
    /// Permiso para ver el dashboard del sistema.
    /// </summary>
    /// <remarks>
    /// Este permiso permite a los usuarios ver el dashboard del sistema, que proporciona una visión general de las métricas, estadísticas y datos relevantes para la gestión y seguimiento de las actividades dentro de la aplicación.
    /// </remarks>    
    public const string DashboardVer = "Dashboard.Ver";

    /// <summary>
    /// Permiso para exportar el dashboard del sistema.
    /// </summary>
    /// <remarks>
    /// Este permiso permite a los usuarios exportar el dashboard del sistema a un formato de archivo, como PDF o imagen, para su análisis o uso fuera de la aplicación.
    /// </remarks>
    public const string DashboardExportar = "Dashboard.Exportar";
    
    /// <summary>
    /// Permiso para ver el dashboard comercial.
    /// </summary>
    /// <remarks>
    /// Este permiso permite a los usuarios ver el dashboard comercial, que proporciona información y métricas relacionadas con las actividades comerciales, oportunidades de negocio y seguimiento de clientes.
    /// </remarks>
    public const string DashboardComercial = "Dashboard.Comercial";

    /// <summary>
    /// Permiso para ver el dashboard de clientes.
    /// </summary>
    /// <remarks>
    /// Este permiso permite a los usuarios ver el dashboard de clientes, que proporciona información y métricas relacionadas con la gestión de clientes, su estado y actividades asociadas.
    /// </remarks>
    public const string DashboardClientes = "Dashboard.Clientes";

    /// <summary>
    /// Permiso para ver el dashboard de contactos.
    /// </summary>
    /// <remarks>
    /// Este permiso permite a los usuarios ver el dashboard de contactos, que proporciona información y métricas relacionadas con la gestión de contactos, su estado y actividades asociadas.
    /// </remarks>
    public const string DashboardContactos = "Dashboard.Contactos";

    /// <summary>
    /// Permiso para ver el dashboard de actividades.
    /// </summary>
    /// <remarks>
    /// Este permiso permite a los usuarios ver el dashboard de actividades, que proporciona información y métricas relacionadas con la gestión de actividades, tareas y eventos dentro de la aplicación.
    /// </remarks>
    public const string DashboardActividades = "Dashboard.Actividades";

    /// <summary>
    /// Permiso para ver el dashboard de documentos.
    /// </summary>
    /// <remarks>
    /// Este permiso permite a los usuarios ver el dashboard de documentos, que proporciona información y métricas relacionadas con la gestión de documentos, archivos y recursos asociados a diferentes entidades dentro de la aplicación.     
    /// </remarks>
    public const string DashboardDocumentos = "Dashboard.Documentos";

    /// <summary>
    /// Permiso para ver el dashboard de auditoría.
    /// </summary>
    /// <remarks>
    /// Este permiso permite a los usuarios ver el dashboard de auditoría, que proporciona información y métricas relacionadas con el registro de eventos, cambios y acciones realizadas dentro de la aplicación, permitiendo un seguimiento detallado de las actividades del sistema.
    /// </remarks>
    public const string DashboardAuditoria = "Dashboard.Auditoria";

    /// <summary>
    /// Permiso para ver el dashboard del sistema.
    /// </summary>
    /// <remarks>
    /// Este permiso permite a los usuarios ver el dashboard del sistema, que proporciona una visión general de las métricas, estadísticas y datos relevantes para la gestión y seguimiento de las actividades dentro de la aplicación, incluyendo información de todos los módulos y funcionalidades del sistema.
    /// </remarks>
    public const string DashboardSistema = "Dashboard.Sistema";

    #endregion

    #region Administracion

    /// <summary>
    /// Permiso para ver la sección de administración del sistema.
    /// </summary>
    /// <remarks>
    /// Este permiso permite a los usuarios acceder a la sección de administración del sistema, donde pueden configurar y gestionar diferentes aspectos de la aplicación, incluyendo usuarios, roles, permisos y configuraciones del sistema.
    /// </remarks>
    public const string AdministracionVer = "Administracion.Ver";

    /// <summary>
    /// Permiso para configurar el sistema.
    /// </summary>
    /// <remarks>
    /// Este permiso permite a los usuarios configurar diferentes aspectos del sistema, incluyendo ajustes de seguridad, correo electrónico, almacenamiento y otras configuraciones relacionadas con el funcionamiento de la aplicación.
    /// </remarks
    public const string AdministracionConfigurarSistema = "Administracion.ConfigurarSistema";

    /// <summary>
    /// Permiso para configurar el correo electrónico del sistema.
    /// </summary>
    /// <remarks>
    /// Este permiso permite a los usuarios configurar los ajustes de correo electrónico del sistema, incluyendo servidores de correo, credenciales y otras configuraciones relacionadas con el envío y recepción de correos electrónicos desde la aplicación.
    /// </remarks>
    public const string AdministracionConfigurarCorreo = "Administracion.ConfigurarCorreo";

    /// <summary>
    /// Permiso para configurar el almacenamiento del sistema.
    /// </summary>
    /// <remarks>
    /// Este permiso permite a los usuarios configurar los ajustes de almacenamiento del sistema, incluyendo la gestión de archivos, bases de datos y otras configuraciones relacionadas con el almacenamiento de datos dentro de la aplicación.
    /// </remarks>
    public const string AdministracionConfigurarAlmacenamiento = "Administracion.ConfigurarAlmacenamiento";

    /// <summary>
    /// Permiso para configurar la seguridad del sistema.
    /// </summary>
    /// <remarks>
    /// Este permiso permite a los usuarios configurar los ajustes de seguridad del sistema, incluyendo la gestión de usuarios, roles, permisos y otras configuraciones relacionadas con la autenticación y autorización dentro de la aplicación.
    /// </remarks>
    public const string AdministracionConfigurarSeguridad = "Administracion.ConfigurarSeguridad";

    #endregion
}
