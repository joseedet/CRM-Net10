namespace CRM.Dominio.Constantes;

/// <summary>
/// Contiene los mensajes de dominio utilizados en la aplicación.
/// </summary>
/// <remarks>
/// Esta clase proporciona constantes que representan mensajes de dominio utilizados en la aplicación. Cada constante corresponde a un mensaje específico que se puede utilizar para comunicar información relevante sobre el estado o resultado de las operaciones de dominio.
/// </remarks>
public static class MensajesDominio
{
    
    /// <summary>
    /// Mensaje que indica que el cliente no existe.
    /// </summary>
    /// <remarks>
    /// Este mensaje se utiliza para informar que el cliente especificado no se encuentra en la base de datos o no está registrado en el sistema.
    /// </remarks>
    public const string ClienteNoEncontrado =
        "El cliente no existe.";



    /// <summary>
    /// Mensaje que indica que el contacto no existe.
    /// </summary>
    /// <remarks>
    /// Este mensaje se utiliza para informar que el contacto especificado no se encuentra en la base de datos o no está registrado en el sistema.
    /// </remarks>
    public const string ContactoNoEncontrado =
        "El contacto no existe.";


    /// <summary>       
    /// Mensaje que indica que la oportunidad no existe.
    /// </summary>
    /// <remarks>
    /// Este mensaje se utiliza para informar que la oportunidad especificada no se encuentra en la base de datos o no está registrada en el sistema.
    /// </remarks>
    public const string OportunidadNoEncontrada =
        "La oportunidad no existe.";
}