namespace ConsoleLibrary
{
    public class Nivel1 : IEstrategiaSoporte
    {
        public bool PuedeResolver(Solicitud solicitud)
        {
            return solicitud.Complejidad <= 2 && (solicitud.Categoria == "Cuenta" || solicitud.Categoria == "Acceso");
        }

        public void Resolver(Solicitud solicitud)
        {
            Console.WriteLine("El Nivel 1 resolvio la solicitud de la categoria: " + solicitud.Categoria);
        }
    }

}