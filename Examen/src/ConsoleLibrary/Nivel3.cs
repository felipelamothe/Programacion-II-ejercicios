namespace ConsoleLibrary
{
public class Nivel3 : IEstrategiaSoporte
    {
        public bool PuedeResolver(Solicitud solicitud)
        {
            return solicitud.Complejidad <= 5 && solicitud.Categoria == "Infraestructura";
        }

        public void Resolver(Solicitud solicitud)
        {
            Console.WriteLine("El Nivel 3 especialistas resolvio la solicitud de la categoria: " + solicitud.Categoria);
        }
    }
}