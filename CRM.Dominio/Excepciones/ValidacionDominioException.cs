namespace CRM.Dominio.Excepciones;

public sealed class ValidacionDominioException : ExcepcionDominio
{
    public ValidacionDominioException(string mensaje)
        : base(mensaje)
    {
    }
}