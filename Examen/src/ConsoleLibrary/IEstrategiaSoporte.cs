namespace ConsoleLibrary
{
    public interface IEstrategiaSoporte
    {
        bool PuedeResolver(Solicitud solicitud);
        void Resolver(Solicitud solicitud);
    }
}