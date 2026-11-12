using CRM.Dominio.ObjetosValor;
using CRM.Dominio.Excepciones;

namespace CRM.Seguridad.Dominio.ObjetosValor;

public sealed class NombreCompleto : ObjetoValor
{
    public string Nombre { get; }

    public string Apellidos { get; }

    private NombreCompleto()
    {
    }

    public NombreCompleto(
        string nombre,
        string apellidos)
    {
        if (string.IsNullOrWhiteSpace(nombre))
        {
            throw new ValidacionDominioException(
                "El nombre es obligatorio.");
        }

        if (string.IsNullOrWhiteSpace(apellidos))
        {
            throw new ValidacionDominioException(
                "Los apellidos son obligatorios.");
        }

        Nombre = nombre.Trim();

        Apellidos = apellidos.Trim();
    }

    protected override IEnumerable<object?> ObtenerComponentesIgualdad()
    {
        yield return Nombre;
        yield return Apellidos;
    }

    public override string ToString()
    {
        return $"{Nombre} {Apellidos}";
    }
}