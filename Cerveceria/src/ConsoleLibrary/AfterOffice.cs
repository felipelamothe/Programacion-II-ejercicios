namespace ConsoleLibrary;
public class AfterOffice
{
    public AfterOffice()
    {
    }  
    //public static AfterOffice Instance;
    
    public readonly double MargenGanancia = 0.5;

    private Venta ventaDelDia;

    public void AgregarCervezasAlPedido(int cantidad, TipoVaso tipoVaso)
    {

        if (ventaDelDia == null)
        {
            ventaDelDia = new Venta();
            ventaDelDia.FechaVenta = DateTime.Now;
        }

        DetalleVenta detalle = new DetalleVenta();
        detalle.Cantidad = cantidad;
        detalle.TipoVaso = tipoVaso;

        ventaDelDia.DetallesVenta.Add(detalle);
    }

    public Venta DevolverVentaDelDia()
    {
        return ventaDelDia;
    }

    public double ObtenerVentasTotalesConMargen()
    {
        double ventasTotales = ventaDelDia.CostoTotal();
        return ventasTotales * (1 + MargenGanancia);
    }   

}