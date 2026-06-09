namespace ConsoleLibrary
{
    public class ProveedorExterno : IEstrategiaSoporte
    {
        public bool PuedeResolver(Solicitud solicitud)
        {
            return true;
        }

        public void Resolver(Solicitud solicitud)
        {
            Console.WriteLine("Ningun nivel interno pudo resolverlo. El Proveedor Externo atiende la categoria: " + solicitud.Categoria);
        }
    }
}