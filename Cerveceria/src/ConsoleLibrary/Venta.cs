namespace ConsoleLibrary;

public class Venta
{

    private List<DetalleVenta> _detallesVenta;
    public List<DetalleVenta> DetallesVenta
    {
        get { return _detallesVenta; }
        set { _detallesVenta = value; }
    }

    public Venta()
    {
        DetallesVenta = new List<DetalleVenta>();
    }
    private DateTime _fecha;
    public DateTime FechaVenta
    {
        get { return _fecha; }
        set { _fecha = value; }
    }

    public double CostoTotal()
    {
        double costoTotal = 0.0;
        foreach (DetalleVenta detalle in DetallesVenta)
        {
            costoTotal += detalle.SubTotalCosto();
        }

        Console.WriteLine("En la Venta CostoTotal(): " + costoTotal);

        return costoTotal;
    }
}