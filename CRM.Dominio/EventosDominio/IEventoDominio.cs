namespace CRM.Dominio.EventosDominio;

///<summary>    
/// Interfaz que define la estructura básica de un evento de dominio en el sistema.
/// </summary>
///<remarks>
/// Esta interfaz proporciona un contrato que todos los eventos de dominio deben cumplir, asegurando que cada evento tenga una fecha de ocurrencia asociada. La implementación de esta interfaz permite a las entidades del dominio generar eventos que pueden ser manejados de manera uniforme, facilitando la comunicación entre diferentes partes del sistema y promoviendo una arquitectura basada en eventos. Al definir esta interfaz, se establece un estándar para la creación y manejo de eventos de dominio, lo que contribuye a la consistencia y mantenibilidad del código en el sistema.
/// </remarks>
public interface IEventoDominio
{
    DateTime FechaOcurrencia { get; }
}