
namespace CRM.Dominio.ObjetosValor;

public sealed class NumeroTelefono : ObjetoValor
{
    public string Valor { get; }

    private NumeroTelefono()
    {
    }

    public NumeroTelefono(string valor)
    {
        Valor = valor.Trim();
    }

    protected override IEnumerable<object?> ObtenerComponentesIgualdad()
    {
        yield return Valor;
    }
}