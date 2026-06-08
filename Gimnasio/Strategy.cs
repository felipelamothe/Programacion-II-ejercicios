using System.Collections.Generic;

namespace GimnasioAPP
{
public interface IEstrategiaCuota
{
    decimal CalcularCuota(Socio socio);
}
public class EstrategiaPaseLibre : IEstrategiaCuota
{
    private decimal _precioPromocionalPaseLibre;

    public EstrategiaPaseLibre(decimal precio)
    {
        _precioPromocionalPaseLibre = precio;
    }

    public decimal CalcularCuota(Socio socio)
    {
        // El pase libre no se ve afectado por otras promociones
        return _precioPromocionalPaseLibre;
    }
}
public class EstrategiaPorActividades : IEstrategiaCuota
{
    public decimal CalcularCuota(Socio socio)
    {
        decimal cuotaPura = 0;

        // 1. Calcular cuota pura sumando precios
        foreach (var act in socio.Actividades)
        {
            cuotaPura += act.PrecioMensual;
        }

        // 2. Consultar al Singleton si hay una promoción vigente este mes
        Promocion promoActual = GestorDePromociones.Instance().ObtenerPromocionVigente();

        if (promoActual != null)
        {
            // 3. Verificar si el socio realiza por lo menos 2 actividades de la promo
            int coincidencias = 0;
            foreach (var actSocio in socio.Actividades)
            {
                if (promoActual.ActividadesIncluidas.Contains(actSocio))
                {
                    coincidencias++;
                }
            }

            // 4. Aplicar descuento si cumple la condición
            if (coincidencias >= 2)
            {
                decimal descuento = cuotaPura * (promoActual.PorcentajeDescuento / 100m);
                cuotaPura -= descuento;
            }
        }

        return cuotaPura;
    }
}
}
