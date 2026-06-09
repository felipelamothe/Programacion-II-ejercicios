namespace ConsoleLibrary
{
    public class Nivel1 : IEstrategiaSoporte
    {
        public bool PuedeResolver(Solicitud solicitud)
        {
            return solicitud.Complejidad <= 2 &&
                  (solicitud.Categoria == "Cuenta" || solicitud.Categoria == "Acceso");
        }

        public void Resolver(Solicitud solicitud)
        {
            Console.WriteLine($"[Nivel 1] Solicitud de {solicitud.Categoria} (Compl: {solicitud.Complejidad}) RESUELTA en soporte básico.");
        }
    }
}