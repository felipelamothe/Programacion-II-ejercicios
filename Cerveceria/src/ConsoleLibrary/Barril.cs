namespace ConsoleLibrary;
public class Barril
{
    private Cerveza _cerveza;
    public Cerveza Cerveza
    {
        get { return _cerveza; }
        set { _cerveza = value; }
    }

    private double _capacidadLitros;
    public double CapacidadLitros
    {
        get { return _capacidadLitros; }
        set { _capacidadLitros = value; }
    }

    public double CostoTotal()
    {
        return Cerveza.CostoPorLitro() *this.CapacidadLitros;
    }
}