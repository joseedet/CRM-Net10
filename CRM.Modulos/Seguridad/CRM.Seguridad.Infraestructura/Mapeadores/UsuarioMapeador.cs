using CRM.Seguridad.Dominio.Entidades;
using CRM.Seguridad.Infraestructura.EntidadesIdentity;

namespace CRM.Seguridad.Infraestructura.Mapeadores;

/// <summary>
/// Clase estática que proporciona métodos de mapeo entre la entidad de usuario de Identity y la entidad de dominio de usuario.
/// </summary>
/// <remarks>
/// Esta clase contiene métodos que permiten convertir una instancia de <see cref="UsuarioIdentity"/> a una instancia de <see cref="Usuario"/>. Esto es útil para separar las preocupaciones entre la capa de infraestructura y la capa de dominio, permitiendo que la lógica de negocio trabaje con entidades de dominio en lugar de entidades específicas de la infraestructura.
/// </remarks>
public static class UsuarioMapeador
{

    /// <summary>
    /// Convierte una instancia de <see cref="UsuarioIdentity"/> a una instancia de <see cref="Usuario"/>.
    /// </summary>
    /// <param name="usuario">La instancia de <see cref="UsuarioIdentity"/> que se va a convertir.</param>
    /// <returns>Una nueva instancia de <see cref="Usuario"/> con los datos mapeados desde la instancia de <see cref="UsuarioIdentity"/>.</returns>
    /// <remarks>
    /// Este método toma una instancia de <see cref="UsuarioIdentity"/> y crea una nueva instancia de <see cref="Usuario"/> utilizando los valores de las propiedades relevantes. Esto permite que la capa de dominio trabaje con una representación más abstracta del usuario, sin depender de la implementación específica de Identity.
    /// </remarks>
    public static Usuario AEntidad(
        UsuarioIdentity usuario)
    {
        return new Usuario(
            usuario.Nombre,
            usuario.Apellidos,
            usuario.Email ?? string.Empty);
    }
}