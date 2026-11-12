using CRM.Dominio.Excepciones;

namespace CRM.Seguridad.Dominio.Excepciones;

public sealed class UsuarioInactivoException
    : ReglaNegocioException
{
    public UsuarioInactivoException()
        : base(
            "El usuario se encuentra inactivo.")
    {
    }
}