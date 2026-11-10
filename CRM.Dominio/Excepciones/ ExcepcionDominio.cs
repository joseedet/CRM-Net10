namespace CRM.Dominio.Excepciones;

public abstract class ExcepcionDominio : Exception
{
    protected ExcepcionDominio(string mensaje)
        : base(mensaje)
    {
    }
}