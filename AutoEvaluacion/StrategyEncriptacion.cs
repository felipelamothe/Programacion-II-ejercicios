namespace ConsoleLibrary;
public class StrategyEncriptacion : ManejadorDocumentoStrategy
{
    public override Documento ProcesarDocumento(Documento documento)
    {
        string texto = "Encriptamos este documento: " + documento.Texto;
        string nuevoNombre = "Encriptado_" + documento.Nombre;
        documento.Nombre = nuevoNombre;
        documento.Texto = texto;
        
        Console.WriteLine("El texto encriptado es " + documento.Texto);
        Console.WriteLine("Y el nombre que le quedo al documento es " + documento.Nombre);
        return documento;
    }


}