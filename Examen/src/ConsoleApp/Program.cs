using System;
using System.Collections.Generic;
using ConsoleLibrary;


public class Program
    {
        public static void Main()
        {
            CentroSoporte centro = new CentroSoporte();

            centro.AgregarEstrategia(new Nivel1());
            centro.AgregarEstrategia(new Nivel2());
            centro.AgregarEstrategia(new Nivel3());
            centro.AgregarEstrategia(new ProveedorExterno());

            Solicitud s1 = new Solicitud("Cuenta", 1);
            Solicitud s2 = new Solicitud("Software", 4);
            Solicitud s3 = new Solicitud("Hardware", 5); 

            Console.WriteLine("Evaluando Solicitud 1");
            centro.AtenderSolicitud(s1);

            Console.WriteLine("\nEvaluando Solicitud 2 ");
            centro.AtenderSolicitud(s2);

            Console.WriteLine("\nEvaluando Solicitud 3");
            centro.AtenderSolicitud(s3);
        }
    }