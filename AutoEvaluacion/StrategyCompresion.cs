namespace ConsoleLibrary;
public class StrategyCompresion : ManejadorDocumentoStrategy
{
    public override Documento ProcesarDocumento(Documento documento)
    {
        string texto = "Comprimimos este documento: " + documento.Texto;
        string nuevoNombre = documento.Nombre + ".zip";

        documento.Nombre = nuevoNombre;
        documento.Texto = texto;
        Console.WriteLine("El texto comprimido: " + documento.Texto);
        Console.WriteLine("Procesamos el documento con compresion + " + documento.Nombre);
        return documento;
    }
}