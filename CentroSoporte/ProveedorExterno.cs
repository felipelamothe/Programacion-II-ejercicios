namespace ConsoleLibrary
{
    public class ProveedorExterno : IEstrategiaSoporte
    {
        public bool PuedeResolver(Solicitud solicitud)
        {
            // El proveedor externo es el "comodín" final, siempre acepta el problema.
            return true;
        }

        public void Resolver(Solicitud solicitud)
        {
            Console.WriteLine($"[Proveedor Externo] SOLICITUD NO RESUELTA INTERNAMENTE. Categoría: {solicitud.Categoria}. Derivando a terceros.");
        }
    }
}