namespace ConsoleLibrary;
public class DetalleVenta
{
    private int _cantidad;
    public int Cantidad
    {
        get { return _cantidad; }
        set { _cantidad = value; }
    }

    private TipoVaso _tipoVaso;
    public TipoVaso TipoVaso
    {
        get { return _tipoVaso; }
        set { _tipoVaso = value; }
    }
    public double SubTotalCosto()
    {
        return Cantidad * TipoVaso.CostoVaso();
    }
}