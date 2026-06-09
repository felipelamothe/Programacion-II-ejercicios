namespace consoleLybrary;

public interface IBaseSanitaria //esta es la interzas para tener contratos, es solid
{
    string _nombreBase { get; }
    string _direccion { get; }
    void RegistrarTiempo(double nuevoTiempo);
    double CalcularPromedioTiempo();
    string? ToString();
    int ObtenerAmbulanciasDisponibles();

}