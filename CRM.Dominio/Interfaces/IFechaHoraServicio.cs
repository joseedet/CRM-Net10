namespace CRM.Dominio.Interfaces;

/// <summary>
/// Interfaz que define los métodos para obtener la fecha y hora actual en formato UTC.
/// </summary>
/// <remarks>
/// Esta interfaz proporciona un contrato para los servicios que necesitan obtener la fecha y hora actual en formato UTC. Esto es útil para garantizar la consistencia en el manejo de fechas y horas en todo el sistema, especialmente en aplicaciones distribuidas o que operan en múltiples zonas horarias. Implementar esta interfaz permite a los desarrolladores acceder a la fecha y hora actual de manera centralizada, facilitando la sincronización de eventos, registros y operaciones que dependen del tiempo, asegurando que todas las partes del sistema utilicen una referencia temporal uniforme y confiable.
/// </remarks>
public interface IFechaHoraServicio
{
    DateTime UtcNow { get; }
}