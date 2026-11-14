namespace CRM.Dominio.Excepciones;

public  class ReglaNegocioException : ExcepcionDominio
{
    public ReglaNegocioException(string mensaje)
        : base(mensaje)
    {
    }
}