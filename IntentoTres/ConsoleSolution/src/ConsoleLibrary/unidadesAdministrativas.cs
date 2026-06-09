namespace consoleLybrary;

public class UnidadesAdministrativas : BaseSanitaria 
{
private List<IBaseSanitaria> basesAgrupadas;
public UnidadesAdministrativas(string _nombreBase, string _direccion)//constructor UA
    {
        this._nombreBase = _nombreBase;
        this._direccion = _direccion;
        basesAgrupadas = new List<IBaseSanitaria>(); 
    }
public void AgregarBase(IBaseSanitaria nuevaBase)//metodo para agregar una nueva base
    {
        basesAgrupadas.Add(nuevaBase);
    }
public override string ToString()//metodo para gener el texto de reporte
    {
        string texto = $"========================================\n" +
                       $" UNIDAD ADMINISTRATIVA: {_nombreBase}\n" +
                       $" Total de bases a cargo: {basesAgrupadas.Count}\n";
        for (int i = 0; i < basesAgrupadas.Count; i++)
        {
            texto += $" base {i + 1} : {basesAgrupadas[i]._nombreBase}\n";
        }
        texto += $"========================================\n\n";
        foreach (IBaseSanitaria baseHija in basesAgrupadas)
        {
            texto += baseHija.ToString() + "\n";
        }
        return texto;
    }
public string EliminarBase(IBaseSanitaria baseAEliminar)//metodo para eliminar una base sanitaria
    {
        // El método .Remove() busca el objeto. Devuelve true si lo borró, o false si no lo encontró.
        bool seBorro = basesAgrupadas.Remove(baseAEliminar);

        if (seBorro)
        {
            return $"[ÉXITO] La base '{baseAEliminar._nombreBase}' fue dada de baja de la unidad {_nombreBase}.";
        }
        else
        {
            return $"[ERROR] No se pudo eliminar. La base no pertenece a esta Unidad Administrativa.";
        }
    }
public override int ObtenerAmbulanciasDisponibles()//metodo para obtener un INT que represente las ambulancias
    {
        int sumaTotal = 0;
        
        foreach (IBaseSanitaria baseHija in basesAgrupadas)
        {
            // Le pregunta a la base (sea hospital o salita) y lo suma
            sumaTotal += baseHija.ObtenerAmbulanciasDisponibles();
        }
        
        return sumaTotal;
    }
public string ReporteBreveAmbulancias()//metodo para reportar la cantidad total de las almbulancias en forma texto
{
    // Reutilizamos tu propio método de cálculo
    int total = ObtenerAmbulanciasDisponibles();
    
    // Devolvemos la oración ya armada
    return $"=== FLOTA DE {this._nombreBase.ToUpper()} ===\nTotal de unidades disponibles: {total}";
}
public override double CalcularPromedioTiempo()//usando polimorfismo y override calculo tiempos
{
    if (basesAgrupadas.Count == 0)
    {
        return 0;
    }
    double sumaPromedios = 0;
    foreach (IBaseSanitaria baseHija in basesAgrupadas)
    {
        sumaPromedios += baseHija.CalcularPromedioTiempo();
    }
    return sumaPromedios / basesAgrupadas.Count;
}
public string ReporteBreveTiempoMedio()//metodo para reportar la cantidad promedio de los tiempos totales de la UA
    {
        double promedioGeneral = CalcularPromedioTiempo();
        return $"=== TIEMPOS DE {this._nombreBase.ToUpper()} ===\n" +
               $"El tiempo medio de asistencia de la región es: {promedioGeneral:F2} minutos.";
    }
}