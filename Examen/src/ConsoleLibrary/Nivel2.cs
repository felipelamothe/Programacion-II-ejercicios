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
            Console.WriteLine("El Nivel 2 resolvio la solicitud de la categoria: " + solicitud.Categoria);
        }
    }
}
    