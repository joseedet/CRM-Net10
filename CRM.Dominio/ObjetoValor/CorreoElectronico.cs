
namespace CRM.Dominio.ObjetoValor;

public sealed class CorreoElectronico : ObjetoValor
{
        public string Valor { get; }

        private CorreoElectronico()
        {
        }

        public CorreoElectronico(string valor)
        {
            if (string.IsNullOrWhiteSpace(valor))
                throw new ValidacionDominioException("El correo es obligatorio.");

            Valor = valor.Trim().ToLower();
        }

        protected override IEnumerable<object?> ObtenerComponentesIgualdad()
        {
            yield return Valor;
        }
}