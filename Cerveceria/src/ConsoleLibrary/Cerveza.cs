namespace ConsoleLibrary;

public abstract class Cerveza
{

    private string _nombre;
    public string Nombre
    {
        get { return _nombre; }
        set { _nombre = value; }
    }

    public abstract double CostoPorLitro();
}
