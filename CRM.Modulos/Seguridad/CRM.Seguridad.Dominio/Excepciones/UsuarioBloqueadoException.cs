using CRM.Dominio.Excepciones;

namespace CRM.Seguridad.Dominio.Excepciones;

public sealed class UsuarioBloqueadoException
    : ReglaNegocioException
{
    public UsuarioBloqueadoException()
        : base("El usuario se encuentra bloqueado.")
    {
    }
}