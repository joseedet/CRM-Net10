using CRM.Dominio.Excepciones;

namespace CRM.Dominio.ObjetosValor;


///<summary>    
/// Representa un objeto de valor que encapsula la lógica de validación y normalización de direcciones de correo electrónico dentro del dominio del sistema.
/// </summary>
///<remarks>
/// Esta clase proporciona una forma de manejar direcciones de correo electrónico como objetos de valor, asegurando que se cumplan las reglas de validación y normalización definidas para este tipo de datos. Al encapsular la lógica de validación y normalización dentro de esta clase, se garantiza que todas las direcciones de correo electrónico utilizadas en el sistema cumplan con los estándares y restricciones establecidos, evitando errores y inconsistencias en el manejo de datos relacionados con el correo electrónico. Esto es esencial para mantener la integridad de los datos y facilitar la gestión de la información de contacto dentro del sistema, asegurando que las direcciones de correo electrónico sean válidas, consistentes y estén correctamente formateadas en todas las operaciones y procesos que involucren este tipo de información.  
/// </remarks>
public sealed class CorreoElectronico : ObjetoValor
{
        ///<summary>    
        /// Obtiene el valor de la dirección de correo electrónico.
        /// </summary>
        /// <remarks>
        /// Esta propiedad proporciona acceso al valor de la dirección de correo electrónico encapsulada en el objeto de valor. Al exponer el valor de la dirección de correo electrónico, se permite a los desarrolladores y usuarios acceder a la información de contacto de manera segura y controlada, asegurando que se cumplan las reglas de validación y normalización definidas para este tipo de datos. Esto es útil para mostrar, almacenar o procesar direcciones de correo electrónico en diferentes contextos dentro del sistema, garantizando que la información de contacto sea precisa, consistente y esté correctamente formateada en todas las operaciones y procesos que involucren este tipo de información.  
        /// </remarks>
        public string Valor { get; }


        ///<summary>    
        /// Inicializa una nueva instancia de la clase CorreoElectronico con un valor específico.
        /// </summary>
        ///<param name="valor">El valor de la dirección de correo electrónico.</param>
        ///<remarks>
        /// Este constructor permite crear una instancia del objeto de valor CorreoElectronico proporcionando un valor específico que representa la dirección de correo electrónico. Al utilizar este constructor, se asegura que el valor proporcionado cumpla con las reglas de validación y normalización definidas para este tipo de datos, garantizando que la dirección de correo electrónico sea válida, consistente y esté correctamente formateada en todas las operaciones y procesos que involucren este tipo de información. Esto es esencial para mantener la integridad de los datos y facilitar la gestión de la información de contacto dentro del sistema, asegurando que las direcciones de correo electrónico sean precisas y confiables en todas las interacciones y transacciones que involucren este tipo de información.  
        /// </remarks>   
        private CorreoElectronico()
        {
        }

        ///<summary>    
        /// Inicializa una nueva instancia de la clase CorreoElectronico con un valor específico.
        /// </summary>
        ///<param name="valor">El valor de la dirección de correo electrónico.</param>
        ///<remarks>
        /// Este constructor permite crear una instancia del objeto de valor CorreoElectronico proporcionando un valor específico que representa la dirección de correo electrónico. Al utilizar este constructor, se asegura que el valor proporcionado cumpla con las reglas de validación y normalización definidas para este tipo de datos, garantizando que la dirección de correo electrónico sea válida, consistente y esté correctamente formateada en todas las operaciones y procesos que involucren este tipo de información. Esto es esencial para mantener la integridad de los datos y facilitar la gestión de la información de contacto dentro del sistema, asegurando que las direcciones de correo electrónico sean precisas y confiables en todas las interacciones y transacciones que involucren este tipo de información.  
        /// </remarks>  
        /// <exception cref="ValidacionDominioException">
        /// Se lanza cuando el valor proporcionado es nulo, vacío o contiene solo espacios en blanco, indicando que la dirección de correo electrónico es obligatoria y no puede estar vacía.   
        /// </exception>     
    
        public CorreoElectronico(string valor)
        {
            if (string.IsNullOrWhiteSpace(valor))
                throw new ValidacionDominioException("El correo es obligatorio.");

            Valor = valor.Trim().ToLower();
        }

        ///<summary>    
        /// Obtiene una representación en cadena del objeto de valor CorreoElectronico.
        /// </summary>
        ///<returns>
        /// Devuelve una cadena que representa el valor de la dirección de correo electrónico encapsulada en el objeto de valor.
        /// </returns>
        ///<remarks>
        /// Este método proporciona una forma de obtener una representación en cadena del objeto de valor CorreoElectronico, lo que permite a los desarrolladores y usuarios acceder al valor de la dirección de correo electrónico de manera legible y comprensible. Al llamar a este método, se devuelve una cadena que representa el valor de la dirección de correo electrónico, lo que facilita su visualización, almacenamiento o procesamiento en diferentes contextos dentro del sistema. Esto es útil para mostrar, registrar o transmitir direcciones de correo electrónico en un formato legible y consistente, asegurando que la información de contacto sea precisa y esté correctamente formateada en todas las operaciones y procesos que involucren este tipo de información.
        /// </remarks>
        protected override IEnumerable<object?> ObtenerComponentesIgualdad()
        {
            yield return Valor;
        }
}