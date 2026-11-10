namespace CRM.Dominio.Constantes;

public static class PermisosSistema
{
    #region Usuarios

    public const string UsuariosVer = "Usuarios.Ver";
    public const string UsuariosCrear = "Usuarios.Crear";
    public const string UsuariosEditar = "Usuarios.Editar";
    public const string UsuariosEliminar = "Usuarios.Eliminar";
    public const string UsuariosRestaurar = "Usuarios.Restaurar";
    public const string UsuariosActivar = "Usuarios.Activar";
    public const string UsuariosDesactivar = "Usuarios.Desactivar";

    #endregion

    #region Roles

    public const string RolesVer = "Roles.Ver";
    public const string RolesCrear = "Roles.Crear";
    public const string RolesEditar = "Roles.Editar";
    public const string RolesEliminar = "Roles.Eliminar";
    public const string RolesAsignar = "Roles.Asignar";

    #endregion

    #region Permisos

    public const string PermisosVer = "Permisos.Ver";
    public const string PermisosAsignar = "Permisos.Asignar";

    #endregion

    #region Clientes

    public const string ClientesVer = "Clientes.Ver";
    public const string ClientesCrear = "Clientes.Crear";
    public const string ClientesEditar = "Clientes.Editar";
    public const string ClientesEliminar = "Clientes.Eliminar";
    public const string ClientesRestaurar = "Clientes.Restaurar";
    public const string ClientesExportar = "Clientes.Exportar";

    #endregion

    #region Clasificaciones Cliente

    public const string ClasificacionesClienteVer = "ClasificacionesCliente.Ver";
    public const string ClasificacionesClienteCrear = "ClasificacionesCliente.Crear";
    public const string ClasificacionesClienteEditar = "ClasificacionesCliente.Editar";
    public const string ClasificacionesClienteEliminar = "ClasificacionesCliente.Eliminar";

    #endregion

    #region Contactos

    public const string ContactosVer = "Contactos.Ver";
    public const string ContactosCrear = "Contactos.Crear";
    public const string ContactosEditar = "Contactos.Editar";
    public const string ContactosEliminar = "Contactos.Eliminar";
    public const string ContactosRestaurar = "Contactos.Restaurar";
    public const string ContactosExportar = "Contactos.Exportar";

    #endregion

    #region Oportunidades

    public const string OportunidadesVer = "Oportunidades.Ver";
    public const string OportunidadesCrear = "Oportunidades.Crear";
    public const string OportunidadesEditar = "Oportunidades.Editar";
    public const string OportunidadesEliminar = "Oportunidades.Eliminar";
    public const string OportunidadesRestaurar = "Oportunidades.Restaurar";
    public const string OportunidadesExportar = "Oportunidades.Exportar";

    #endregion

    #region Pipeline

    public const string PipelineVer = "Pipeline.Ver";
    public const string PipelineEditar = "Pipeline.Editar";

    #endregion

    #region Comercial

    public const string ComercialCerrarGanada = "Comercial.CerrarGanada";
    public const string ComercialCerrarPerdida = "Comercial.CerrarPerdida";
    public const string ComercialReabrir = "Comercial.Reabrir";

    #endregion

    #region Actividades

    public const string ActividadesVer = "Actividades.Ver";
    public const string ActividadesCrear = "Actividades.Crear";
    public const string ActividadesEditar = "Actividades.Editar";
    public const string ActividadesEliminar = "Actividades.Eliminar";
    public const string ActividadesRestaurar = "Actividades.Restaurar";
    public const string ActividadesCompletar = "Actividades.Completar";
    public const string ActividadesReabrir = "Actividades.Reabrir";

    #endregion

    #region Documentos

    public const string DocumentosVer = "Documentos.Ver";
    public const string DocumentosCrear = "Documentos.Crear";
    public const string DocumentosEditar = "Documentos.Editar";
    public const string DocumentosEliminar = "Documentos.Eliminar";
    public const string DocumentosRestaurar = "Documentos.Restaurar";
    public const string DocumentosDescargar = "Documentos.Descargar";
    public const string DocumentosExportar = "Documentos.Exportar";

    #endregion

    #region Auditoria

    public const string AuditoriaVer = "Auditoria.Ver";
    public const string AuditoriaExportar = "Auditoria.Exportar";
    public const string AuditoriaVerAccesos = "Auditoria.VerAccesos";
    public const string AuditoriaVerCambios = "Auditoria.VerCambios";
    public const string AuditoriaVerSeguridad = "Auditoria.VerSeguridad";

    #endregion

    #region Dashboard

    public const string DashboardVer = "Dashboard.Ver";
    public const string DashboardExportar = "Dashboard.Exportar";

    public const string DashboardComercial = "Dashboard.Comercial";
    public const string DashboardClientes = "Dashboard.Clientes";
    public const string DashboardActividades = "Dashboard.Actividades";
    public const string DashboardAuditoria = "Dashboard.Auditoria";
    public const string DashboardSistema = "Dashboard.Sistema";

    #endregion

    #region Administracion

    public const string AdministracionVer = "Administracion.Ver";
    public const string AdministracionConfigurarSistema = "Administracion.ConfigurarSistema";
    public const string AdministracionConfigurarCorreo = "Administracion.ConfigurarCorreo";
    public const string AdministracionConfigurarAlmacenamiento = "Administracion.ConfigurarAlmacenamiento";
    public const string AdministracionConfigurarSeguridad = "Administracion.ConfigurarSeguridad";

    #endregion
}