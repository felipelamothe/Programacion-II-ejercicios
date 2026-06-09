using System;
using System.Collections.Generic;
using ConsoleLibrary;


public class Program
    {
        public static void Main()
        {
            // 1. Instanciamos el Contexto
            CentroSoporte centro = new CentroSoporte();

            // 2. Configuramos el orden de las estrategias dinámicamente agregándolas a la lista
            centro.AgregarEstrategia(new Nivel1());
            centro.AgregarEstrategia(new Nivel2());
            centro.AgregarEstrategia(new Nivel3());
            centro.AgregarEstrategia(new ProveedorExterno());

            // 3. Creamos solicitudes de prueba
            Solicitud s1 = new Solicitud("Cuenta", 1);
            Solicitud s2 = new Solicitud("Software", 4);
            Solicitud s3 = new Solicitud("Hardware", 5); // Fallará en todos y caerá en el externo

            Console.WriteLine("--- Evaluando Solicitud 1 ---");
            centro.AtenderSolicitud(s1);

            Console.WriteLine("\n--- Evaluando Solicitud 2 ---");
            centro.AtenderSolicitud(s2);

            Console.WriteLine("\n--- Evaluando Solicitud 3 ---");
            centro.AtenderSolicitud(s3);
        }
    }