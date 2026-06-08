using System;
using System.Collections.Generic;

namespace GimnasioAPP
{           
class Program 
{
    static void Main() 
    {
        // 1. Crear algunas actividades
        Actividad musculacion = new Actividad("Musculación", 2000m);
        Actividad pileta = new Actividad("Pileta", 3000m);
        Actividad zumba = new Actividad("Zumba", 1500m);

        // 2. El gerente crea y establece la promoción del mes (Singleton)
        Promocion promoVerano = new Promocion("Promo Verano", 20m); // 20% off
        promoVerano.ActividadesIncluidas.Add(musculacion);
        promoVerano.ActividadesIncluidas.Add(pileta);
        
        GestorDePromociones.Instance().EstablecerPromocion(promoVerano);

        // 3. Crear un socio normal que hace Musculación y Pileta
        Socio socioNormal = new Socio { Nombre = "Juan", Apellido = "Pérez" };
        socioNormal.AgregarActividad(musculacion);
        socioNormal.AgregarActividad(pileta);
        // Le asignamos la estrategia de cobro por actividad
        socioNormal.EstrategiaDeCobro = new EstrategiaPorActividades(); 
        
        // Al calcular, aplicará el descuento porque hace 2 actividades de la promo vigente.
        decimal totalNormal = socioNormal.CalcularCuotaMensual(); 

        // 4. Crear un socio VIP con pase libre
        Socio socioVip = new Socio { Nombre = "María", Apellido = "Gómez" };
        socioVip.AgregarActividad(musculacion);
        socioVip.AgregarActividad(pileta);
        socioVip.AgregarActividad(zumba);
        // Le asignamos la estrategia de Pase Libre ($4000 fijos)
        socioVip.EstrategiaDeCobro = new EstrategiaPaseLibre(4000m); 

        // Al calcular, ignorará la promoción e ignorará la suma individual.
        decimal totalVip = socioVip.CalcularCuotaMensual();

            Console.WriteLine($"Cuota Socio Normal ({socioNormal.Nombre} {socioNormal.Apellido}): {totalNormal}");
            Console.WriteLine($"Cuota Socio VIP ({socioVip.Nombre} {socioVip.Apellido}): {totalVip}");
        }
}
}