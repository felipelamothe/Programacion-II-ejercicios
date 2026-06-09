namespace consoleLybrary;

public abstract class BaseSanitaria : IBaseSanitaria //creo una clase abstracta para heredar la informacion a las siguientes 3 clases (hospital, UAP y UA)
{


private int personal; //guardo informacion privada de "todas" las bases sanitarias (encapsulamiento)
public int _personal //gets y setters
    {
        get{return personal;}
        protected set{personal = value;}
    }


private string nombreBase = ""; //guardo informacion privada de "todas" las bases sanitarias (encapsulamiento)
public string _nombreBase //gets y setters

    {
        get { return nombreBase; }
        protected set { nombreBase = value; }
    }


private List<double> HistorialTiempos = new List<double>(); //creo una lista para poder guardar los tiempos y procesarlos
public void RegistrarTiempo(double nuevoTiempo) //registro los tiempos para la lista
    {
        if (nuevoTiempo > 0)
        {
            HistorialTiempos.Add(nuevoTiempo);
        }
    }
public virtual double CalcularPromedioTiempo() //promediolos tiempos
    {
        if (HistorialTiempos.Count == 0) 
        {
            return 0; 
        }
        double sumaTotal = 0;
        foreach (double tiempo in HistorialTiempos)
        {
            sumaTotal += tiempo;
        }
        return sumaTotal / HistorialTiempos.Count;
    }


private string direccion = ""; //agrego la variable direccion
public string _direccion //gets y setters
    {
        get { return direccion; }
        protected set { direccion = value; }
    }
public string PedirDireccion()//metodo para solicitar la direccion 
{
    return $"La dirección de {_nombreBase} es {_direccion}.";
}
public virtual int ObtenerAmbulanciasDisponibles() //metodo para obtener ambulancias
{
    return 0; // Por defecto, nadie tiene ambulancias
}

}

