namespace consoleLybrary;
public class Hospitales : BaseSanitaria
{
private int ambulanciasTotales;//intancio informacion privada de los hospitales (encapsulamiento)
private int ambulanciasDisponibles;//intancio informacion privada de los hospitales (encapsulamiento)
private int ambulanciasEnMovimiento;//intancio informacion privada de los hospitales (encapsulamiento)
public int _ambulanciasTotales //get y setter
    {
        get{return ambulanciasTotales;}
        set{ambulanciasTotales = value;}
    }
public int _ambulanciasDisponibles //get y setter
    {
        get{return ambulanciasDisponibles;}
        set{ambulanciasDisponibles = value;}
    }
public int _ambulanciasEnMovimiento //get y setter
    {
        get{return ambulanciasEnMovimiento;}
        set{ambulanciasEnMovimiento = value;}
    }
public Hospitales(string _nombreBase, int _personal, int _ambulanciasTotales, string _direccion) //Ingreso la informacion base de la sala
    {
        this._nombreBase = _nombreBase;
        this._personal = _personal;
        this._ambulanciasTotales = _ambulanciasTotales;
        this._ambulanciasDisponibles = _ambulanciasTotales;
        this._ambulanciasEnMovimiento = 0;
        this._direccion = _direccion;
    }
public bool DespacharAmbulancia(int Cantidad) //metodo para utilizar o guardar ambulancias (no quitar o agregar total)
{
    if (Cantidad <= _ambulanciasDisponibles)
    {
        _ambulanciasDisponibles -= Cantidad;
        _ambulanciasEnMovimiento += Cantidad;
        return true; 
    }
    
    return false; 
}
public void RetornarAmbulancias(int cantidad) //metodo para decir cuantas ambulancias hay (un mini reporte)
    {
        if (cantidad <= _ambulanciasEnMovimiento)
        {
            _ambulanciasEnMovimiento -= cantidad;
            _ambulanciasDisponibles += cantidad;
        }
    }
public override string ToString() //creo un retur con toda la informacion acumulada 
    {
        double promedio = CalcularPromedioTiempo(); // calculo el promedio para dejarlo disponible
        string texto = $"--- REPORTE DEL HOSPITAL ---\n" +
                       $"Nombre: {_nombreBase}\n" +
                       $"Personal médico: {_personal}\n" +
                       $"Tiempo medio de asistencia: {Math.Round(promedio, 2)} min.\n" +
                       $"Ambulancias Totales: {_ambulanciasTotales}\n" +
                       $"Estado: {_ambulanciasDisponibles} disponibles, {_ambulanciasEnMovimiento} en movimiento.";

        return texto; 
    }
public string ModificarCantidadAmbulancias(int variacion) //modifico la cantidad de ambulancias total 
{
    if (variacion < 0)
    {
        int cantidadAQuitar = variacion * -1; 
        
        if (cantidadAQuitar > _ambulanciasDisponibles)
        {
            return $"[ERROR] No podés dar de baja {cantidadAQuitar} ambulancias. Solo hay {_ambulanciasDisponibles} disponibles en base.";
        }
    }

    _ambulanciasTotales += variacion;
    _ambulanciasDisponibles += variacion;

    if (variacion > 0)
    {
        return $"[ÉXITO] Se agregaron {variacion} ambulancias. Total en {_nombreBase}: {_ambulanciasTotales}.";
    }
    else
    {
        return $"[ÉXITO] Se dio de baja {-variacion} ambulancia(s). Total en {_nombreBase}: {_ambulanciasTotales}.";
    }
}
public override int ObtenerAmbulanciasDisponibles() //creo el return con un override para modificar el metodo heredado
    {
        return this._ambulanciasTotales; 
    }
}
