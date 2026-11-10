public class Resultado
{
    public bool Correcto { get; }

    public string? Error { get; }

    protected Resultado(bool correcto, string? error)
    {
        Correcto = correcto;
        Error = error;
    }

    public static Resultado Exito()
        => new(true, null);

    public static Resultado Fallo(string error)
        => new(false, error);
}