namespace CRM.Dominio.Excepciones;

public sealed class ReglaNegocioException : ExcepcionDominio
{
    public ReglaNegocioException(string mensaje)
        : base(mensaje)
    {
    }
}