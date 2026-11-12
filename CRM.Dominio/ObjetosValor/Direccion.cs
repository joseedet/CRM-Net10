namespace CRM.Dominio.ObjetosValor;

public sealed class Direccion : ObjetoValor
{
    public string Calle { get; }

    public string Ciudad { get; }

    public string Provincia { get; }

    public string CodigoPostal { get; }

    public string Pais { get; }

    private Direccion()
    {
    }

    public Direccion(
        string calle,
        string ciudad,
        string provincia,
        string codigoPostal,
        string pais)
    {
        Calle = calle;
        Ciudad = ciudad;
        Provincia = provincia;
        CodigoPostal = codigoPostal;
        Pais = pais;
    }

    protected override IEnumerable<object?> ObtenerComponentesIgualdad()
    {
        yield return Calle;
        yield return Ciudad;
        yield return Provincia;
        yield return CodigoPostal;
        yield return Pais;
    }
}