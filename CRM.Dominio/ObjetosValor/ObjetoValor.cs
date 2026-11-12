namespace CRM.Dominio.ObjetosValor;

public abstract class ObjetoValor
{
    protected abstract IEnumerable<object?> ObtenerComponentesIgualdad();

    public override bool Equals(object? obj)
    {
        if (obj is null || obj.GetType() != GetType())
            return false;

        var otro = (ObjetoValor)obj;

        return ObtenerComponentesIgualdad()
            .SequenceEqual(otro.ObtenerComponentesIgualdad());
    }

    public override int GetHashCode()
    {
        return ObtenerComponentesIgualdad()
            .Aggregate(0, HashCode.Combine);
    }

    public static bool operator ==(
        ObjetoValor? izquierda,
        ObjetoValor? derecha)
    {
        return Equals(izquierda, derecha);
    }

    public static bool operator !=(
        ObjetoValor? izquierda,
        ObjetoValor? derecha)
    {
        return !(izquierda == derecha);
    }
    
    /*public sealed class NumeroTelefono : ObjetoValor
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
    }*/
}