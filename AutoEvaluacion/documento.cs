using ConsoleLibrary;
public class Documento
{
    private string _nombre = "";
    private string _texto = "";
    public string Nombre
    {
        get { return _nombre; }
        set { _nombre = value; }
    }
    public string Texto
    {
        get { return _texto; }
        set { _texto = value; }
    }
}