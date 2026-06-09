namespace ConsoleLibrary
{
    public class Nivel2 : IEstrategiaSoporte
    {
        public bool PuedeResolver(Solicitud solicitud)
        {
            return solicitud.Complejidad <= 4 && solicitud.Categoria == "Software";
        }

        public void Resolver(Solicitud solicitud)
        {
            Console.WriteLine($"[Nivel 2] Solicitud de {solicitud.Categoria} (Compl: {solicitud.Complejidad}) RESUELTA en soporte técnico.");
        }
    }
}
    