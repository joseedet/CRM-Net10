using CRM.Seguridad.Infraestructura.EntidadesIdentity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CRM.Seguridad.Infraestructura.Persistencia.Configuraciones;

/// <summary>
/// Configuración de la entidad <see cref="RolIdentity"/> para Entity Framework Core.
/// </summary>
/// <remarks>   
/// Esta clase implementa la interfaz <see cref="IEntityTypeConfiguration{TEntity}"/> para configurar la entidad <see cref="RolIdentity"/> en el contexto de Entity Framework Core. Define cómo se mapea la entidad a la base de datos, incluyendo el nombre de la tabla, el esquema y las propiedades específicas de la entidad.
/// </remarks>
public sealed class RolIdentityConfiguracion
    : IEntityTypeConfiguration<RolIdentity>
{
    /// <summary>
    /// Configura la entidad <see cref="RolIdentity"/> en el modelo de Entity Framework Core.
    /// </summary>
    /// <param name="builder">El constructor de tipo de entidad utilizado para configurar la entidad.</param>
    /// <remarks>
    /// Este método se llama durante la construcción del modelo de Entity Framework Core y permite definir cómo se mapea la entidad <see cref="RolIdentity"/> a la base de datos. Se especifica el nombre de la tabla, el esquema y las propiedades de la entidad, incluyendo restricciones y longitudes máximas de las columnas.
    /// </remarks>
    public void Configure(
        EntityTypeBuilder<RolIdentity> builder)
    {
        builder.ToTable(
            "roles",
            "seguridad");

        builder.Property(x => x.Descripcion)
            .HasMaxLength(500);
    }
}