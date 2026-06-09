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
            Console.WriteLine($"[Nivel 3] Solicitud de {solicitud.Categoria} (Compl: {solicitud.Complejidad}) RESUELTA por especialistas.");
        }
    }
}