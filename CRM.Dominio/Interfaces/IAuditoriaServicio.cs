public interface IAuditoriaServicio
{
    Task RegistrarAsync(
        string entidad,
        string accion,
        Guid entidadId);
}