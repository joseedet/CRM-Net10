public class Resultado<T> : Resultado
{
    public T? Valor { get; }

    private Resultado(
        bool correcto,
        T? valor,
        string? error)
        : base(correcto, error)
    {
        Valor = valor;
    }

    public static Resultado<T> Exito(T valor)
        => new(true, valor, null);

    public static new Resultado<T> Fallo(string error)
        => new(false, default, error);
}