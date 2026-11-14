namespace CRM.Dominio.Interfaces;
/// <summary>
/// Interfaz que define los métodos para registrar auditoría en el sistema.
/// </summary>
/// <remarks>
/// Esta interfaz proporciona un contrato para los servicios de auditoría en el sistema, permitiendo registrar acciones realizadas sobre entidades específicas. La auditoría es esencial para mantener un historial de cambios y actividades dentro del sistema, facilitando la trazabilidad y el cumplimiento de políticas de seguridad y control. Implementar esta interfaz permite a los desarrolladores crear servicios de auditoría que registren información relevante sobre las operaciones realizadas, incluyendo la entidad afectada, la acción ejecutada y el identificador de la entidad, lo que ayuda a garantizar la integridad y la responsabilidad en el manejo de datos dentro del sistema.
/// </remarks>
public interface IAuditoriaServicio
{
    Task RegistrarAsync(
        string entidad,
        string accion,
        Guid entidadId);
}