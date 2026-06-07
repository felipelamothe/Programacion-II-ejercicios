namespace ConsoleLibrary;
public abstract class TipoVaso
{
    private Cerveza? _cerveza;
    public Cerveza Cerveza
    {
        get { return _cerveza; }
        set { _cerveza = value; }
    }
    public abstract double CapacidadEnLitros();

    public double CostoVaso()
    {
        return this.CapacidadEnLitros() * Cerveza.CostoPorLitro();
    }
}