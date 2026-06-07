namespace ConsoleLibrary;

public class Empresa
{
    private ManejadorDocumentoStrategy _manejadorDocumentoStrategy;

    public ManejadorDocumentoStrategy Estrategia()
    {
        return _manejadorDocumentoStrategy;
    }

    public void CambiarEstrategia(ManejadorDocumentoStrategy manejadorDocumentoStrategy)
    {
        _manejadorDocumentoStrategy = manejadorDocumentoStrategy;
    }

    public Empresa(ManejadorDocumentoStrategy manejadorDocumentoStrategy)
    {
        _manejadorDocumentoStrategy = manejadorDocumentoStrategy;
    }
}
