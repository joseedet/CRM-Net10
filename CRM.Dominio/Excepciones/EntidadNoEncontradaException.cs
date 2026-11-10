namespace CRM.Dominio.Excepciones;

public sealed class EntidadNoEncontradaException : ExcepcionDominio
{
    public EntidadNoEncontradaException(string entidad, Guid id)
        : base($"No se encontró la entidad '{entidad}' con identificador '{id}'.")
    {
    }

    public EntidadNoEncontradaException(string mensaje)
        : base(mensaje)
    {
    }
}