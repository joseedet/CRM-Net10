using CRM.Seguridad.Infraestructura.EntidadesIdentity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CRM.Seguridad.Infraestructura.Persistencia.Configuraciones;

/// <summary>
/// Configuración de la entidad <see cref="UsuarioIdentity"/> para Entity Framework Core.
/// </summary>
/// <remarks>
/// Esta clase implementa la interfaz <see cref="IEntityTypeConfiguration{TEntity}"/> para configurar la entidad <see cref="UsuarioIdentity"/> en el contexto de Entity Framework Core. Define cómo se mapea la entidad a la base de datos, incluyendo el nombre de la tabla, el esquema y las propiedades específicas de la entidad.
/// </remarks>
public sealed class UsuarioIdentityConfiguracion
    : IEntityTypeConfiguration<UsuarioIdentity>
{
    public void Configure(
        EntityTypeBuilder<UsuarioIdentity> builder)
    {
        builder.ToTable(
            "usuarios",
            "seguridad");

        builder.Property(x => x.Nombre)
            .HasMaxLength(150)
            .IsRequired();

        builder.Property(x => x.Apellidos)
            .HasMaxLength(250)
            .IsRequired();
    }
}